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
	public partial class ReservationInfo : Form
	{
		SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tomi\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");
		Populate pop = new Populate();
		public void populate()
		{
			DataGridView grid = ReservationGridView;
			string query = "select ResId as ID_Rez, Client as Klient, Room as Pokoj, DateIn as Od, DateOut as Do from Reservation_tbl";
			pop.Operation(grid, query);
		}
		public ReservationInfo()
		{
			InitializeComponent();
		}

		DateTime today;
		public void FillRoomCombo()
		{
			Con.Open();
			SqlCommand cmd = new SqlCommand("select RoomId from Room_tbl", Con);
			SqlDataReader rdr;
			rdr = cmd.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Columns.Add("RoomId", typeof(int));
			dt.Load(rdr);
			roomidtbl.ValueMember = "RoomId";
			roomidtbl.DataSource = dt;
			Con.Close();
		}

		public void FillClientCombo()
		{
			Con.Open();
			SqlCommand cmd = new SqlCommand("select ClientName from Client_tbl", Con);
			SqlDataReader rdr;
			rdr = cmd.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Columns.Add("ClientName", typeof(string));
			dt.Load(rdr);
			clientnametbl.ValueMember = "ClientName";
			clientnametbl.DataSource = dt;
			Con.Close();
		}
		private void ReservationInfo_Load(object sender, EventArgs e)
		{
			Datelbl.Text = DateTime.Now.ToLongTimeString();
			today = dateinn.Value;
			timer1.Start();
			populate();
			FillRoomCombo();
			FillClientCombo();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Datelbl.Text = DateTime.Now.ToLongTimeString();
		}

		private void dateinn_ValueChanged(object sender, EventArgs e)
		{
			int res = DateTime.Compare(dateinn.Value, today);
			if(res<0)
			{
				MessageBox.Show("Wrong Date for Reservation");
			}
		}

		private void dateout_ValueChanged(object sender, EventArgs e)
		{
			int res = DateTime.Compare(dateout.Value ,dateinn.Value);
			if (res < 0)
			{
				MessageBox.Show("Wrong Dateout, check once more");
			}
		}

		public void updateroomstate()
		{
			
				Con.Open();
				string newstate = "Zajety";
				string myquery = "UPDATE Room_tbl set RoomFree = '" + newstate + "' where RoomId = " + roomidtbl.SelectedValue.ToString() + ";";
				SqlCommand cmd = new SqlCommand(myquery, Con);
				cmd.ExecuteNonQuery();
				// MessageBox.Show("Pomyślnie edytowano rezerwacje");
				Con.Close();
				FillRoomCombo();
			
		}

		public void updateroomstateondelete()
		{
			
				Con.Open();
				string newstate = "Wolny";
				string myquery = "UPDATE Room_tbl set RoomFree = '" + newstate + "' where RoomId = " + roomidtbl.SelectedValue.ToString() + ";";
				SqlCommand cmd = new SqlCommand(myquery, Con);
				cmd.ExecuteNonQuery();
				// MessageBox.Show("Pomyślnie edytowano rezerwacje");
				Con.Close();
				FillRoomCombo();
			
		}
		private void AddBtn_Click(object sender, EventArgs e)
		{
			Con.Open();
			SqlCommand cmd = new SqlCommand("insert into Reservation_tbl values(" + reservationidtdl.Text + ",'" + clientnametbl.SelectedValue.ToString() + "','" + roomidtbl.SelectedValue.ToString() + "','" + dateinn.Value + "','" + dateout.Value + "')", Con);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Pomyślnie dodano rezerwacje");
			Con.Close();
			updateroomstate();
			populate();
			
		}

		private void ReservationGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			reservationidtdl.Text = ReservationGridView.SelectedRows[0].Cells[0].Value.ToString();
			clientnametbl.Text = ReservationGridView.SelectedRows[0].Cells[1].Value.ToString();
			roomidtbl.Text = ReservationGridView.SelectedRows[0].Cells[2].Value.ToString();
			dateinn.Text = ReservationGridView.SelectedRows[0].Cells[3].Value.ToString();
			dateout.Text = ReservationGridView.SelectedRows[0].Cells[4].Value.ToString();

		}

		private void DeleteBtn_Click(object sender, EventArgs e)
		{
			if (reservationidtdl.Text == "")
			{
				MessageBox.Show("Enter the Reservation to be deleted");
			}
			else
			{
				Con.Open();
				string query = "delete from Reservation_tbl where  ResId = " + reservationidtdl.Text + "";
				SqlCommand cmd = new SqlCommand(query, Con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Reservation Successfully Deleted");
				Con.Close();
				updateroomstateondelete();
				populate();
			}
		}

		private void EditBtn_Click(object sender, EventArgs e)
		{
			if(reservationidtdl.Text == "")
			{
				MessageBox.Show("Empty id");
			}
			else
			{ 
			Con.Open();
			string myquery = "UPDATE Reservation_tbl set Client = '" + clientnametbl.SelectedValue.ToString() + "',Room = '" + roomidtbl.SelectedValue.ToString() + "',DateIn = '" + dateinn.Value.ToString() + "',DateOut = '" + dateout.Value.ToString() + "' where ResId = " +reservationidtdl.Text+ ";";
			SqlCommand cmd = new SqlCommand(myquery, Con);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Pomyślnie edytowano rezerwacje");
			Con.Close();
			populate();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			
			Con.Open();
			string Myquery = "select * from Reservation_tbl where ResId = '" + ReservationSearchTbl.Text + "' ";
			SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
			SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
			var ds = new DataSet();
			da.Fill(ds);
			ReservationGridView.DataSource = ds.Tables[0];

			for (int i = 0; i < ReservationGridView.Columns.Count - 1; i++)
			{
				ReservationGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			}
			ReservationGridView.Columns[ReservationGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			for (int i = 0; i < ReservationGridView.Columns.Count; i++)
			{
				int colw = ReservationGridView.Columns[i].Width;
				ReservationGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
				ReservationGridView.Columns[i].Width = colw;
			}
			Con.Close();
		}

		private void ResetTbl_Click(object sender, EventArgs e)
		{
			populate();
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
