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
			button1.Enabled = false;
		}
		void Button2Click(object sender, EventArgs e)
		{
			//Separação do valor para o label
			
			button3.Enabled = true;
			
			float valorm = 0;
			
			for(int i = 0; i < 15; i++)
			{		
				
			string b = Lista_carros.Lines[i];
			string[] a = b.Split('#');
				
				int media1 = int.Parse(a[1]);
				
				valorm += media1;
			}
			float x = valorm /15;
			//separando os acima da média paa o richtextbox da direita.
			
			label3.Text = "Média: " + x.ToString();
			
			string decisao = label3.Text;
			//-------------------------------------------------------//
			for(int i = 0; i < 15; i++){
				
				
			string b = Lista_carros.Lines[i];
			string[] a = b.Split('#');
			
			int c = int.Parse(a[1]);
			
			if(c > 260){
				Lista_eco.Text += a[0] + "\n";
			}
		}
			button2.Enabled = false;
	}
		
		void Button3Click(object sender, EventArgs e)
		{
				DialogResult r = MessageBox.Show("Deseja salvar o arquivo?", "Salvar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

				if(r == DialogResult.OK) {
				Lista_eco.SaveFile("melhores.txt", RichTextBoxStreamType.PlainText);
				MessageBox.Show("Arquivo salvo com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} 
			else if(r == DialogResult.Cancel) { }
		}
}
}
