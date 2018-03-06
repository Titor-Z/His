using App.Common;
using App.Model;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace App.Reserver {
	public partial class FrmReserverEdit : Form {
		private int intId;
		//****************************************************************************************************
		public FrmReserverEdit(int intId) {
			InitializeComponent();

			this.intId = intId;
		}
		//****************************************************************************************************
		//加载
		private void FrmReserverEdit_Load(object sender, EventArgs e) {
			if (intId == 0) {
				ParseCombobox.setWorker(cmbReserverWorkerId);
				ParseCombobox.setDepartment(cmbReserverDepartmentId);
				ParseCombobox.setSex(cmbSex);
				ParseCombobox.setUserSource(cmbUserSourceId);
				ParseCombobox.setSmsTemplate(cmbSmsTemplateId);
				ParseCombobox.setRemarkTemplate(cmbRemarkTemplateId);
			} else {
				DataRow dr = new ModReserver().getFind(intId);
				if (dr == null) {
					Function.showMessage("记录为空");
				} else {
					txtRealname.Text = dr["realname"].ToString();
					txtTel.Text = dr["tel"].ToString();
					txtReserverCode.Text = dr["ReserverCode"].ToString();
					nudAge.Value = Convert.ToInt32(dr["age"]);
					txtWechat.Text = dr["wechat"].ToString();
					txtReserverContent.Text = dr["reserverContent"].ToString();
					txtRemark.Text = dr["remark"].ToString();
					txtVisitContent.Text = dr["visitContent"].ToString();
					dtpReserverDate.Value = Function.getDate(dr["reserverDate"]);
					dtpVisitDate.Value = Function.getDate(dr["visitDate"]);
					ParseCombobox.setWorker(cmbReserverWorkerId, dr["reserverWorkerId"]);
					ParseCombobox.setDepartment(cmbReserverDepartmentId, dr["reserverDepartmentId"]);
					ParseCombobox.setSex(cmbSex, dr["sex"]);
					ParseCombobox.setUserSource(cmbUserSourceId, dr["userSourceId"]);
					ParseCombobox.setSmsTemplate(cmbSmsTemplateId, dr["smsTemplateId"]);
					ParseCombobox.setRemarkTemplate(cmbRemarkTemplateId, dr["remarkTemplateId"]);
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
			int intReserverWorkerId = Convert.ToInt32(cmbReserverWorkerId.SelectedValue);
			if (intReserverWorkerId == 0) {
				Function.showMessage("请选择接待员工", cmbReserverWorkerId);

				return;
			}

			int intReserverDepartmentId = Convert.ToInt32(cmbReserverDepartmentId.SelectedValue);
			if (intReserverDepartmentId == 0) {
				Function.showMessage("请选择预约科室", cmbReserverDepartmentId);

				return;
			}

			string strRealname = txtRealname.Text;
			if (strRealname == "") {
				Function.showMessage("患者姓名为空", txtRealname);

				return;
			}

			string strSex = cmbSex.SelectedValue.ToString();
			if (strSex == "") {
				Function.showMessage("请选择性别", cmbSex);
				
				return;
			}

			string strTel = txtTel.Text;
			if (strTel == "") {
				Function.showMessage("联系电话为空", txtTel);

				return;
			}

			string strReserverCode = txtReserverCode.Text;
			if (strReserverCode == "") {
				Function.showMessage("预约号为空", txtReserverCode);
				return;
			}

			int intAge = Convert.ToInt32(nudAge.Value);

			int intUserSourceId = Convert.ToInt32(cmbUserSourceId.SelectedValue);
			if (intUserSourceId == 0) {
				Function.showMessage("请选择患者来源", cmbUserSourceId);

				return;
			}

			string strWechat = txtWechat.Text;
			int intSmsTemplateId = Convert.ToInt32(cmbSmsTemplateId.SelectedValue);
			int intRemarkTemplateid = Convert.ToInt32(cmbRemarkTemplateId.SelectedValue);

			Int64 intReserverDate = Function.getTimeStamp(dtpReserverDate.Value);
			Int64 intVisitDate = Function.getTimeStamp(dtpVisitDate.Value);

			string strReserverContent = txtReserverContent.Text;
			string strRemark = txtRemark.Text;
			string strVisitContent = txtVisitContent.Text;

			Hashtable ht = new Hashtable();

			ht.Add("id", intId);
			ht.Add("reserverWorkerId", intReserverWorkerId);
			ht.Add("reserverDepartmentId", intReserverDepartmentId);
			ht.Add("realname", strRealname);
			ht.Add("sex", strSex);
			ht.Add("tel", strTel);
			ht.Add("reserverCode", strReserverCode);
			ht.Add("age", intAge);
			ht.Add("userSourceId", intUserSourceId);
			ht.Add("wechat", strWechat);
			ht.Add("smsTemplateId", intSmsTemplateId);
			ht.Add("remarkTemplateid", intRemarkTemplateid);
			ht.Add("reserverDate", intReserverDate);
			ht.Add("visitDate", intVisitDate);
			ht.Add("reserverContent", strReserverContent);
			ht.Add("remark", strRemark);
			ht.Add("visitContent", strVisitContent);

			if (new ModReserver().setSave(ht) == 0) {
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
