using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemGiatUi
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		private void btnExit_Click( object sender, EventArgs e )
		{
			this.Close();
		}

		private void btnLogin_Click( object sender, EventArgs e )
		{
			if (txtUser.Text == "" && txtPass.Text == "")
			{
				this.Hide();
				new frmMain().ShowDialog();
				this.Close();
			}
			else
			{
				MessageBox.Show("Sai tài khoản hoặc mật khẩu !");
				txtUser.Focus();
				txtUser.SelectAll();
				txtPass.ResetText();
			}
		}
	}
}
