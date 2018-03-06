namespace App.Dictionary {
	partial class FrmUserLevelEdit {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserLevelEdit));
			this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
			this.chkIsPass = new CCWin.SkinControl.SkinCheckBox();
			this.txtUserLevel = new CCWin.SkinControl.SkinTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnClose = new CCWin.SkinControl.SkinButton();
			this.btnSave = new CCWin.SkinControl.SkinButton();
			this.skinGroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// skinGroupBox1
			// 
			this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
			this.skinGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
			this.skinGroupBox1.Controls.Add(this.chkIsPass);
			this.skinGroupBox1.Controls.Add(this.txtUserLevel);
			this.skinGroupBox1.Controls.Add(this.label4);
			this.skinGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.skinGroupBox1.ForeColor = System.Drawing.Color.Blue;
			this.skinGroupBox1.Location = new System.Drawing.Point(4, 28);
			this.skinGroupBox1.Name = "skinGroupBox1";
			this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
			this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
			this.skinGroupBox1.Size = new System.Drawing.Size(392, 236);
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
			this.chkIsPass.Location = new System.Drawing.Point(130, 123);
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
			// txtUserLevel
			// 
			this.txtUserLevel.BackColor = System.Drawing.Color.Transparent;
			this.txtUserLevel.DownBack = null;
			this.txtUserLevel.Icon = null;
			this.txtUserLevel.IconIsButton = false;
			this.txtUserLevel.IconMouseState = CCWin.SkinClass.ControlState.Normal;
			this.txtUserLevel.IsPasswordChat = '\0';
			this.txtUserLevel.IsSystemPasswordChar = false;
			this.txtUserLevel.Lines = new string[0];
			this.txtUserLevel.Location = new System.Drawing.Point(130, 92);
			this.txtUserLevel.Margin = new System.Windows.Forms.Padding(0);
			this.txtUserLevel.MaxLength = 32767;
			this.txtUserLevel.MinimumSize = new System.Drawing.Size(28, 28);
			this.txtUserLevel.MouseBack = null;
			this.txtUserLevel.MouseState = CCWin.SkinClass.ControlState.Normal;
			this.txtUserLevel.Multiline = false;
			this.txtUserLevel.Name = "txtUserLevel";
			this.txtUserLevel.NormlBack = null;
			this.txtUserLevel.Padding = new System.Windows.Forms.Padding(5);
			this.txtUserLevel.ReadOnly = false;
			this.txtUserLevel.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtUserLevel.Size = new System.Drawing.Size(200, 28);
			// 
			// 
			// 
			this.txtUserLevel.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUserLevel.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtUserLevel.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
			this.txtUserLevel.SkinTxt.Location = new System.Drawing.Point(5, 5);
			this.txtUserLevel.SkinTxt.Name = "BaseText";
			this.txtUserLevel.SkinTxt.Size = new System.Drawing.Size(190, 18);
			this.txtUserLevel.SkinTxt.TabIndex = 0;
			this.txtUserLevel.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.txtUserLevel.SkinTxt.WaterText = "";
			this.txtUserLevel.TabIndex = 11;
			this.txtUserLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtUserLevel.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.txtUserLevel.WaterText = "";
			this.txtUserLevel.WordWrap = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(62, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 12);
			this.label4.TabIndex = 12;
			this.label4.Text = "会员级别：";
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
			this.btnClose.TabIndex = 15;
			this.btnClose.Text = "关闭(&C)";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
			this.btnSave.TabIndex = 14;
			this.btnSave.Text = "保存(&S)";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// FrmUserLevelEdit
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
			this.Name = "FrmUserLevelEdit";
			this.ShowDrawIcon = false;
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "会员级别";
			this.Load += new System.EventHandler(this.FrmUserLevelEdit_Load);
			this.skinGroupBox1.ResumeLayout(false);
			this.skinGroupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
		private CCWin.SkinControl.SkinCheckBox chkIsPass;
		private CCWin.SkinControl.SkinTextBox txtUserLevel;
		private System.Windows.Forms.Label label4;
		private CCWin.SkinControl.SkinButton btnClose;
		private CCWin.SkinControl.SkinButton btnSave;
	}
}