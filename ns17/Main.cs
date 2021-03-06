using ns15;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace ns17
{
	public static class Start
	{
		[STAThread]
		private static void Main(string[] args)
		{
			bool flag;
			Mutex obj = new Mutex(true, "GHTCP", out flag);
			if (!flag)
			{
				MessageBox.Show("GH3 Control Panel+ is already running.");
				return;
			}
			Thread.CurrentThread.CurrentUICulture = (Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US"));
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ns15.MainMenu());
			GC.KeepAlive(obj);
		}
	}
}
