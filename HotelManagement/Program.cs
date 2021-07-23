using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HotelManagement
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			bool instanceCountOne = false;

			using(Mutex mtex = new Mutex(true, "MyRunningApp", out instanceCountOne))
			{
				if (instanceCountOne == true)
				{
					Application.SetHighDpiMode(HighDpiMode.SystemAware);
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run(new Form1());
					mtex.ReleaseMutex();
				}
				else
				{
					MessageBox.Show("Program jest juz uruchomiony");
				}
			}

			

		}
	}
}
