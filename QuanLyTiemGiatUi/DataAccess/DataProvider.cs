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
		
		public int ExercuteNonQuery(String sql)
		{
			using (SqlConnection conn = new SqlConnection(conectionString))
			{
				conn.Open();
				cmd = new SqlCommand(sql, conn);
				return cmd.ExecuteNonQuery();
			}
		}
		public DataTable GetAllServices()
		{
			DataTable dtService = new DataTable();
			dtService = ExercuteQuery("SELECT * FROM Services");
			return dtService;
		}
		public void InsertService(string name, decimal price)
		{
			string sql = "INSERT INTO Services VALUES (N'" + name + "', " + price + ")";
			ExercuteQuery(sql);
		}
		public void UpdateService(int id, string name, decimal price)
		{
			string sql = "UPDATE Services SET Name = N'"+ name +"', Price ="+ price +" WHERE STT = " + id;
			ExercuteNonQuery(sql);
		}
		public void DeleteService(int id)
		{
			string sql = "DELETE FROM Services WHERE STT = " + id.ToString();
			ExercuteNonQuery(sql);
		}
	}
}
