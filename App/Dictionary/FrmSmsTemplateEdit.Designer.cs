namespace App.Dictionary {
	partial class FrmSmsTemplateEdit {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSmsTemplateEdit));
			this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
			this.chkIsPass = new CCWin.SkinControl.SkinCheckBox();
			this.txtContent = new CCWin.SkinControl.SkinTextBox();
			this.txtTemplateName = new CCWin.SkinControl.SkinTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
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
			this.skinGroupBox1.Controls.Add(this.txtContent);
			this.skinGroupBox1.Controls.Add(this.txtTemplateName);
			this.skinGroupBox1.Controls.Add(this.label4);
			this.skinGroupBox1.Controls.Add(this.label5);
			this.skinGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.skinGroupBox1.ForeColor = System.Drawing.Color.Blue;
			this.skinGroupBox1.Location = new System.Drawing.Point(4, 28);
			this.skinGroupBox1.Name = "skinGroupBox1";
			this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
			this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
			this.skinGroupBox1.Size = new System.Drawing.Size(592, 336);
			this.skinGroupBox1.TabIndex = 19;
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
			this.chkIsPass.Location = new System.Drawing.Point(130, 256);
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
			// txtContent
			// 
			this.txtContent.BackColor = System.Drawing.Color.Transparent;
			this.txtContent.DownBack = null;
			this.txtContent.Icon = null;
			this.txtContent.IconIsButton = false;
			this.txtContent.IconMouseState = CCWin.SkinClass.ControlState.Normal;
			this.txtContent.IsPasswordChat = '\0';
			this.txtContent.IsSystemPasswordChar = false;
			this.txtContent.Lines = new string[0];
			this.txtContent.Location = new System.Drawing.Point(130, 103);
			this.txtContent.Margin = new System.Windows.Forms.Padding(0);
			this.txtContent.MaxLength = 32767;
			this.txtContent.MinimumSize = new System.Drawing.Size(28, 28);
			this.txtContent.MouseBack = null;
			this.txtContent.MouseState = CCWin.SkinClass.ControlState.Normal;
			this.txtContent.Multiline = true;
			this.txtContent.Name = "txtContent";
			this.txtContent.NormlBack = null;
			this.txtContent.Padding = new System.Windows.Forms.Padding(5);
			this.txtContent.ReadOnly = false;
			this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtContent.Size = new System.Drawing.Size(400, 150);
			// 
			// 
			// 
			this.txtContent.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtContent.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtContent.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
			this.txtContent.SkinTxt.Location = new System.Drawing.Point(5, 5);
			this.txtContent.SkinTxt.Multiline = true;
			this.txtContent.SkinTxt.Name = "BaseText";
			this.txtContent.SkinTxt.Size = new System.Drawing.Size(390, 140);
			this.txtContent.SkinTxt.TabIndex = 0;
			this.txtContent.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.txtContent.SkinTxt.WaterText = "";
			this.txtContent.TabIndex = 10;
			this.txtContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtContent.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.txtContent.WaterText = "";
			this.txtContent.WordWrap = true;
			// 
			// txtTemplateName
			// 
			this.txtTemplateName.BackColor = System.Drawing.Color.Transparent;
			this.txtTemplateName.DownBack = null;
			this.txtTemplateName.Icon = null;
			this.txtTemplateName.IconIsButton = false;
			this.txtTemplateName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
			this.txtTemplateName.IsPasswordChat = '\0';
			this.txtTemplateName.IsSystemPasswordChar = false;
			this.txtTemplateName.Lines = new string[0];
			this.txtTemplateName.Location = new System.Drawing.Point(130, 60);
			this.txtTemplateName.Margin = new System.Windows.Forms.Padding(0);
			this.txtTemplateName.MaxLength = 32767;
			this.txtTemplateName.MinimumSize = new System.Drawing.Size(28, 28);
			this.txtTemplateName.MouseBack = null;
			this.txtTemplateName.MouseState = CCWin.SkinClass.ControlState.Normal;
			this.txtTemplateName.Multiline = false;
			this.txtTemplateName.Name = "txtTemplateName";
			this.txtTemplateName.NormlBack = null;
			this.txtTemplateName.Padding = new System.Windows.Forms.Padding(5);
			this.txtTemplateName.ReadOnly = false;
			this.txtTemplateName.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtTemplateName.Size = new System.Drawing.Size(200, 28);
			// 
			// 
			// 
			this.txtTemplateName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTemplateName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtTemplateName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
			this.txtTemplateName.SkinTxt.Location = new System.Drawing.Point(5, 5);
			this.txtTemplateName.SkinTxt.Name = "BaseText";
			this.txtTemplateName.SkinTxt.Size = new System.Drawing.Size(190, 18);
			this.txtTemplateName.SkinTxt.TabIndex = 0;
			this.txtTemplateName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.txtTemplateName.SkinTxt.WaterText = "";
			this.txtTemplateName.TabIndex = 11;
			this.txtTemplateName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtTemplateName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.txtTemplateName.WaterText = "";
			this.txtTemplateName.WordWrap = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(62, 172);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 12);
			this.label4.TabIndex = 13;
			this.label4.Text = "模板内容：";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(62, 68);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 12);
			this.label5.TabIndex = 12;
			this.label5.Text = "模板名称：";
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Transparent;
			this.btnClose.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.btnClose.DownBack = null;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(222, 370);
			this.btnClose.MouseBack = null;
			this.btnClose.Name = "btnClose";
			this.btnClose.NormlBack = null;
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 18;
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
			this.btnSave.Location = new System.Drawing.Point(303, 370);
			this.btnSave.MouseBack = null;
			this.btnSave.Name = "btnSave";
			this.btnSave.NormlBack = null;
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 17;
			this.btnSave.Text = "保存(&S)";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// FrmSmsTemplateEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 400);
			this.Controls.Add(this.skinGroupBox1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmSmsTemplateEdit";
			this.ShowDrawIcon = false;
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "短信模板";
			this.Load += new System.EventHandler(this.FrmSmsTemplateEdit_Load);
			this.skinGroupBox1.ResumeLayout(false);
			this.skinGroupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
		private CCWin.SkinControl.SkinCheckBox chkIsPass;
		private CCWin.SkinControl.SkinTextBox txtContent;
		private CCWin.SkinControl.SkinTextBox txtTemplateName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private CCWin.SkinControl.SkinButton btnClose;
		private CCWin.SkinControl.SkinButton btnSave;
	}
}