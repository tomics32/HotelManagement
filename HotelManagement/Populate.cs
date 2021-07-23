using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace HotelManagement
{
	class Populate : Decorator
	{
		public override void Operation(DataGridView grid, string query)
		{
		

			SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tomi\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");
			Con.Open();
			string Myquery = query;
			SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
			SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
			var ds = new DataSet();
			da.Fill(ds);
			grid.DataSource = ds.Tables[0];

			for (int i = 0; i < grid.Columns.Count - 1; i++)
			{
				grid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			}
			grid.Columns[grid.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			for (int i = 0; i < grid.Columns.Count; i++)
			{
				int colw = grid.Columns[i].Width;
				grid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
				grid.Columns[i].Width = colw;
			}
			Con.Close();
		}
	}
}
