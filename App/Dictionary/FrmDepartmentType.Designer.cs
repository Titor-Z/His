namespace App.Dictionary {
	partial class FrmDepartmentType {
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartmentType));
			this.grd = new CCWin.SkinControl.SkinDataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skinToolStrip1 = new CCWin.SkinControl.SkinToolStrip();
			this.btnInsert = new System.Windows.Forms.ToolStripButton();
			this.btnUpdate = new System.Windows.Forms.ToolStripButton();
			this.btnRefresh = new System.Windows.Forms.ToolStripButton();
			this.btnClose = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
			this.skinToolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// grd
			// 
			this.grd.AllowUserToAddRows = false;
			this.grd.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
			this.grd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.grd.BackgroundColor = System.Drawing.SystemColors.Window;
			this.grd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.grd.ColumnFont = null;
			this.grd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column4,
            this.Column6});
			this.grd.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grd.DefaultCellStyle = dataGridViewCellStyle3;
			this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grd.EnableHeadersVisualStyles = false;
			this.grd.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.grd.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.grd.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
			this.grd.Location = new System.Drawing.Point(4, 58);
			this.grd.MultiSelect = false;
			this.grd.Name = "grd";
			this.grd.ReadOnly = true;
			this.grd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.grd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			this.grd.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.grd.RowTemplate.Height = 23;
			this.grd.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grd.Size = new System.Drawing.Size(586, 313);
			this.grd.TabIndex = 12;
			this.grd.TitleBack = null;
			this.grd.TitleBackColorBegin = System.Drawing.Color.White;
			this.grd.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
			this.grd.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgrd_CellFormatting);
			// 
			// id
			// 
			this.id.DataPropertyName = "id";
			this.id.HeaderText = "id";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Visible = false;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "isPass";
			this.Column4.HeaderText = "状态";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "departmentType";
			this.Column6.HeaderText = "科室类型";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column6.Width = 200;
			// 
			// skinToolStrip1
			// 
			this.skinToolStrip1.Arrow = System.Drawing.Color.Black;
			this.skinToolStrip1.AutoSize = false;
			this.skinToolStrip1.Back = System.Drawing.Color.White;
			this.skinToolStrip1.BackRadius = 4;
			this.skinToolStrip1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
			this.skinToolStrip1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
			this.skinToolStrip1.BaseFore = System.Drawing.Color.Black;
			this.skinToolStrip1.BaseForeAnamorphosis = false;
			this.skinToolStrip1.BaseForeAnamorphosisBorder = 4;
			this.skinToolStrip1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
			this.skinToolStrip1.BaseForeOffset = new System.Drawing.Point(0, 0);
			this.skinToolStrip1.BaseHoverFore = System.Drawing.Color.White;
			this.skinToolStrip1.BaseItemAnamorphosis = true;
			this.skinToolStrip1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
			this.skinToolStrip1.BaseItemBorderShow = true;
			this.skinToolStrip1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinToolStrip1.BaseItemDown")));
			this.skinToolStrip1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
			this.skinToolStrip1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinToolStrip1.BaseItemMouse")));
			this.skinToolStrip1.BaseItemNorml = null;
			this.skinToolStrip1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
			this.skinToolStrip1.BaseItemRadius = 4;
			this.skinToolStrip1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
			this.skinToolStrip1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
			this.skinToolStrip1.BindTabControl = null;
			this.skinToolStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
			this.skinToolStrip1.Fore = System.Drawing.Color.Black;
			this.skinToolStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
			this.skinToolStrip1.HoverFore = System.Drawing.Color.White;
			this.skinToolStrip1.ItemAnamorphosis = true;
			this.skinToolStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
			this.skinToolStrip1.ItemBorderShow = true;
			this.skinToolStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
			this.skinToolStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
			this.skinToolStrip1.ItemRadius = 4;
			this.skinToolStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
			this.skinToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInsert,
            this.btnUpdate,
            this.btnRefresh,
            this.btnClose});
			this.skinToolStrip1.Location = new System.Drawing.Point(4, 8);
			this.skinToolStrip1.Name = "skinToolStrip1";
			this.skinToolStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
			this.skinToolStrip1.Size = new System.Drawing.Size(586, 50);
			this.skinToolStrip1.SkinAllColor = true;
			this.skinToolStrip1.TabIndex = 13;
			this.skinToolStrip1.Text = "skinToolStrip1";
			this.skinToolStrip1.TitleAnamorphosis = true;
			this.skinToolStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
			this.skinToolStrip1.TitleRadius = 4;
			this.skinToolStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
			// 
			// btnInsert
			// 
			this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
			this.btnInsert.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(51, 47);
			this.btnInsert.Text = "添加(&I)";
			this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
			this.btnUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(51, 47);
			this.btnUpdate.Text = "修改(&U)";
			this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(51, 47);
			this.btnRefresh.Text = "刷新(&R)";
			this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnClose
			// 
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(51, 47);
			this.btnClose.Text = "关闭(&C)";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// FrmDepartmentType
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CaptionHeight = 4;
			this.ClientSize = new System.Drawing.Size(594, 375);
			this.ControlBox = false;
			this.Controls.Add(this.grd);
			this.Controls.Add(this.skinToolStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MdiBorderStyle = System.Windows.Forms.BorderStyle.None;
			this.MinimizeBox = false;
			this.Mobile = CCWin.MobileStyle.None;
			this.Name = "FrmDepartmentType";
			this.Shadow = false;
			this.ShowBorder = false;
			this.ShowDrawIcon = false;
			this.ShowIcon = false;
			this.Text = "";
			this.Load += new System.EventHandler(this.FrmDepartmentType_Load);
			((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
			this.skinToolStrip1.ResumeLayout(false);
			this.skinToolStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private CCWin.SkinControl.SkinDataGridView grd;
		private CCWin.SkinControl.SkinToolStrip skinToolStrip1;
		private System.Windows.Forms.ToolStripButton btnInsert;
		private System.Windows.Forms.ToolStripButton btnUpdate;
		private System.Windows.Forms.ToolStripButton btnRefresh;
		private System.Windows.Forms.ToolStripButton btnClose;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
	}
}