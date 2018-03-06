namespace App.Common {
	partial class ComboboxProvinceCityCounty {
		/// <summary> 
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.cmbProvince = new CCWin.SkinControl.SkinComboBox();
			this.cmbCity = new CCWin.SkinControl.SkinComboBox();
			this.cmbCounty = new CCWin.SkinControl.SkinComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "省市县：";
			// 
			// cmbProvince
			// 
			this.cmbProvince.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbProvince.FormattingEnabled = true;
			this.cmbProvince.Location = new System.Drawing.Point(56, 0);
			this.cmbProvince.Name = "cmbProvince";
			this.cmbProvince.Size = new System.Drawing.Size(160, 22);
			this.cmbProvince.TabIndex = 1;
			this.cmbProvince.WaterText = "";
			// 
			// cmbCity
			// 
			this.cmbCity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCity.FormattingEnabled = true;
			this.cmbCity.Location = new System.Drawing.Point(228, 0);
			this.cmbCity.Name = "cmbCity";
			this.cmbCity.Size = new System.Drawing.Size(160, 22);
			this.cmbCity.TabIndex = 2;
			this.cmbCity.WaterText = "";
			// 
			// cmbCounty
			// 
			this.cmbCounty.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCounty.FormattingEnabled = true;
			this.cmbCounty.Location = new System.Drawing.Point(400, 0);
			this.cmbCounty.Name = "cmbCounty";
			this.cmbCounty.Size = new System.Drawing.Size(160, 22);
			this.cmbCounty.TabIndex = 3;
			this.cmbCounty.WaterText = "";
			// 
			// CtrlCity
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.cmbCounty);
			this.Controls.Add(this.cmbCity);
			this.Controls.Add(this.cmbProvince);
			this.Controls.Add(this.label1);
			this.Name = "CtrlCity";
			this.Size = new System.Drawing.Size(560, 22);
			this.Load += new System.EventHandler(this.CtrlCity_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private CCWin.SkinControl.SkinComboBox cmbProvince;
		private CCWin.SkinControl.SkinComboBox cmbCity;
		private CCWin.SkinControl.SkinComboBox cmbCounty;
	}
}
