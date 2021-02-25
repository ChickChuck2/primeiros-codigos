using System;
using System.Windows.Forms;
using System.Drawing;

namespace Class3
{

	class wForm : Form
	{
		public wForm()
		{
			try
			{
				this.Text = "titulo";
				this.BackColor = Color.FromRgb(0xFFFFFF);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
			}
		}
	}

	public class teste
	{
		public static void Main(String[] args)
		{
			wForm w = new wForm();
			Application.Run(w);
		}
	}
}