namespace App.Dictionary {
	partial class FrmDepartmentEdit {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartmentEdit));
			this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
			this.chkIsPass = new CCWin.SkinControl.SkinCheckBox();
			this.txtDepartmentName = new CCWin.SkinControl.SkinTextBox();
			this.txtDepartmentCode = new CCWin.SkinControl.SkinTextBox();
			this.txtSpell = new CCWin.SkinControl.SkinTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.skinButton1 = new CCWin.SkinControl.SkinButton();
			this.skinButton2 = new CCWin.SkinControl.SkinButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbHospitalId = new CCWin.SkinControl.SkinComboBox();
			this.cmbDepartmentTypeId = new CCWin.SkinControl.SkinComboBox();
			this.skinGroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// skinGroupBox1
			// 
			this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
			this.skinGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
			this.skinGroupBox1.Controls.Add(this.cmbDepartmentTypeId);
			this.skinGroupBox1.Controls.Add(this.cmbHospitalId);
			this.skinGroupBox1.Controls.Add(this.label3);
			this.skinGroupBox1.Controls.Add(this.label1);
			this.skinGroupBox1.Controls.Add(this.chkIsPass);
			this.skinGroupBox1.Controls.Add(this.txtDepartmentName);
			this.skinGroupBox1.Controls.Add(this.txtDepartmentCode);
			this.skinGroupBox1.Controls.Add(this.txtSpell);
			this.skinGroupBox1.Controls.Add(this.label6);
			this.skinGroupBox1.Controls.Add(this.label7);
			this.skinGroupBox1.Controls.Add(this.label8);
			this.skinGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.skinGroupBox1.ForeColor = System.Drawing.Color.Blue;
			this.skinGroupBox1.Location = new System.Drawing.Point(4, 28);
			this.skinGroupBox1.Name = "skinGroupBox1";
			this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
			this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
			this.skinGroupBox1.Size = new System.Drawing.Size(392, 233);
			this.skinGroupBox1.TabIndex = 16;
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
			this.chkIsPass.Location = new System.Drawing.Point(132, 195);
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
			// txtDepartmentName
			// 
			this.txtDepartmentName.BackColor = System.Drawing.Color.Transparent;
			this.txtDepartmentName.DownBack = null;
			this.txtDepartmentName.Icon = null;
			this.txtDepartmentName.IconIsButton = false;
			this.txtDepartmentName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
			this.txtDepartmentName.IsPasswordChat = '\0';
			this.txtDepartmentName.IsSystemPasswordChar = false;
			this.txtDepartmentName.Lines = new string[0];
			this.txtDepartmentName.Location = new System.Drawing.Point(132, 122);
			this.txtDepartmentName.Margin = new System.Windows.Forms.Padding(0);
			this.txtDepartmentName.MaxLength = 32767;
			this.txtDepartmentName.MinimumSize = new System.Drawing.Size(28, 28);
			this.txtDepartmentName.MouseBack = null;
			this.txtDepartmentName.MouseState = CCWin.SkinClass.ControlState.Normal;
			this.txtDepartmentName.Multiline = false;
			this.txtDepartmentName.Name = "txtDepartmentName";
			this.txtDepartmentName.NormlBack = null;
			this.txtDepartmentName.Padding = new System.Windows.Forms.Padding(5);
			this.txtDepartmentName.ReadOnly = false;
			this.txtDepartmentName.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtDepartmentName.Size = new System.Drawing.Size(200, 28);
			// 
			// 
			// 
			this.txtDepartmentName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtDepartmentName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtDepartmentName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
			this.txtDepartmentName.SkinTxt.Location = new System.Drawing.Point(5, 5);
			this.txtDepartmentName.SkinTxt.Name = "BaseText";
			this.txtDepartmentName.SkinTxt.Size = new System.Drawing.Size(190, 18);
			this.txtDepartmentName.SkinTxt.TabIndex = 0;
			this.txtDepartmentName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.txtDepartmentName.SkinTxt.WaterText = "";
			this.txtDepartmentName.TabIndex = 10;
			this.txtDepartmentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDepartmentName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.txtDepartmentName.WaterText = "";
			this.txtDepartmentName.WordWrap = true;
			// 
			// txtDepartmentCode
			// 
			this.txtDepartmentCode.BackColor = System.Drawing.Color.Transparent;
			this.txtDepartmentCode.DownBack = null;
			this.txtDepartmentCode.Icon = null;
			this.txtDepartmentCode.IconIsButton = false;
			this.txtDepartmentCode.IconMouseState = CCWin.SkinClass.ControlState.Normal;
			this.txtDepartmentCode.IsPasswordChat = '\0';
			this.txtDepartmentCode.IsSystemPasswordChar = false;
			this.txtDepartmentCode.Lines = new string[0];
			this.txtDepartmentCode.Location = new System.Drawing.Point(132, 84);
			this.txtDepartmentCode.Margin = new System.Windows.Forms.Padding(0);
			this.txtDepartmentCode.MaxLength = 32767;
			this.txtDepartmentCode.MinimumSize = new System.Drawing.Size(28, 28);
			this.txtDepartmentCode.MouseBack = null;
			this.txtDepartmentCode.MouseState = CCWin.SkinClass.ControlState.Normal;
			this.txtDepartmentCode.Multiline = false;
			this.txtDepartmentCode.Name = "txtDepartmentCode";
			this.txtDepartmentCode.NormlBack = null;
			this.txtDepartmentCode.Padding = new System.Windows.Forms.Padding(5);
			this.txtDepartmentCode.ReadOnly = false;
			this.txtDepartmentCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtDepartmentCode.Size = new System.Drawing.Size(200, 28);
			// 
			// 
			// 
			this.txtDepartmentCode.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtDepartmentCode.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtDepartmentCode.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
			this.txtDepartmentCode.SkinTxt.Location = new System.Drawing.Point(5, 5);
			this.txtDepartmentCode.SkinTxt.Name = "BaseText";
			this.txtDepartmentCode.SkinTxt.Size = new System.Drawing.Size(190, 18);
			this.txtDepartmentCode.SkinTxt.TabIndex = 0;
			this.txtDepartmentCode.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.txtDepartmentCode.SkinTxt.WaterText = "";
			this.txtDepartmentCode.TabIndex = 11;
			this.txtDepartmentCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtDepartmentCode.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.txtDepartmentCode.WaterText = "";
			this.txtDepartmentCode.WordWrap = true;
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
			this.txtSpell.Location = new System.Drawing.Point(132, 164);
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
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.Red;
			this.label6.Location = new System.Drawing.Point(84, 172);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 12);
			this.label6.TabIndex = 14;
			this.label6.Text = "拼音：";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.Color.Red;
			this.label7.Location = new System.Drawing.Point(60, 54);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 12);
			this.label7.TabIndex = 13;
			this.label7.Text = "科室类型：";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.Color.Red;
			this.label8.Location = new System.Drawing.Point(60, 21);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 12);
			this.label8.TabIndex = 12;
			this.label8.Text = "所属院区：";
			// 
			// skinButton1
			// 
			this.skinButton1.BackColor = System.Drawing.Color.Transparent;
			this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.skinButton1.DownBack = null;
			this.skinButton1.Image = ((System.Drawing.Image)(resources.GetObject("skinButton1.Image")));
			this.skinButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.skinButton1.Location = new System.Drawing.Point(122, 267);
			this.skinButton1.MouseBack = null;
			this.skinButton1.Name = "skinButton1";
			this.skinButton1.NormlBack = null;
			this.skinButton1.Size = new System.Drawing.Size(75, 23);
			this.skinButton1.TabIndex = 15;
			this.skinButton1.Text = "关闭(&C)";
			this.skinButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.skinButton1.UseVisualStyleBackColor = false;
			this.skinButton1.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// skinButton2
			// 
			this.skinButton2.BackColor = System.Drawing.Color.Transparent;
			this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.skinButton2.DownBack = null;
			this.skinButton2.Image = ((System.Drawing.Image)(resources.GetObject("skinButton2.Image")));
			this.skinButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.skinButton2.Location = new System.Drawing.Point(203, 267);
			this.skinButton2.MouseBack = null;
			this.skinButton2.Name = "skinButton2";
			this.skinButton2.NormlBack = null;
			this.skinButton2.Size = new System.Drawing.Size(75, 23);
			this.skinButton2.TabIndex = 14;
			this.skinButton2.Text = "保存(&S)";
			this.skinButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.skinButton2.UseVisualStyleBackColor = false;
			this.skinButton2.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(62, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 12);
			this.label1.TabIndex = 17;
			this.label1.Text = "科室编号：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(62, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 12);
			this.label3.TabIndex = 18;
			this.label3.Text = "科室名称";
			// 
			// cmbHospitalId
			// 
			this.cmbHospitalId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbHospitalId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbHospitalId.FormattingEnabled = true;
			this.cmbHospitalId.Location = new System.Drawing.Point(132, 16);
			this.cmbHospitalId.Name = "cmbHospitalId";
			this.cmbHospitalId.Size = new System.Drawing.Size(200, 22);
			this.cmbHospitalId.TabIndex = 19;
			this.cmbHospitalId.WaterText = "";
			// 
			// cmbDepartmentTypeId
			// 
			this.cmbDepartmentTypeId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbDepartmentTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDepartmentTypeId.FormattingEnabled = true;
			this.cmbDepartmentTypeId.Location = new System.Drawing.Point(132, 49);
			this.cmbDepartmentTypeId.Name = "cmbDepartmentTypeId";
			this.cmbDepartmentTypeId.Size = new System.Drawing.Size(200, 22);
			this.cmbDepartmentTypeId.TabIndex = 20;
			this.cmbDepartmentTypeId.WaterText = "";
			// 
			// FrmDepartmentEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 300);
			this.Controls.Add(this.skinGroupBox1);
			this.Controls.Add(this.skinButton1);
			this.Controls.Add(this.skinButton2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmDepartmentEdit";
			this.ShowDrawIcon = false;
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Tag = "1";
			this.Text = "科室";
			this.Load += new System.EventHandler(this.FrmDepartmentEdit_Load);
			this.skinGroupBox1.ResumeLayout(false);
			this.skinGroupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private CCWin.SkinControl.SkinCheckBox chkIsPass;
		private CCWin.SkinControl.SkinTextBox txtDepartmentName;
		private CCWin.SkinControl.SkinTextBox txtDepartmentCode;
		private CCWin.SkinControl.SkinTextBox txtSpell;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private CCWin.SkinControl.SkinButton skinButton1;
		private CCWin.SkinControl.SkinButton skinButton2;
		private CCWin.SkinControl.SkinComboBox cmbDepartmentTypeId;
		private CCWin.SkinControl.SkinComboBox cmbHospitalId;
	}
}