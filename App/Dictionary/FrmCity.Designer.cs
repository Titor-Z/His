namespace App.Dictionary {
	partial class FrmCity {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.cmbCity = new CCWin.SkinControl.SkinComboBox();
			this.lstCity = new System.Windows.Forms.ListBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cmbCity
			// 
			this.cmbCity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbCity.FormattingEnabled = true;
			this.cmbCity.Location = new System.Drawing.Point(30, 58);
			this.cmbCity.Name = "cmbCity";
			this.cmbCity.Size = new System.Drawing.Size(240, 22);
			this.cmbCity.TabIndex = 0;
			this.cmbCity.WaterText = "";
			this.cmbCity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbCity_KeyUp);
			// 
			// lstCity
			// 
			this.lstCity.FormattingEnabled = true;
			this.lstCity.ItemHeight = 12;
			this.lstCity.Location = new System.Drawing.Point(30, 80);
			this.lstCity.Name = "lstCity";
			this.lstCity.Size = new System.Drawing.Size(240, 148);
			this.lstCity.TabIndex = 1;
			this.lstCity.Visible = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(385, 99);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(323, 21);
			this.textBox1.TabIndex = 4;
			// 
			// FrmCity
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(990, 569);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lstCity);
			this.Controls.Add(this.cmbCity);
			this.Name = "FrmCity";
			this.Text = "FrmCity";
			this.Load += new System.EventHandler(this.FrmCity_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CCWin.SkinControl.SkinComboBox cmbCity;
		private System.Windows.Forms.ListBox lstCity;
		private System.Windows.Forms.TextBox textBox1;
	}
}