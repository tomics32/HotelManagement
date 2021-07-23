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
	public partial class RoomInfo : Form
	{
		Populate pop = new Populate();
		SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tomi\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");
		public void populate()
		{
			DataGridView grid = RoomGridView;
			string query = "select RoomId as ID_Pokoju, RoomPhone as Numer_telefonu, RoomFree as Dostep from Room_tbl";
			pop.Operation(grid, query);
		}
		public RoomInfo()
		{
			InitializeComponent();
		}



		private void RoomInfo_Load_1(object sender, EventArgs e)
		{
			Datelbl.Text = DateTime.Now.ToLongTimeString();

			timer1.Start();
			populate();

		}

		private void timer1_Tick_1(object sender, EventArgs e)
		{
			Datelbl.Text = DateTime.Now.ToLongTimeString();
		}


		private void label1_Click(object sender, EventArgs e)
		{

		}

		public void AddBtn_Click(object sender, EventArgs e)
		{
			string isFree;
			if (yesradio.Checked == true)
			{
				isFree = "Wolny";
			}
			else
			{
				isFree = "Zajety";
			}
			Con.Open();
			SqlCommand cmd = new SqlCommand("insert into Room_tbl values(" + roomidtbl.Text + ",'" + roomphonetbl.Text + "','" + isFree + "')", Con);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Pomyślnie dodano pokój");
			Con.Close();
			populate();
		}

		private void roomidtbl_TextChanged(object sender, EventArgs e)
		{

		}


		private void DeleteBtn_Click(object sender, EventArgs e)
		{
			Con.Open();
			string query = "delete from Room_tbl where  RoomId = " + roomidtbl.Text + "";
			SqlCommand cmd = new SqlCommand(query, Con);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Room Successfully Deleted");
			Con.Close();
			populate();
		}

		private void EditBtn_Click(object sender, EventArgs e)
		{
			string isFree;
			if (yesradio.Checked == true)
			{
				isFree = "Wolny";
			}
			else
			{
				isFree = "Zajety";
			}
			Con.Open();
			string myquery = "UPDATE Room_tbl set RoomPhone = '" + roomphonetbl.Text + "',RoomFree = '" +  isFree + "' where RoomId = " + roomidtbl.Text + ";";
			SqlCommand cmd = new SqlCommand(myquery, Con);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Pomyślnie edytowano pokój");
			Con.Close();
			populate();
		}

		private void RoomGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			roomidtbl.Text = RoomGridView.SelectedRows[0].Cells[0].Value.ToString();
			roomphonetbl.Text = RoomGridView.SelectedRows[0].Cells[1].Value.ToString();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Con.Open();
			string Myquery = "select * from Room_tbl where RoomId = '" + RoomSearchTbl.Text + "' ";
			SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
			SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
			var ds = new DataSet();
			da.Fill(ds);
			RoomGridView.DataSource = ds.Tables[0];

			for (int i = 0; i < RoomGridView.Columns.Count - 1; i++)
			{
				RoomGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			}
			RoomGridView.Columns[RoomGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			for (int i = 0; i < RoomGridView.Columns.Count; i++)
			{
				int colw = RoomGridView.Columns[i].Width;
				RoomGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
				RoomGridView.Columns[i].Width = colw;
			}
			Con.Close();
		}

		private void ResetTbl_Click(object sender, EventArgs e)
		{
			populate();
		}

		private void RoomSearchTbl_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void RoomSearchTbl_Click(object sender, EventArgs e)
		{
			if (RoomSearchTbl.Text == "Szukaj pokoju")
			{ 
			RoomSearchTbl.Clear();
			}
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
	}
}
