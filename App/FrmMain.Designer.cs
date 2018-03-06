namespace App {
	partial class FrmMain {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tspTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.tab = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPage1 = new CCWin.SkinControl.SkinTabPage();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.mnuApp = new CCWin.SkinControl.SkinMenuStrip();
            this.statusStrip1.SuspendLayout();
            this.tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspTime,
            this.tspInfo});
            this.statusStrip1.Location = new System.Drawing.Point(4, 574);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(792, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tspTime
            // 
            this.tspTime.AutoSize = false;
            this.tspTime.Name = "tspTime";
            this.tspTime.Size = new System.Drawing.Size(300, 17);
            this.tspTime.Text = "时间";
            this.tspTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tspInfo
            // 
            this.tspInfo.Name = "tspInfo";
            this.tspInfo.Size = new System.Drawing.Size(90, 17);
            this.tspInfo.Text = "院区-科室-姓名";
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // tab
            // 
            this.tab.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.tab.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.tab.Controls.Add(this.skinTabPage1);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.HeadBack = null;
            this.tab.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.tab.ItemSize = new System.Drawing.Size(100, 36);
            this.tab.Location = new System.Drawing.Point(4, 52);
            this.tab.Name = "tab";
            this.tab.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("tab.PageArrowDown")));
            this.tab.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("tab.PageArrowHover")));
            this.tab.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("tab.PageCloseHover")));
            this.tab.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("tab.PageCloseNormal")));
            this.tab.PageDown = ((System.Drawing.Image)(resources.GetObject("tab.PageDown")));
            this.tab.PageHover = ((System.Drawing.Image)(resources.GetObject("tab.PageHover")));
            this.tab.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.tab.PageNorml = null;
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(792, 522);
            this.tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab.TabIndex = 3;
            // 
            // skinTabPage1
            // 
            this.skinTabPage1.BackColor = System.Drawing.Color.White;
            this.skinTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage1.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage1.Name = "skinTabPage1";
            this.skinTabPage1.Size = new System.Drawing.Size(792, 486);
            this.skinTabPage1.TabIndex = 0;
            this.skinTabPage1.TabItemImage = null;
            this.skinTabPage1.Tag = "";
            this.skinTabPage1.Text = "导航台";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // mnuApp
            // 
            this.mnuApp.Arrow = System.Drawing.Color.Black;
            this.mnuApp.Back = System.Drawing.Color.White;
            this.mnuApp.BackRadius = 4;
            this.mnuApp.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.mnuApp.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.mnuApp.BaseFore = System.Drawing.Color.Black;
            this.mnuApp.BaseForeAnamorphosis = false;
            this.mnuApp.BaseForeAnamorphosisBorder = 4;
            this.mnuApp.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.mnuApp.BaseHoverFore = System.Drawing.Color.White;
            this.mnuApp.BaseItemAnamorphosis = true;
            this.mnuApp.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.mnuApp.BaseItemBorderShow = true;
            this.mnuApp.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("mnuApp.BaseItemDown")));
            this.mnuApp.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.mnuApp.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("mnuApp.BaseItemMouse")));
            this.mnuApp.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.mnuApp.BaseItemRadius = 4;
            this.mnuApp.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.mnuApp.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.mnuApp.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.mnuApp.Fore = System.Drawing.Color.Black;
            this.mnuApp.HoverFore = System.Drawing.Color.White;
            this.mnuApp.ItemAnamorphosis = true;
            this.mnuApp.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.mnuApp.ItemBorderShow = true;
            this.mnuApp.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.mnuApp.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.mnuApp.ItemRadius = 4;
            this.mnuApp.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.mnuApp.Location = new System.Drawing.Point(4, 28);
            this.mnuApp.Name = "mnuApp";
            this.mnuApp.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.mnuApp.Size = new System.Drawing.Size(792, 24);
            this.mnuApp.SkinAllColor = true;
            this.mnuApp.TabIndex = 4;
            this.mnuApp.Text = "skinMenuStrip1";
            this.mnuApp.TitleAnamorphosis = true;
            this.mnuApp.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.mnuApp.TitleRadius = 4;
            this.mnuApp.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.mnuApp);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Mobile = CCWin.MobileStyle.None;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.Text = "-His医院管理信息系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel tspTime;
		private System.Windows.Forms.ToolStripStatusLabel tspInfo;
		private System.Windows.Forms.Timer tmr;
		private CCWin.SkinControl.SkinTabPage skinTabPage1;
		private CCWin.SkinControl.SkinTabControl tab;
		private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
		private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
		private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
		private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
		private System.Windows.Forms.ToolStripContentPanel ContentPanel;
		private CCWin.SkinControl.SkinMenuStrip mnuApp;
	}
}