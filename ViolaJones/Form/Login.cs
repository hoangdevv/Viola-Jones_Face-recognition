using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Diagnostics;

namespace ViolaJones
{
	public partial class Login : Form
	{
		
		OleDbConnection KoneksiDB = new OleDbConnection(KendaliParameter.urlDatabase);
		OleDbDataAdapter DataAdapter;
		DataTable DataTabel = new DataTable();
		
		public Login()
		{
			InitializeComponent();
		}

		private void BtnBatal_Click(object sender, EventArgs e)
		{
			TxtUname.Text = "";
			Txtpwd.Text = "";
			Application.Exit();
		}

		private void BtnMasuk_Click(object sender, EventArgs e)
		{
			if ((TxtUname.Text != "") && (Txtpwd.Text != ""))
			{

				try
				{
					KoneksiDB.Open();
					DataAdapter = new OleDbDataAdapter("SELECT * from Akun where nama='" + TxtUname.Text + "' and passkode='" + Txtpwd.Text + "'", KoneksiDB);
					OleDbCommandBuilder CommandBuilder = new OleDbCommandBuilder(DataAdapter);
					DataAdapter.Fill(DataTabel);
					if (DataTabel.Rows.Count == 1)
					{
							KendaliParameter.akunAktif = TxtUname.Text;
							Form Utama = new Utama();
							Utama.Show();
							this.Hide();
						
					}
					else
					{
						MessageBox.Show("Tên người dùng và Mật khẩu không hợp lệ...!!!");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				finally
				{
					KoneksiDB.Close();
				}

			}
			else
			{
				MessageBox.Show("Vui lòng nhập thông tin đăng nhập!");
			}
		}


		private void EnterKey(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				BtnMasuk.PerformClick();
			}
			if (e.KeyCode == Keys.Escape)
			{
				BtnBatal.PerformClick();
			}
		}

		private void Login_Load(object sender, EventArgs e)
		{
			if (!KendaliParameter.databaseTidakKosong())
			{
				KoneksiDB.Close();
				Form Utama = new Utama();
				Utama.Show();
				this.Close();
			}
		}
	}
}
