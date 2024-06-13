using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Carros
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			Lista_carros.LoadFile("carros.txt", RichTextBoxStreamType.PlainText);
			button2.Enabled = true;
		}
		void Button2Click(object sender, EventArgs e)
		{
			button3.Enabled = true;
			
			for(int i = 0; i < 15; i++)
			{
				string b = Lista_carros.Lines[i];
				string[] a = b.Split('#');
				
				int media1 = int.Parse(a[1]);
				
				richTextBox1.Text += media1.ToString() + "\n";
			}
			int tristeza = int.Parse(richTextBox1.Lines[0] + richTextBox1.Lines[1] + richTextBox1.Lines[2] + richTextBox1.Lines[3] + richTextBox1.Lines[4] + richTextBox1.Lines[5] + richTextBox1.Lines[6] + richTextBox1.Lines[7] + richTextBox1.Lines[8] + richTextBox1.Lines[9] + richTextBox1.Lines[10] + richTextBox1.Lines[11] + richTextBox1.Lines[12] + richTextBox1.Lines[13] + richTextBox1.Lines[14]);
		}
	}
}
