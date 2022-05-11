using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Homework_06
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;");
			con.Open();

			SqlCommand sqcmd = new SqlCommand("Select * from Login where username='" + textBoxUsername.Text + "' and password='" + textBoxPassword.Text + "'", con);

			SqlDataAdapter da = new SqlDataAdapter(sqcmd);

			DataTable dt = new DataTable();
			da.Fill(dt);

			if (dt.Rows.Count > 0)
			{
				Global.loggedIn = true;
				this.Close();
				Form2 wel = new Form2();
				wel.Show();
			}

			else
			{
				MessageBox.Show("Please check your username and password.");
			}

			con.Close();
		}

		private void FormLogin_Load(object sender, EventArgs e)
		{
			labelError.Text = "";
		}
	}
}
