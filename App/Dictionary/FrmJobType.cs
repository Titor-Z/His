using CCWin;
using App.Common;
using App.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace App.Dictionary {
	public partial class FrmJobType : CCSkinMain {
		//****************************************************************************************************
		//委托
		public FrmMain tabForm {
			get; set;
		}
		//****************************************************************************************************
		public FrmJobType() {
			InitializeComponent();
		}
		//****************************************************************************************************
		//加载
		private void FrmJobType_Load(object sender, EventArgs e) {
			showData();
		}
		//****************************************************************************************************
		//显示数据
		private void showData() {
			DataTable dt = new ModJobType().setWhere("id > 0", true).getSelect();
			if (dt == null) {
				btnUpdate.Enabled = false;
			} else {
				btnUpdate.Enabled = true;

				int intIndex = 0;
				if (grd.Rows.Count > 0) {
					intIndex = grd.CurrentRow.Index;
				}

				grd.AutoGenerateColumns = false;
				grd.DataSource = dt;
				grd.Rows[intIndex].Cells[1].Selected = true;
			}
		}
		//****************************************************************************************************
		//添加
		private void btnInsert_Click(object sender, EventArgs e) {
			FrmJobTypeEdit frm = new FrmJobTypeEdit(0);
			if (frm.ShowDialog() == DialogResult.OK) {
				showData();
			}
		}
		//****************************************************************************************************
		//修改
		private void btnUpdate_Click(object sender, EventArgs e) {
			FrmJobTypeEdit frm = new FrmJobTypeEdit(Convert.ToInt32(grd.CurrentRow.Cells["id"].Value));
			if (frm.ShowDialog() == DialogResult.OK) {
				showData();
			}
		}
		//****************************************************************************************************
		//刷新
		private void btnRefresh_Click(object sender, EventArgs e) {
			showData();
		}
		//****************************************************************************************************
		//关闭
		private void btnClose_Click(object sender, EventArgs e) {
			tabForm.removeTabItem();

			this.Close();
		}
		//****************************************************************************************************
		//显示审核状态
		private void dgrd_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
			ParseGrid.showPass(grd, e);
		}
		//****************************************************************************************************
	}
}
