namespace App.Dictionary {
	partial class FrmHospitalEdit {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHospitalEdit));
			this.btnSave = new CCWin.SkinControl.SkinButton();
			this.btnClose = new CCWin.SkinControl.SkinButton();
			this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
			this.chkIsPass = new CCWin.SkinControl.SkinCheckBox();
			this.txtHospitalName = new CCWin.SkinControl.SkinTextBox();
			this.txtHospitalCode = new CCWin.SkinControl.SkinTextBox();
			this.txtSpell = new CCWin.SkinControl.SkinTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.skinGroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Transparent;
			this.btnSave.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.btnSave.DownBack = null;
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(203, 270);
			this.btnSave.MouseBack = null;
			this.btnSave.Name = "btnSave";
			this.btnSave.NormlBack = null;
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "保存(&S)";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Transparent;
			this.btnClose.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.btnClose.DownBack = null;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(122, 270);
			this.btnClose.MouseBack = null;
			this.btnClose.Name = "btnClose";
			this.btnClose.NormlBack = null;
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 12;
			this.btnClose.Text = "关闭(&C)";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// skinGroupBox1
			// 
			this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
			this.skinGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
			this.skinGroupBox1.Controls.Add(this.chkIsPass);
			this.skinGroupBox1.Controls.Add(this.txtHospitalName);
			this.skinGroupBox1.Controls.Add(this.txtHospitalCode);
			this.skinGroupBox1.Controls.Add(this.txtSpell);
			this.skinGroupBox1.Controls.Add(this.label3);
			this.skinGroupBox1.Controls.Add(this.label2);
			this.skinGroupBox1.Controls.Add(this.label1);
			this.skinGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.skinGroupBox1.ForeColor = System.Drawing.Color.Blue;
			this.skinGroupBox1.Location = new System.Drawing.Point(4, 28);
			this.skinGroupBox1.Name = "skinGroupBox1";
			this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
			this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
			this.skinGroupBox1.Size = new System.Drawing.Size(392, 236);
			this.skinGroupBox1.TabIndex = 13;
			this.skinGroupBox1.TabStop = false;
			this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.Red;
			this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.White;
			this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
			// 
			// chkIsPass
			// 
			this.chkIsPass.AutoSize = true;
			this.chkIsPass.BackColor = System.Drawing.Color.Transparent;
			this.chkIsPass.Checked = true;
			this.chkIsPass.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkIsPass.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.chkIsPass.DownBack = null;
			this.chkIsPass.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.chkIsPass.Location = new System.Drawing.Point(130, 172);
			this.chkIsPass.MouseBack = null;
			this.chkIsPass.Name = "chkIsPass";
			this.chkIsPass.NormlBack = null;
			this.chkIsPass.SelectedDownBack = null;
			this.chkIsPass.SelectedMouseBack = null;
			this.chkIsPass.SelectedNormlBack = null;
			this.chkIsPass.Size = new System.Drawing.Size(51, 21);
			this.chkIsPass.TabIndex = 16;
			this.chkIsPass.Text = "启用";
			this.chkIsPass.UseVisualStyleBackColor = false;
			// 
			// txtHospitalName
			// 
			this.txtHospitalName.BackColor = System.Drawing.Color.Transparent;
			this.txtHospitalName.DownBack = null;
			this.txtHospitalName.Icon = null;
			this.txtHospitalName.IconIsButton = false;
			this.txtHospitalName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
			this.txtHospitalName.IsPasswordChat = '\0';
			this.txtHospitalName.IsSystemPasswordChar = false;
			this.txtHospitalName.Lines = new string[0];
			this.txtHospitalName.Location = new System.Drawing.Point(130, 86);
			this.txtHospitalName.Margin = new System.Windows.Forms.Padding(0);
			this.txtHospitalName.MaxLength = 32767;
			this.txtHospitalName.MinimumSize = new System.Drawing.Size(28, 28);
			this.txtHospitalName.MouseBack = null;
			this.txtHospitalName.MouseState = CCWin.SkinClass.ControlState.Normal;
			this.txtHospitalName.Multiline = false;
			this.txtHospitalName.Name = "txtHospitalName";
			this.txtHospitalName.NormlBack = null;
			this.txtHospitalName.Padding = new System.Windows.Forms.Padding(5);
			this.txtHospitalName.ReadOnly = false;
			this.txtHospitalName.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtHospitalName.Size = new System.Drawing.Size(200, 28);
			// 
			// 
			// 
			this.txtHospitalName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtHospitalName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtHospitalName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
			this.txtHospitalName.SkinTxt.Location = new System.Drawing.Point(5, 5);
			this.txtHospitalName.SkinTxt.Name = "BaseText";
			this.txtHospitalName.SkinTxt.Size = new System.Drawing.Size(190, 18);
			this.txtHospitalName.SkinTxt.TabIndex = 0;
			this.txtHospitalName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.txtHospitalName.SkinTxt.WaterText = "";
			this.txtHospitalName.TabIndex = 10;
			this.txtHospitalName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtHospitalName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.txtHospitalName.WaterText = "";
			this.txtHospitalName.WordWrap = true;
			// 
			// txtHospitalCode
			// 
			this.txtHospitalCode.BackColor = System.Drawing.Color.Transparent;
			this.txtHospitalCode.DownBack = null;
			this.txtHospitalCode.Icon = null;
			this.txtHospitalCode.IconIsButton = false;
			this.txtHospitalCode.IconMouseState = CCWin.SkinClass.ControlState.Normal;
			this.txtHospitalCode.IsPasswordChat = '\0';
			this.txtHospitalCode.IsSystemPasswordChar = false;
			this.txtHospitalCode.Lines = new string[0];
			this.txtHospitalCode.Location = new System.Drawing.Point(130, 43);
			this.txtHospitalCode.Margin = new System.Windows.Forms.Padding(0);
			this.txtHospitalCode.MaxLength = 32767;
			this.txtHospitalCode.MinimumSize = new System.Drawing.Size(28, 28);
			this.txtHospitalCode.MouseBack = null;
			this.txtHospitalCode.MouseState = CCWin.SkinClass.ControlState.Normal;
			this.txtHospitalCode.Multiline = false;
			this.txtHospitalCode.Name = "txtHospitalCode";
			this.txtHospitalCode.NormlBack = null;
			this.txtHospitalCode.Padding = new System.Windows.Forms.Padding(5);
			this.txtHospitalCode.ReadOnly = false;
			this.txtHospitalCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtHospitalCode.Size = new System.Drawing.Size(200, 28);
			// 
			// 
			// 
			this.txtHospitalCode.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtHospitalCode.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtHospitalCode.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
			this.txtHospitalCode.SkinTxt.Location = new System.Drawing.Point(5, 5);
			this.txtHospitalCode.SkinTxt.Name = "BaseText";
			this.txtHospitalCode.SkinTxt.Size = new System.Drawing.Size(190, 18);
			this.txtHospitalCode.SkinTxt.TabIndex = 0;
			this.txtHospitalCode.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.txtHospitalCode.SkinTxt.WaterText = "";
			this.txtHospitalCode.TabIndex = 11;
			this.txtHospitalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtHospitalCode.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.txtHospitalCode.WaterText = "";
			this.txtHospitalCode.WordWrap = true;
			// 
			// txtSpell
			// 
			this.txtSpell.BackColor = System.Drawing.Color.Transparent;
			this.txtSpell.DownBack = null;
			this.txtSpell.Icon = null;
			this.txtSpell.IconIsButton = false;
			this.txtSpell.IconMouseState = CCWin.SkinClass.ControlState.Normal;
			this.txtSpell.IsPasswordChat = '\0';
			this.txtSpell.IsSystemPasswordChar = false;
			this.txtSpell.Lines = new string[0];
			this.txtSpell.Location = new System.Drawing.Point(130, 129);
			this.txtSpell.Margin = new System.Windows.Forms.Padding(0);
			this.txtSpell.MaxLength = 32767;
			this.txtSpell.MinimumSize = new System.Drawing.Size(28, 28);
			this.txtSpell.MouseBack = null;
			this.txtSpell.MouseState = CCWin.SkinClass.ControlState.Normal;
			this.txtSpell.Multiline = false;
			this.txtSpell.Name = "txtSpell";
			this.txtSpell.NormlBack = null;
			this.txtSpell.Padding = new System.Windows.Forms.Padding(5);
			this.txtSpell.ReadOnly = false;
			this.txtSpell.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtSpell.Size = new System.Drawing.Size(200, 28);
			// 
			// 
			// 
			this.txtSpell.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtSpell.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtSpell.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
			this.txtSpell.SkinTxt.Location = new System.Drawing.Point(5, 5);
			this.txtSpell.SkinTxt.Name = "BaseText";
			this.txtSpell.SkinTxt.Size = new System.Drawing.Size(190, 18);
			this.txtSpell.SkinTxt.TabIndex = 0;
			this.txtSpell.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.txtSpell.SkinTxt.WaterText = "";
			this.txtSpell.TabIndex = 15;
			this.txtSpell.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSpell.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.txtSpell.WaterText = "";
			this.txtSpell.WordWrap = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(86, 137);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 12);
			this.label3.TabIndex = 14;
			this.label3.Text = "拼音：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(62, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 12);
			this.label2.TabIndex = 13;
			this.label2.Text = "院区名称：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(62, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 12);
			this.label1.TabIndex = 12;
			this.label1.Text = "院区编号：";
			// 
			// FrmHospitalEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 300);
			this.Controls.Add(this.skinGroupBox1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmHospitalEdit";
			this.ShowDrawIcon = false;
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "院区定义";
			this.Load += new System.EventHandler(this.FrmHospitalEdit_Load);
			this.skinGroupBox1.ResumeLayout(false);
			this.skinGroupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private CCWin.SkinControl.SkinButton btnSave;
		private CCWin.SkinControl.SkinButton btnClose;
		private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
		private CCWin.SkinControl.SkinTextBox txtHospitalName;
		private CCWin.SkinControl.SkinTextBox txtHospitalCode;
		private CCWin.SkinControl.SkinTextBox txtSpell;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private CCWin.SkinControl.SkinCheckBox chkIsPass;
	}
}