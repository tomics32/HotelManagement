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
	public partial class ClientInfo : Form
	{
		Populate pop = new Populate();
		SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tomi\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");
		public void populate()
		{
			DataGridView grid = ClientGridView;
			string query = "select ClientId as ID_Klienta, ClientName as Imie, ClientPhone as Numer_telefonu, ClientCountry as Kraj from Client_tbl";
			pop.Operation(grid, query);
		}

		public ClientInfo()
		{
			InitializeComponent();
		}


		private void ClientInfo_Load(object sender, EventArgs e)
		{
			Datelbl.Text = DateTime.Now.ToLongTimeString();
			
			timer1.Start();
			populate();
		}

		private void timer1_Tick_1(object sender, EventArgs e)
		{
			Datelbl.Text = DateTime.Now.ToLongTimeString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Con.Open();
			SqlCommand cmd = new SqlCommand("insert into Client_tbl values("+clientidtbl.Text+",'"+clientnametbl.Text+"','"+clientphonetbl.Text+"','"+clientcountrytbl.SelectedItem.ToString()+"')", Con);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Pomyślnie dodano klienta");
			Con.Close();
			populate();
		}

		private void ClientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			clientidtbl.Text = ClientGridView.SelectedRows[0].Cells[0].Value.ToString();
			clientnametbl.Text = ClientGridView.SelectedRows[0].Cells[1].Value.ToString();
			clientphonetbl.Text = ClientGridView.SelectedRows[0].Cells[2].Value.ToString();
		}

		private void EditBtn_Click(object sender, EventArgs e)
		{
			Con.Open();
			string myquery = "UPDATE Client_tbl set ClientName = '" + clientnametbl.Text + "',ClientPhone = '" + clientphonetbl.Text + "',ClientCountry = '" + clientcountrytbl.SelectedItem.ToString() + "' where ClientId = "+clientidtbl.Text+";";
			SqlCommand cmd = new SqlCommand(myquery, Con);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Pomyślnie edytowano klienta");
			Con.Close();
			populate();
		}

		private void DeleteBtn_Click(object sender, EventArgs e)
		{
			Con.Open();
			string query = "delete from Client_tbl where  ClientId = "+clientidtbl.Text+"";
			SqlCommand cmd = new SqlCommand(query, Con);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Client Successfully Deleted");
			Con.Close();
			populate();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			
			Con.Open();
			string Myquery = "select * from Client_tbl where ClientName = '" + ClientSearchTbl.Text + "' ";
			SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
			SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
			var ds = new DataSet();
			da.Fill(ds);
			ClientGridView.DataSource = ds.Tables[0];

			for (int i = 0; i < ClientGridView.Columns.Count - 1; i++)
			{
				ClientGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			}
			ClientGridView.Columns[ClientGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			for (int i = 0; i < ClientGridView.Columns.Count; i++)
			{
				int colw = ClientGridView.Columns[i].Width;
				ClientGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
				ClientGridView.Columns[i].Width = colw;
			}
			Con.Close();

		}

		private void ResetTbl_Click(object sender, EventArgs e)
		{
			populate();
		}

		private void ClientSearchTbl_TextChanged(object sender, EventArgs e)
		{

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

		private void clientidtbl_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
