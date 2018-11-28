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
		long servicePrice = 0;
		float orderWeight = 0;

		public frmMain()
		{
			InitializeComponent();
			LoadService();
		}

		void LoadService()
		{
			gridService.DataSource = DataProvider.Instance.GetAllServices();
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
		#endregion

		private void frmMain_FormClosing( object sender, FormClosingEventArgs e )
		{
			DialogResult choice = MessageBox.Show("Bạn có thật sự muốn thoát ?", "Xác nhận thoát", MessageBoxButtons.YesNo);
			if (choice == DialogResult.No)
			{
				e.Cancel = true;
			}
		}

		private void menuLogout_Click( object sender, EventArgs e )
		{
			DialogResult choice = MessageBox.Show("Bạn có thực sự muốn đăng xuất ?", "Đăng xuất", MessageBoxButtons.YesNo);
			if (choice == DialogResult.Yes)
			{
				this.Hide();
				this.Close();
				new frmLogin().ShowDialog();
			}
		}

		private void frmMain_Load( object sender, EventArgs e )
		{
			// TODO: This line of code loads data into the 'quanLyGiatUiDataSet.Services' table. You can move, or remove it, as needed.
			this.servicesTableAdapter.Fill(this.quanLyGiatUiDataSet.Services);
			//cboService.DataSource = DataProvider.Instance.GetAllServices();
			//cboService.DisplayMember = "Name";
			//cboService.ValueMember = "Price";
		}

		private void numWeight_ValueChanged( object sender, EventArgs e )
		{
			CalculatePrice();
		}

		private void cboService_SelectedIndexChanged( object sender, EventArgs e )
		{
			CalculatePrice();
		}

		public void CalculatePrice()
		{
			orderWeight = Convert.ToSingle(numWeight.Value);
			servicePrice = Convert.ToInt64(cboService.SelectedValue);
			lblPrice.Text = (orderWeight * servicePrice).ToString() + " VND";
		}

		private void gridService_SelectionChanged( object sender, EventArgs e )
		{
			//foreach (DataGridViewRow item in gridService.SelectedRows)
			//{
			//	cboService.SelectedText = item.Cells[0].Value.ToString();
			//	MessageBox.Show(item.Cells[0].Value.ToString());
			//}
		}
	}
}
