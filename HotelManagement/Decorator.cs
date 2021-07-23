using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace HotelManagement
{
	public abstract class Decorator
	{
	
        public abstract void Operation(DataGridView grid, string query);
	
}
}
