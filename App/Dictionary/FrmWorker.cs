using CCWin;
using App.Common;
using App.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace App.Dictionary {
	public partial class FrmWorker : CCSkinMain {
		//****************************************************************************************************
		//委托
		public FrmMain tabForm {
			get; set;
		}
		//****************************************************************************************************
		//加载
		public FrmWorker() {
			InitializeComponent();
		}
		//****************************************************************************************************
		//窗体加载
		private void frmWorker_Load(object sender, EventArgs e) {
			TreeNode tnAll = new TreeNode();
			tnAll.Text = "全部科室";
			tnAll.Tag = 0;

			DataTable dt = new ModDepartment().getSelect();
			foreach (DataRow dr in dt.Rows) {
				TreeNode tnChild = new TreeNode();
				tnChild.Text = dr["departmentName"].ToString();
				tnChild.Tag = dr["id"].ToString();

				tnAll.Nodes.Add(tnChild);
			}

			tre.Nodes.Add(tnAll);
			tre.ExpandAll();
			tre.Select();
			tre.HideSelection = false;

			showData();
		}
		//****************************************************************************************************
		//显示数据
		private void showData() {
			DataTable dt = new ModWorker().setWhere("id > 0", true).setRelation(true).getSelect();
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
		private void tre_AfterSelect(object sender, TreeViewEventArgs e) {
			//Global.ShowMessageBox(tre.SelectedNode.Tag.ToString());
		}
		//****************************************************************************************************
		//添加
		private void btnInsert_Click(object sender, EventArgs e) {
			FrmWorkerEdit frm = new FrmWorkerEdit(0);
			if (frm.ShowDialog() == DialogResult.OK) {
				showData();
			}
		}
		//****************************************************************************************************
		//修改
		private void btnUpdate_Click(object sender, EventArgs e) {
			FrmWorkerEdit frm = new FrmWorkerEdit(Convert.ToInt32(grd.CurrentRow.Cells["id"].Value));
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
		////显示审核状态
		private void dgrd_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
			ParseGrid.showPass(grd, e);
		}
		//****************************************************************************************************
	}
}
