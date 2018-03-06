using CCWin;
using App.Common;
using App.Model;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace App.Dictionary {
	public partial class FrmRegisterTypeEdit : CCSkinMain {
		private int intId;
		//****************************************************************************************************
		public FrmRegisterTypeEdit(int intId) {
			InitializeComponent();

			this.intId = intId;
		}
		//****************************************************************************************************
		//加载
		private void FrmRegisterTypeEdit_Load(object sender, EventArgs e) {
			if (intId == 0) {
				this.Text = "添加" + this.Text;
			} else {
				this.Text = "修改" + this.Text;

				DataRow dr = new ModRegisterType().setWhere("id > 0", true).getFind(intId);
				if (dr == null) {
					Function.showMessage("记录为空");
					this.Close();
				} else {
					txtRegisterType.Text = dr["registerType"].ToString();
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
			string strRegisterType = txtRegisterType.Text;
			if (strRegisterType == "") {
				Function.showMessage("挂号类型为空", txtRegisterType);

				return;
			}

			bool bolIsPass = chkIsPass.Checked;

			Hashtable ht = new Hashtable();
			ht.Add("id", intId);
			ht.Add("registerType", strRegisterType);
			ht.Add("isPass", bolIsPass);

			if (new ModRegisterType().setSave(ht) == 0) {
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
