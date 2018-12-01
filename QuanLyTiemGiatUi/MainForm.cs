using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTiemGiatUi.DataAccess;

namespace QuanLyTiemGiatUi
{
	public partial class frmMain : Form
	{
		private long servicePrice = 0;
		private float orderWeight = 0;
		private decimal price = 0;
		private int isDelivery = 0;
		private bool initialized = false;
		private int pendingOrderID;
		private int unpaidOrderID;

		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load( object sender, EventArgs e )
		{
			// TODO: This line of code loads data into the 'quanLyGiatUiDataSet.Services' table. You can move, or remove it, as needed.
			this.servicesTableAdapter.Fill(this.quanLyGiatUiDataSet.Services);
			// TODO: This line of code loads data into the 'quanLyGiatUiDataSet.UnpaidOrder' table. You can move, or remove it, as needed.
			this.unpaidOrderTableAdapter.Fill(this.quanLyGiatUiDataSet.UnpaidOrder);
			// TODO: This line of code loads data into the 'quanLyGiatUiDataSet.PendingOrder' table. You can move, or remove it, as needed.
			this.pendingOrderTableAdapter.Fill(this.quanLyGiatUiDataSet.PendingOrder);
			cboService.DataSource = DataProvider.Instance.GetAllServices();
			cboService.DisplayMember = "Name";
			cboService.ValueMember = "Price";
			initialized = true;
		}

		#region	submenu-click

		private void menuOrder_Click( object sender, EventArgs e )
		{
			new OrderForm().ShowDialog();
		}

		private void menuServices_Click( object sender, EventArgs e )
		{
			ServiceForm frmService = new ServiceForm();
			frmService.FormClosed += new FormClosedEventHandler(this.frmSer_Closed);
			frmService.ShowDialog();

		}

		private void frmSer_Closed( object sender, FormClosedEventArgs e )
		{
			gridService.DataSource = DataProvider.Instance.GetAllServices();
		}

		private void menuStaff_Click( object sender, EventArgs e )
		{
			new StaffForm().ShowDialog();
		}

		private void menuReport_Click( object sender, EventArgs e )
		{
			new ReportForm().ShowDialog();
		}

		#endregion

		#region FromCloseHandling

		private void frmMain_FormClosing( object sender, FormClosingEventArgs e )
		{
			DialogResult choice = MessageBox.Show("Bạn có thật sự muốn thoát ?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (choice == DialogResult.No)
			{
				e.Cancel = true;
			}
		}

		private void menuLogout_Click( object sender, EventArgs e )
		{
			DialogResult choice = MessageBox.Show("Bạn có thực sự muốn đăng xuất ?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (choice == DialogResult.Yes)
			{
				this.Hide();
				this.Close();
				new frmLogin().ShowDialog();
			}
		}

		#endregion

		#region Order Tab

		private void numWeight_ValueChanged( object sender, EventArgs e )
		{
			CalculatePrice();
			lblPrice.Text = price.ToString("# ###") + " VND";
		}

		private void cboService_SelectedIndexChanged( object sender, EventArgs e )
		{
			CalculatePrice();
			lblPrice.Text = price.ToString("# ###") + " VND";
		}

		public void CalculatePrice()
		{
			orderWeight = Convert.ToSingle(numWeight.Value);
			servicePrice = Convert.ToInt64(cboService.SelectedValue);
			price = Convert.ToDecimal(orderWeight * servicePrice);
			//lblPrice.Text = (orderWeight * servicePrice).ToString() + " VND";
		}

		private void txtPhoneNum_KeyPress( object sender, KeyPressEventArgs e )
		{
			var key = e.KeyChar;
			if (!"0123456789\b\0177".Contains(key))
			{
				e.Handled = true;
			}
		}

		private void gridService_RowEnter( object sender, DataGridViewCellEventArgs e )
		{
			if (initialized)
			{
				cboService.SelectedIndex = e.RowIndex;
			}
		}

		private void btnCreateOrder_Click( object sender, EventArgs e )
		{
			if (txtCusName.Text == "" || txtPhoneNum.Text == "" || txtAddress.Text == "" || txtOrderName.Text == "")
			{
				MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				DataProvider.Instance.InsertOrder(txtCusName.Text, txtPhoneNum.Text, txtAddress.Text, txtOrderName.Text, cboService.Text, Convert.ToSingle(numWeight.Value), isDelivery, price);
				MessageBox.Show("Phiếu giặt đã được tạo !", "Thông báo");
				ResetFields();
			}
		}

		private void radDeliver_CheckedChanged( object sender, EventArgs e )
		{
			isDelivery = 1;
			if (radDeliver.Checked)
			{
				price += 5000m;
				lblPrice.Text = price.ToString() + " VND";
			}
		}

		private void radAtStore_CheckedChanged( object sender, EventArgs e )
		{
			isDelivery = 0;
			if (radAtStore.Checked)
			{
				price -= 5000m;
				lblPrice.Text = price.ToString() + " VND";
			}
		}

		private void ResetFields()
		{
			txtCusName.ResetText();
			txtPhoneNum.ResetText();
			txtAddress.ResetText();
			txtOrderName.ResetText();
			cboService.SelectedIndex = 0;
			radAtStore.Checked = true;
			numWeight.Value = 0.1m;
		}

		private void btnCancel_Click( object sender, EventArgs e )
		{
			ResetFields();
		}

		#endregion`

		#region	Pending Tab
		private void gridPendingOrder_SelectionChanged( object sender, EventArgs e )
		{

			foreach (DataGridViewRow item in gridPendingOrder.SelectedRows)
			{
				pendingOrderID = Convert.ToInt32(item.Cells[0].Value);
			}
		}

		private void btnAcceptOrder_Click( object sender, EventArgs e )
		{
			DataProvider.Instance.AcceptOrder(pendingOrderID);
			this.pendingOrderTableAdapter.Fill(this.quanLyGiatUiDataSet.PendingOrder);
			MessageBox.Show("Đã tiếp nhận !", "Thông báo");
		}

		#endregion

		#region Unpaid Tab


		private void btnPaid_Click( object sender, EventArgs e )
		{
			DataProvider.Instance.SetPaidOrder(unpaidOrderID);
			this.unpaidOrderTableAdapter.Fill(this.quanLyGiatUiDataSet.UnpaidOrder);
			MessageBox.Show("Đã thanh toán !", "Thông báo");
		}

		private void gridUnpaidOrder_SelectionChanged( object sender, EventArgs e )
		{
			foreach (DataGridViewRow item in gridUnpaidOrder.SelectedRows)
			{
				unpaidOrderID = Convert.ToInt32(item.Cells[0].Value);
			}
		}

		#endregion

		#region TabEnterEvent

		private void tabUnpaid_Enter( object sender, EventArgs e )
		{
			this.unpaidOrderTableAdapter.Fill(this.quanLyGiatUiDataSet.UnpaidOrder);
		}

		private void tabPending_Enter( object sender, EventArgs e )
		{
			this.pendingOrderTableAdapter.Fill(this.quanLyGiatUiDataSet.PendingOrder);
		}

		#endregion
	}
}
