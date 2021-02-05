/*
 * Created by SharpDevelop.
 * User: Sela Smith
 * Date: 26/01/2021
 * Time: 14:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Fevereiro_2021
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label fechar;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.fechar = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// fechar
			// 
			this.fechar.BackColor = System.Drawing.Color.Transparent;
			this.fechar.Font = new System.Drawing.Font("Harrington", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fechar.ForeColor = System.Drawing.Color.DarkRed;
			this.fechar.Location = new System.Drawing.Point(574, 236);
			this.fechar.Name = "fechar";
			this.fechar.Size = new System.Drawing.Size(28, 24);
			this.fechar.TabIndex = 1;
			this.fechar.Click += new System.EventHandler(this.FecharClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(607, 260);
			this.Controls.Add(this.fechar);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fevereiro-2021";
			this.Click += new System.EventHandler(this.MainFormClick);
			this.ResumeLayout(false);

		}
	}
}
