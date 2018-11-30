using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemGiatUi.DataAccess
{
	class DataProvider
	{
		private static DataProvider instance;
		private SqlDataAdapter adapter;
		SqlCommand cmd;
		private readonly string conectionString = @"Server=.\SQLEXPRESS;Database=QuanLyGiatUi;Integrated Security=True";

		public static DataProvider Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new DataProvider();
				}
				return instance;
			}
		}

		private DataProvider() { }

		public DataTable ExercuteQuery( String sql )
		{
			using (SqlConnection conn = new SqlConnection(conectionString))
			{
				conn.Open();
				cmd = new SqlCommand(sql, conn);
				adapter = new SqlDataAdapter(cmd);
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);
				conn.Close();
				return dataTable;
			}
		}

		public void ExercuteNonQuery( String sql )
		{
			using (SqlConnection conn = new SqlConnection(conectionString))
			{
				conn.Open();
				cmd = new SqlCommand(sql, conn);
				cmd.ExecuteNonQuery();
				conn.Close();
			}
		}

		#region ServiceManagement

		public DataTable GetAllServices()
		{
			DataTable dtService = new DataTable();
			dtService = ExercuteQuery("SELECT * FROM Services");
			return dtService;
		}

		public void InsertService( string name, decimal price )
		{
			string sql = "INSERT INTO Services VALUES (N'" + name + "', " + price + ")";
			System.Windows.Forms.MessageBox.Show(sql);
			ExercuteNonQuery(sql);
		}

		public void UpdateService( int id, string name, decimal price )
		{
			string sql = "UPDATE Services SET Name = N'" + name + "', Price = " + price + " WHERE STT = " + id;
			ExercuteNonQuery(sql);
		}

		public void DeleteService( int id )
		{
			string sql = "DELETE FROM Services WHERE STT = " + id.ToString();
			ExercuteNonQuery(sql);
		}

		#endregion

		#region OrderManagement

		public void InsertOrder( string cusName, string phone, string address, string orderName, string service, float weight, int delivery, decimal price )
		{
			string sql = "INSERT INTO Orders (CustomerName, Phone, Address, OrderName, Service, Weight, Delivery, Price, Status)" +
				"VALUES (N'" + cusName + "', '" + phone + "', N'" + address + "', N'" + orderName + "', N'" + service + "', " +
				weight + ", " + delivery + ", " + price + ", N'Chờ giặt')";
			ExercuteNonQuery(sql);
		}

		public void DeleteOrder( int id )
		{
			string sql = "DELETE FROM Orders WHERE ID = " + id;
			ExercuteNonQuery(sql);
		}

		public void AcceptOrder( int id )
		{
			string sql = "UPDATE Orders SET Status = N'Chưa thanh toán' WHERE ID = " + id;
			ExercuteNonQuery(sql);
		}

		public void SetPaidOrder( int id )
		{
			string sql = "UPDATE Orders SET Status = N'Đã thanh toán' WHERE ID = " + id;
			ExercuteNonQuery(sql);
		}

		#endregion

		#region StaffManagement

		public void InsertStaff( string name, string address, string phone, string position )
		{
			string sql = "INSERT INTO Staff VALUES (N'" + name + "', N'" + address + "', N'" + phone + "', N'" + position + "')";
			ExercuteNonQuery(sql);
		}

		public void UpdateStaff( int id, string name, string address, string phone, string position )
		{
			string sql = "UPDATE Staff SET Name=N'" + name + "', Address=N'" + address + "', Phone=N'" + phone + "', Position=N'" + position + "' WHERE ID=" + id;
			ExercuteNonQuery(sql);
		}

		public void DeleteStaff( int id )
		{
			string sql = "DELETE FROM Staff WHERE ID = " + id;
			ExercuteNonQuery(sql);
		}

		#endregion
	}
}
