using CCWin;
using App.Common;
using App.Model;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace App.Dictionary {
	public partial class FrmEntityEdit : CCSkinMain {
		private int intId;
		//****************************************************************************************************
		public FrmEntityEdit(int intId) {
			InitializeComponent();

			this.intId = intId;
		}
		//****************************************************************************************************
		//加载
		private void FrmEntityEdit_Load(object sender, EventArgs e) {
			if (intId == 0) {
				this.Text = "添加" + this.Text;
			} else {
				this.Text = "修改" + this.Text;

				DataRow dr = new ModEntity().setWhere("id > 0", true).getFind(intId);
				if (dr == null) {
					Function.showMessage("记录为空");
					this.Close();
				} else {
					txtEntityName.Text = dr["entityName"].ToString();
					txtSpell.Text = dr["spell"].ToString();
					chkIsPass.Checked = Convert.ToBoolean(dr["isPass"]);
				}
			}

		}
		//****************************************************************************************************
		//关闭
		private void btnClose_Click(object sender, EventArgs e) {
			this.Close();
		}
		//****************************************************************************************************
		//保存
		private void btnSave_Click(object sender, EventArgs e) {
			string strEntityName = txtEntityName.Text;
			if (strEntityName == "") {
				Function.showMessage("病种名称为空", txtEntityName);

				return;
			}

			string strSpell = txtSpell.Text;
			if (strSpell == "") {
				Function.showMessage("拼音为空", txtSpell);

				return;
			}

			bool bolIsPass = chkIsPass.Checked;

			Hashtable ht = new Hashtable();
			ht.Add("id", intId);
			ht.Add("entityName", strEntityName);
			ht.Add("spell", strSpell);
			ht.Add("isPass", bolIsPass);

			if (new ModEntity().setSave(ht) == 0) {
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
