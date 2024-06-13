/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 13/06/2024
 * Time: 19:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Carros
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox Lista_carros;
		private System.Windows.Forms.RichTextBox Lista_eco;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox richTextBox1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.Lista_carros = new System.Windows.Forms.RichTextBox();
			this.Lista_eco = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// Lista_carros
			// 
			this.Lista_carros.Location = new System.Drawing.Point(50, 51);
			this.Lista_carros.Name = "Lista_carros";
			this.Lista_carros.ReadOnly = true;
			this.Lista_carros.Size = new System.Drawing.Size(313, 382);
			this.Lista_carros.TabIndex = 0;
			this.Lista_carros.Text = "";
			// 
			// Lista_eco
			// 
			this.Lista_eco.Location = new System.Drawing.Point(681, 51);
			this.Lista_eco.Name = "Lista_eco";
			this.Lista_eco.ReadOnly = true;
			this.Lista_eco.Size = new System.Drawing.Size(313, 382);
			this.Lista_eco.TabIndex = 1;
			this.Lista_eco.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(50, 492);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(154, 67);
			this.button1.TabIndex = 2;
			this.button1.Text = "Abrir Resultados";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(431, 492);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(154, 67);
			this.button2.TabIndex = 3;
			this.button2.Text = "Pesquisar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.Location = new System.Drawing.Point(840, 492);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(154, 67);
			this.button3.TabIndex = 4;
			this.button3.Text = "Salvar Mais Econômicos";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(50, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(188, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Lista De Todos Carros";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(681, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(157, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "O Mais Econômico";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(450, 98);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(156, 174);
			this.richTextBox1.TabIndex = 7;
			this.richTextBox1.Text = "";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1038, 585);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Lista_eco);
			this.Controls.Add(this.Lista_carros);
			this.Name = "MainForm";
			this.Text = "Carros";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
