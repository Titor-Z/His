using CCWin;
using App.Common;
using App.Model;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace App.Dictionary {
	public partial class FrmDepartmentTypeEdit : CCSkinMain {
		private int intId;
		//****************************************************************************************************
		public FrmDepartmentTypeEdit(int intId) {
			InitializeComponent();

			this.intId = intId;
		}
		//****************************************************************************************************
		//关闭
		private void btnClose_Click(object sender, EventArgs e) {
			this.Close();
		}
		//****************************************************************************************************
		private void FrmDepartmentTypeEdit_Load(object sender, EventArgs e) {
			if (intId == 0) {
				this.Text = "添加" + this.Text;
			} else {
				this.Text = "修改" + this.Text;

				DataRow dr = new ModDepartmentType().setWhere("id > 0", true).getFind(intId);
				if (dr == null) {
					Function.showMessage("记录为空");
				} else {
					txtDepartmentType.Text = dr["departmentType"].ToString();
					chkIsPass.Checked = Convert.ToBoolean(dr["isPass"]);
				}
			}
		}
		//****************************************************************************************************
		private void btnSave_Click(object sender, EventArgs e) {
			string strDepartmentType = txtDepartmentType.Text;
			if (strDepartmentType == "") {
				Function.showMessage("科室类型为空", txtDepartmentType);

				return;
			}

			bool bolIsPass = chkIsPass.Checked;

			Hashtable ht = new Hashtable();

			ht.Add("id", intId);
			ht.Add("departmentType", strDepartmentType);
			ht.Add("isPass", bolIsPass);

			if (new ModDepartmentType().setSave(ht) == 0) {
				Function.showMessage("操作失败");
			} else {
				Function.showMessage("操作成功");

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}
		//****************************************************************************************************
	}
}
