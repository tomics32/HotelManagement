using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelManagement
{
	public partial class StaffInfo : Form
	{
		Populate pop = new Populate();
		SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tomi\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");
		public void populate()
		{
			DataGridView grid = StaffGridView;
			string query = "select StaffId as ID_Pracownika, StaffName as Imie, StaffPhone as Nr_tel, gender as plec, StaffPassword as Haslo from Staff_tbl";
			pop.Operation(grid, query);
		}
		public StaffInfo()
		{
			InitializeComponent();
			populate();
		}

		private void StaffInfo_Load(object sender, EventArgs e)
		{
			Datelbl.Text = DateTime.Now.ToLongTimeString();

			timer1.Start();
			
		}

		private void timer1_Tick_1(object sender, EventArgs e)
		{
			Datelbl.Text = DateTime.Now.ToLongTimeString();
		}

		private void AddBtn_Click(object sender, EventArgs e)
		{
			Con.Open();
			SqlCommand cmd = new SqlCommand("insert into Staff_tbl values(" + staffidtbl.Text + ",'" + staffnametbl.Text + "','" + staffphonetbl.Text + "','" + staffgendertbl.SelectedItem.ToString() + "','" + passwordtbl.Text + "')", Con);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Pomyślnie dodano pracownika");
			Con.Close();
			populate();
		}

		private void DeleteBtn_Click(object sender, EventArgs e)
		{
			Con.Open();
			string query = "delete from Staff_tbl where  StaffId = " + staffidtbl.Text + "";
			SqlCommand cmd = new SqlCommand(query, Con);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Staff Successfully Deleted");
			Con.Close();
			populate();
		}

		private void EditBtn_Click(object sender, EventArgs e)
		{
			Con.Open();
			string myquery = "UPDATE Staff_tbl set StaffName = '" + staffnametbl.Text + "',StaffPhone = '" + staffphonetbl.Text + "',gender = '" + staffgendertbl.SelectedItem.ToString() + "',StaffPassword = '" +passwordtbl.Text+ "' where StaffId = " + staffidtbl.Text + ";";
			SqlCommand cmd = new SqlCommand(myquery, Con);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Pomyślnie edytowano pracownika");
			Con.Close();
			populate();
		}

		private void ResetTbl_Click(object sender, EventArgs e)
		{
			populate();
		}

		private void StaffGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			staffidtbl.Text = StaffGridView.SelectedRows[0].Cells[0].Value.ToString();
			staffnametbl.Text = StaffGridView.SelectedRows[0].Cells[1].Value.ToString();
			staffphonetbl.Text = StaffGridView.SelectedRows[0].Cells[2].Value.ToString();
			staffgendertbl.Text = StaffGridView.SelectedRows[0].Cells[3].Value.ToString();
			passwordtbl.Text = StaffGridView.SelectedRows[0].Cells[4].Value.ToString();

		}

		private void button4_Click(object sender, EventArgs e)
		{
			Con.Open();
			string Myquery = "select * from Staff_tbl where StaffName = '" + StaffSearchTbl.Text + "' ";
			SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
			SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
			var ds = new DataSet();
			da.Fill(ds);
			StaffGridView.DataSource = ds.Tables[0];

			for (int i = 0; i < StaffGridView.Columns.Count - 1; i++)
			{
				StaffGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			}
			StaffGridView.Columns[StaffGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			for (int i = 0; i < StaffGridView.Columns.Count; i++)
			{
				int colw = StaffGridView.Columns[i].Width;
				StaffGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
				StaffGridView.Columns[i].Width = colw;
			}
			Con.Close();
		}

		private void wrocbtn_Click(object sender, EventArgs e)
		{
			MainForm mainForm = new MainForm();
			mainForm.Show();
			this.Hide();
		}

		private void label6_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void staffidtbl_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
