using CCWin;
using App.Common;
using App.Model;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace App.Dictionary {
	public partial class FrmSmsTemplateEdit : CCSkinMain {
		private int intId;
		//****************************************************************************************************
		public FrmSmsTemplateEdit(int intId) {
			InitializeComponent();

			this.intId = intId;
		}
		//****************************************************************************************************
		//加载
		private void FrmSmsTemplateEdit_Load(object sender, EventArgs e) {
			if (intId == 0) {
				this.Text = "添加" + this.Text;
			} else {
				this.Text = "修改" + this.Text;

				DataRow dr = new ModSmsTemplate().setWhere("id > 0", true).getFind(intId);
				if (dr == null) {
					Function.showMessage("记录为空");
					this.Close();
				} else {
					txtTemplateName.Text = dr["templateName"].ToString();
					txtContent.Text = dr["content"].ToString();
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
			string strTemplateName = txtTemplateName.Text;
			if (strTemplateName == "") {
				Function.showMessage("模板名称为空", txtTemplateName);

				return;
			}

			string strContent = txtContent.Text;
			if (strContent == "") {
				Function.showMessage("科室名称为空", txtContent);

				return;
			}

			bool bolIsPass = chkIsPass.Checked;

			Hashtable ht = new Hashtable();
			ht.Add("id", intId);
			ht.Add("templateName", strTemplateName);
			ht.Add("content", strContent);
			ht.Add("isPass", bolIsPass);

			if (new ModSmsTemplate().setSave(ht) == 0) {
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
