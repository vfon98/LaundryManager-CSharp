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
	public partial class OrderForm : Form
	{
		private int orderID;
		public OrderForm()
		{
			InitializeComponent();
		}

		private void OrderForm_Load( object sender, EventArgs e )
		{
			// TODO: This line of code loads data into the 'quanLyGiatUiDataSet2.Orders' table. You can move, or remove it, as needed.
			this.ordersTableAdapter.Fill(this.quanLyGiatUiDataSet2.Orders);
		}

		private void btnExit_Click( object sender, EventArgs e )
		{
			//this.Close();
		}

		private void btnDelOrder_Click( object sender, EventArgs e )
		{
			DataProvider.Instance.DeleteOrder(orderID);
			this.ordersTableAdapter.Fill(this.quanLyGiatUiDataSet2.Orders);
		}

		private void gridOrderList_SelectionChanged( object sender, EventArgs e )
		{
			foreach (DataGridViewRow item in gridOrderList.SelectedRows)
			{
				orderID = Convert.ToInt32(item.Cells[0].Value);
			}
		}
	}
}
