using App.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace App.Reserver {
	public partial class FrmReserver : Form {
		//****************************************************************************************************
		//委托
		public FrmMain tabForm {
			get; set;
		}
		//****************************************************************************************************
		public FrmReserver() {
			InitializeComponent();
		}
		//****************************************************************************************************
		//加载
		private void FrmReserver_Load(object sender, EventArgs e) {
			showData();
		}
		//****************************************************************************************************
		//显示数据
		private void showData() {
			DataTable dt = new ModReserver().getSelect();
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
			FrmReserverEdit frm = new FrmReserverEdit(0);
			if (frm.ShowDialog() == DialogResult.OK) {
				showData();
			}
		}
		//****************************************************************************************************
		//修改
		private void btnUpdate_Click(object sender, EventArgs e) {
			FrmReserverEdit frm = new FrmReserverEdit(Convert.ToInt32(grd.CurrentRow.Cells["id"].Value));
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
			this.Close();
		}
		//****************************************************************************************************
		//搜索
		private void btnSearch_Click(object sender, EventArgs e) {

		}
		//****************************************************************************************************
		//距到院 7 天内患者
		private void btnWeekUser_Click(object sender, EventArgs e) {

		}
		//****************************************************************************************************
		//全部患者
		private void btnAllUser_Click(object sender, EventArgs e) {

		}
		//****************************************************************************************************
	}
}
