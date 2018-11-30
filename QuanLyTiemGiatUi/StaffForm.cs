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
	public partial class StaffForm : Form
	{
		private int staffID;
		public StaffForm()
		{
			InitializeComponent();
		}

		private void StaffForm_Load( object sender, EventArgs e )
		{
			// TODO: This line of code loads data into the 'quanLyGiatUiDataSet.Staff' table. You can move, or remove it, as needed.
			this.staffTableAdapter.Fill(this.quanLyGiatUiDataSet.Staff);
			cboFunction.SelectedIndex = 0;
		}

		private void txtPhoneNum_KeyPress( object sender, KeyPressEventArgs e )
		{
			var key = e.KeyChar;
			if (!"0123456789\b\0177".Contains(key))
			{
				e.Handled = true;
			}
		}

		private void btnAddStaff_Click( object sender, EventArgs e )
		{
			if (txtStaffName.Text == "" || txtAddress.Text == "" || txtPhoneNum.Text == "")
			{
				MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				DataProvider.Instance.InsertStaff(txtStaffName.Text, txtAddress.Text, txtPhoneNum.Text, cboFunction.Text);
				this.staffTableAdapter.Fill(this.quanLyGiatUiDataSet.Staff);
				ResetFields();
			}
		}

		private void btnModifyStaff_Click( object sender, EventArgs e )
		{
			DataProvider.Instance.UpdateStaff(staffID, txtStaffName.Text, txtAddress.Text, txtPhoneNum.Text, cboFunction.Text);
			this.staffTableAdapter.Fill(this.quanLyGiatUiDataSet.Staff);
		}

		private void btnDeleteStaff_Click( object sender, EventArgs e )
		{
			DataProvider.Instance.DeleteStaff(staffID);
			this.staffTableAdapter.Fill(this.quanLyGiatUiDataSet.Staff);
		}

		private void ResetFields()
		{
			txtStaffName.ResetText();
			txtAddress.ResetText();
			txtPhoneNum.ResetText();
		}

		private void gridStaff_SelectionChanged( object sender, EventArgs e )
		{
			foreach (DataGridViewRow item in gridStaff.SelectedRows)
			{
				staffID = Convert.ToInt32(item.Cells[0].Value);
				txtStaffName.Text = item.Cells[1].Value.ToString();
				txtAddress.Text = item.Cells[2].Value.ToString();
				txtPhoneNum.Text = item.Cells[3].Value.ToString();
				cboFunction.Text = item.Cells[4].Value.ToString();
			}
		}


	}
}
