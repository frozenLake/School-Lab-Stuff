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
	public partial class Form2 : Form
	{
		SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;");
		// TABLE IS STORED IN "(localdb)\MSSQLLocalDB\Databases\System Databases\master\Tables\" in SQL Server Object Explorer

		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dataSet2.StudentDetails' table. You can move, or remove it, as needed.
			this.studentDetailsTableAdapter.Fill(this.dataSet2.StudentDetails);
			// TODO: This line of code loads data into the 'authenticateDataSet.ProfDetails' table.
			// You can move, or remove it, as needed.
			// this.profDetailsTableAdapter.Fill(this.authenticateDataSet.ProfDetails);

			if (Global.loggedIn)
			{
				btn_insert.Enabled = true;
				btn_update.Enabled = true;
				btn_delete.Enabled = true;
				btn_cancel.Enabled = true;
				btn_Login.Visible = false;
				btnLogout.Visible = true;
			}
			else
			{
				btn_insert.Enabled = false;
				btn_update.Enabled = false;
				btn_delete.Enabled = false;
				btn_cancel.Enabled = false;
				btn_Login.Visible = true;
				btnLogout.Visible = false;
			}
		}

		public void display_data()
		{
			conn.Open();
			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select * from [StudentDetails]";
			cmd.ExecuteNonQuery();
			DataTable dta = new DataTable();
			SqlDataAdapter sda = new SqlDataAdapter(cmd);
			sda.Fill(dta);
			dataGrid_DispRec.DataSource = dta;
			conn.Close();
		}

		private void btn_insert_Click(object sender, EventArgs e)
		{
			conn.Open();

			SqlCommand sqcmd = new SqlCommand("Select * from [StudentDetails] where Id='" + txt_regID.Text + "'", conn);
			SqlDataAdapter da = new SqlDataAdapter(sqcmd);
			DataTable dt = new DataTable();
			da.Fill(dt);

			if (dt.Rows.Count > 0)
			{
				conn.Close();
				MessageBox.Show("Reg ID already exists");
			}
			else
			{
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "insert into [StudentDetails] (Id, Name, Course, Department, Email) values ('" +
					txt_regID.Text + "','" + txt_name.Text + "','" +
					txt_course.Text + "','" + txt_department.Text + "','" + txt_email.Text + "')";
				cmd.ExecuteNonQuery();
				conn.Close();
				txt_regID.Text = "";
				txt_name.Text = "";
				txt_course.Text = "";
				txt_department.Text = "";
				txt_email.Text = "";
				display_data();
				MessageBox.Show("Data inserted successfully");
			}
		}

		private void dataGrid_DispRec_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int myIndex = e.RowIndex;
			DataGridViewRow row = dataGrid_DispRec.Rows[myIndex];

			string reg = row.Cells[0].Value.ToString();
			string value1 = row.Cells[1].Value.ToString();
			string value2 = row.Cells[2].Value.ToString();
			string value3 = row.Cells[3].Value.ToString();
			string value4 = row.Cells[4].Value.ToString();

			txt_regID.Text = reg;
			txt_regID.Enabled = false;

			txt_name.Text = value1;
			txt_course.Text = value2;
			txt_department.Text = value3;
			txt_email.Text = value4;



			if (Global.loggedIn)
			{
				btn_insert.Enabled = false;
				btn_update.Enabled = true;
				btn_delete.Enabled = true;

			}
			else
			{
				btn_insert.Enabled = false;
				btn_update.Enabled = false;
				btn_delete.Enabled = false;
			}

		}

		private void btn_update_Click(object sender, EventArgs e)
		{
			conn.Open();
			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "update [StudentDetails] set Name='" + txt_name.Text +
				"', Course ='" + txt_course.Text +
				"', Department ='" + txt_department.Text +
				"', Email ='" + txt_email.Text +
				"' where Id ='" + txt_regID.Text + "'";
			cmd.ExecuteNonQuery();
			conn.Close();
			display_data();

			txt_regID.Text = "";
			txt_name.Text = "";
			txt_course.Text = "";
			txt_department.Text = "";
			txt_email.Text = "";

			btn_insert.Enabled = true;
			btn_update.Enabled = false;
			btn_delete.Enabled = false;

			txt_regID.Enabled = true;

			MessageBox.Show("Data updated successfully");
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			conn.Open();
			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "delete from [StudentDetails] where Id='" + txt_regID.Text + "'";
			cmd.ExecuteNonQuery();
			conn.Close();
			display_data();

			txt_regID.Text = "";
			txt_name.Text = "";
			txt_course.Text = "";
			txt_department.Text = "";
			txt_email.Text = "";

			btn_insert.Enabled = true;
			btn_update.Enabled = false;
			btn_delete.Enabled = false;

			txt_regID.Enabled = true;

			MessageBox.Show("Data deleted successfully");
		}

		private void btn_search_Click(object sender, EventArgs e)
		{
			conn.Open();
			string search = txt_search.Text;
			SqlCommand sqcmd = new SqlCommand("Select * from [StudentDetails] where Name Like '%"
				+ search + "%' OR Course Like '%" + search +
				"%' OR Department Like '%" + search +
				"%' OR Email Like '%" + search + "%'", conn);
			SqlDataAdapter da = new SqlDataAdapter(sqcmd);
			DataTable dt = new DataTable();
			da.Fill(dt);

			if (dt.Rows.Count > 0)
			{
				dataGrid_DispRec.DataSource = dt;
				conn.Close();
			}
			else
			{
				MessageBox.Show("No record found");
				conn.Close();
			}
		}

		private void btn_displayAll_Click(object sender, EventArgs e)
		{
			display_data();
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			conn.Close();
			display_data();

			txt_regID.Text = "";
			txt_name.Text = "";
			txt_course.Text = "";
			txt_department.Text = "";
			txt_email.Text = "";

			btn_insert.Enabled = true;
			btn_update.Enabled = false;
			btn_delete.Enabled = false;

			txt_regID.Enabled = true;
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			Global.loggedIn = false;
			this.Hide();
			FormLogin log = new FormLogin();
			log.Show();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormLogin log = new FormLogin();
			log.Show();
		}
	}
}
