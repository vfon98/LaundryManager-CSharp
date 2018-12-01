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
	public partial class ServiceForm : Form
	{
		DataTable dtService;
		int selectedID = 1;
		public ServiceForm()
		{
			InitializeComponent();
		}

		private void ServiceForm_Load( object sender, EventArgs e )
		{
			// TODO: This line of code loads data into the 'quanLyGiatUiDataSet1.Services' table. You can move, or remove it, as needed.
			this.servicesTableAdapter.Fill(this.quanLyGiatUiDataSet1.Services);
			dtService = DataProvider.Instance.GetAllServices();
			gridServices.DataSource = dtService;
			txtSerName.DataBindings.Add("Text", dtService, "Name");
			numSerPrice.DataBindings.Add("Value", dtService, "Price");
		}

		private void ResetField()
		{
			txtSerName.ResetText();
			numSerPrice.Value = 0;
		}

		private void gridServices_CellClick( object sender, DataGridViewCellEventArgs e )
		{
			btnDelSer.Enabled = true;
		}

		private void gridServices_SelectionChanged( object sender, EventArgs e )
		{
			foreach (DataGridViewRow item in gridServices.SelectedRows)
			{
				selectedID = Convert.ToInt32(item.Cells[0].Value);
				txtSerName.Text = item.Cells[1].Value.ToString();
				numSerPrice.Value = Convert.ToDecimal(item.Cells[2].Value);
			}
		}

		private void btnAddSer_Click( object sender, EventArgs e )
		{
			if (txtSerName.Text != "" && numSerPrice.Value != 0)
			{
				DataProvider.Instance.InsertService(txtSerName.Text, numSerPrice.Value);
				dtService = DataProvider.Instance.GetAllServices();
				gridServices.DataSource = dtService;
				ResetField();
				MessageBox.Show("Thêm dịch vụ thành công !", "Thông báo");
			}
			else
			{
				MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnModifySer_Click( object sender, EventArgs e )
		{
			DataProvider.Instance.UpdateService(selectedID, txtSerName.Text, numSerPrice.Value);
			dtService = DataProvider.Instance.GetAllServices();
			gridServices.DataSource = dtService;
			ResetField();
			MessageBox.Show("Chỉnh sửa dịch vụ thành công !", "Thông báo");
		}

		private void btnDelSer_Click( object sender, EventArgs e )
		{
			DataProvider.Instance.DeleteService(selectedID);
			dtService = DataProvider.Instance.GetAllServices();
			gridServices.DataSource = dtService;
			ResetField();
			MessageBox.Show("Xóa dịch vụ thành công !", "Thông báo");
		}

	}
}
