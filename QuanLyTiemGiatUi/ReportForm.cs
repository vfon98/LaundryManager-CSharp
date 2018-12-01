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
	public partial class ReportForm : Form
	{
		private decimal totalRevenue = 0m;

		public ReportForm()
		{
			InitializeComponent();
		}

		private void ReportForm_Load( object sender, EventArgs e )
		{
			// TODO: This line of code loads data into the 'quanLyGiatUiDataSet21.PaidOrder' table. You can move, or remove it, as needed.
			this.paidOrderTableAdapter.Fill(this.quanLyGiatUiDataSet21.PaidOrder);
			// TODO: This line of code loads data into the 'quanLyGiatUiDataSet2.GetDay' table. You can move, or remove it, as needed.
			this.getDayTableAdapter.Fill(this.quanLyGiatUiDataSet2.GetDay);
			// TODO: This line of code loads data into the 'quanLyGiatUiDataSet2.GetMonth' table. You can move, or remove it, as needed.
			this.getMonthTableAdapter.Fill(this.quanLyGiatUiDataSet2.GetMonth);
			// TODO: This line of code loads data into the 'quanLyGiatUiDataSet2.GetYear' table. You can move, or remove it, as needed.
			this.getYearTableAdapter.Fill(this.quanLyGiatUiDataSet2.GetYear);
			// TODO: This line of code loads data into the 'quanLyGiatUiDataSet2.Orders' table. You can move, or remove it, as needed.
			this.ordersTableAdapter.Fill(this.quanLyGiatUiDataSet2.Orders);


			CalculateRevenue();
		}

		private void btnExit_Click( object sender, EventArgs e )
		{
			this.Close();
		}

		private void btnPrint_Click( object sender, EventArgs e )
		{
			MessageBox.Show("In thành công !", "Thông báo");
		}

		#region Combobox Event

		private void cboDay_SelectedIndexChanged( object sender, EventArgs e )
		{
			gridReport.DataSource = DataProvider.Instance.GetOrderByDay(cboDay.Text, cboMonth.Text, cboYear.Text);

		}

		private void cboMonth_SelectedIndexChanged( object sender, EventArgs e )
		{
			gridReport.DataSource = DataProvider.Instance.GetOrderByMonth(cboMonth.Text, cboYear.Text);
		}

		private void cboYear_SelectedIndexChanged( object sender, EventArgs e )
		{
			gridReport.DataSource = DataProvider.Instance.GetOrderByYear(cboYear.Text);
		}

		#endregion

		#region RadioButton Event

		private void radYear_CheckedChanged( object sender, EventArgs e )
		{
			cboMonth.Enabled = false;
			cboDay.Enabled = false;
			gridReport.DataSource = DataProvider.Instance.GetOrderByYear(cboYear.Text);
		}

		private void radMonth_CheckedChanged( object sender, EventArgs e )
		{
			cboMonth.Enabled = true;
			cboDay.Enabled = false;
			gridReport.DataSource = DataProvider.Instance.GetOrderByMonth(cboMonth.Text, cboYear.Text);
		}

		private void radDay_CheckedChanged( object sender, EventArgs e )
		{
			cboDay.Enabled = true;
			cboMonth.Enabled = true;
			gridReport.DataSource = DataProvider.Instance.GetOrderByDay(cboDay.Text, cboMonth.Text, cboYear.Text);
		}

		#endregion

		private void CalculateRevenue()
		{
			foreach (DataGridViewRow item in gridReport.Rows)
			{
				totalRevenue += Convert.ToDecimal(item.Cells[2].Value);
			}
			txtRevenue.Text = totalRevenue.ToString("N0") + " VND";
		}

		private void gridReport_DataSourceChanged( object sender, EventArgs e )
		{
			totalRevenue = 0;
			CalculateRevenue();
		}
	}
}
