using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManagement
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void label6_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Form1 login = new Form1();
			login.Show();
			this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			ClientInfo clientInfo = new ClientInfo();
			clientInfo.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			StaffInfo staffInfo = new StaffInfo();
			staffInfo.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			RoomInfo roomInfo = new RoomInfo();
			roomInfo.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ReservationInfo reservationInfo = new ReservationInfo();
			reservationInfo.Show();
			this.Hide();
		}

		
	}
}
