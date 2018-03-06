using App.Common;
using App.Model;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace App.Guidance {
	public partial class FrmCardEdit : Form {
		private int intId;
		//****************************************************************************************************
		public FrmCardEdit(int intId) {
			InitializeComponent();

			this.intId = intId;
		}
		//****************************************************************************************************
		//加载
		private void FrmCardEdit_Load(object sender, EventArgs e) {
			if (intId == 0) {
				ParseCombobox.setUserLevel(cmbUserLevelId);
				ParseCombobox.setRegisterType(cmbRegisterTypeId);
				ParseCombobox.setSex(cmbSex);
				ParseCombobox.setCertificateType(cmbCertificateTypeId);
				ParseCombobox.setNation(cmbNation);
				ParseCombobox.setUserType(cmbUserTypeId);
				ParseCombobox.setJobType(cmbJobTypeId);
				ParseCombobox.setBlood(cmbBlood);
				ParseCombobox.setMarital(cmbMarital);
				ParseCombobox.setRelation(cmbLinkmanRelationId);
				ParseCombobox.setUserSource(cmbUserSourceId);
				ParseCombobox.setWorker(cmbHospitalWorkerId);
				ParseCombobox.setWorker(cmbReserverWorkerId);
				ParseCombobox.setDepartment(cmbReserverDepartmentId);
			} else {
				DataRow dr = new ModCard().getFind(intId);
				if (dr == null) {
					Function.showMessage("记录为空");
				} else {
					txtCardCode.Text = dr["cardCode"].ToString();
					txtUserCode.Text = dr["userCode"].ToString();
					txtRealname.Text = dr["realname"].ToString();
					txtCertificateCode.Text = dr["certificateCode"].ToString();
					dtpBirthday.Value = Function.getDate(dr["birthday"]);
					nudAge.Value = Convert.ToInt32(dr["age"].ToString());
					txtTel.Text = dr["tel"].ToString();
					txtPost.Text = dr["post"].ToString();
					txtLinkman.Text = dr["linkman"].ToString();
					txtLinkmanTel.Text = dr["linkmanTel"].ToString();
					//Province
					//City
					//County
					txtAddress.Text = dr["address"].ToString();
					txtHospitalWorkerContent.Text = dr["hospitalWorkerContent"].ToString();
					txtReserverCode.Text = dr["reserverCode"].ToString();
					txtAllergicHistory.Text = dr["allergicHistory"].ToString();
					txtContent.Text = dr["content"].ToString();

					ParseCombobox.setUserLevel(cmbUserLevelId, dr["userLevelId"]);
					ParseCombobox.setRegisterType(cmbRegisterTypeId, dr["registerTypeId"]);
					ParseCombobox.setSex(cmbSex, dr["sex"]);
					ParseCombobox.setCertificateType(cmbCertificateTypeId, dr["certificateTypeId"]);
					ParseCombobox.setNation(cmbNation, dr["nation"]);
					ParseCombobox.setUserType(cmbUserTypeId, dr["userTypeId"]);
					ParseCombobox.setJobType(cmbJobTypeId, dr["jobTypeId"]);
					ParseCombobox.setBlood(cmbBlood, dr["blood"]);
					ParseCombobox.setMarital(cmbMarital, dr["marital"]);
					ParseCombobox.setRelation(cmbLinkmanRelationId, dr["linkmanRelationId"]);
					ParseCombobox.setUserSource(cmbUserSourceId, dr["userSourceId"]);
					ParseCombobox.setWorker(cmbHospitalWorkerId, dr["hospitalWorkerId"]);
					ParseCombobox.setWorker(cmbReserverWorkerId, dr["reserverWorkerId"]);
					ParseCombobox.setDepartment(cmbReserverDepartmentId, dr["reserverDepartmentId"]);
				}
			}
		}
		//****************************************************************************************************
		//关闭
		private void btnClose_Click(object sender, EventArgs e) {
			this.Close();
		}
		//****************************************************************************************************
		private void btnSave_Click(object sender, EventArgs e) {
			string strCardCode = txtCardCode.Text;
			if (strCardCode == "") {
				Function.showMessage("卡号为空", txtCardCode);

				return;
			}

			string strUserCode = txtUserCode.Text;
			if (strUserCode == "") {
				Function.showMessage("病历号为空", txtUserCode);

				return;
			}

			int intUserLevelId = Convert.ToInt32(cmbUserLevelId.SelectedValue);
			if (intUserLevelId == 0) {
				Function.showMessage("请选择会员级别", cmbUserLevelId);

				return;
			}

			int intRegisterTypeId = Convert.ToInt32(cmbRegisterTypeId.SelectedValue);
			if (intRegisterTypeId == 0) {
				Function.showMessage("请选择挂号类型", cmbRegisterTypeId);

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

			int intCertificateTypeId = Convert.ToInt32(cmbCertificateTypeId.SelectedValue);
			string strCertificateCode = txtCertificateCode.Text;
			long intBirthday = Function.getTimeStamp(dtpBirthday.Value);
			int intAge = Convert.ToInt32(nudAge.Value);
			string strTel = txtTel.Text;
			string strNation = cmbNation.SelectedValue.ToString();
			int intUserTypeId = Convert.ToInt32(cmbUserTypeId.SelectedValue);
			int intJobTypeId = Convert.ToInt32(cmbJobTypeId.SelectedValue);
			string strBlood = cmbBlood.SelectedValue.ToString();
			string strMarital = cmbMarital.SelectedValue.ToString();
			string strPost = txtPost.Text;
			string strLinkman = txtLinkman.Text;
			string strLinkmanTel = txtLinkmanTel.Text;
			int intLinkmanRelationId = Convert.ToInt32(cmbLinkmanRelationId.SelectedValue);

			//string strProvince = cmbProvince.SelectedValue.ToString();
			//string strCity = cmbCity.SelectedValue.ToString();
			//string strCounty = cmbCounty.SelectedValue.ToString();
			string strProvince = "";
			string strCity = "";
			string strCounty = "";
			
			string strAddress = txtAddress.Text;
			int intUserSourceId = Convert.ToInt32(cmbUserSourceId.SelectedValue);
			int intHospitalWorkerId = Convert.ToInt32(cmbHospitalWorkerId.SelectedValue);
			string strHospitalWorkerContent = txtHospitalWorkerContent.Text;
			string strReserverCode = txtReserverCode.Text;
			int intReserverWorkerId = Convert.ToInt32(cmbReserverWorkerId.SelectedValue);
			int intReserverDepartmentId = Convert.ToInt32(cmbReserverDepartmentId.SelectedValue);
			string strAllergicHistory = txtAllergicHistory.Text;
			string strContent = txtContent.Text;
			
			Hashtable ht = new Hashtable();
			ht.Add("id", intId);
			ht.Add("cardCode", strCardCode);
			ht.Add("userCode", strUserCode);
			ht.Add("userLevelId", intUserLevelId);
			ht.Add("registerTypeId", intRegisterTypeId);
			ht.Add("realname", strRealname);
			ht.Add("sex", strSex);
			ht.Add("certificateTypeId", intCertificateTypeId);
			ht.Add("certificateCode", strCertificateCode);
			ht.Add("birthday", intBirthday);
			ht.Add("age", intAge);
			ht.Add("tel", strTel);
			ht.Add("nation", strNation);
			ht.Add("userTypeId", intUserTypeId);
			ht.Add("jobTypeId", intJobTypeId);
			ht.Add("blood", strBlood);
			ht.Add("marital", strMarital);
			ht.Add("post", strPost);
			ht.Add("linkman", strLinkman);
			ht.Add("linkmanTel", strLinkmanTel);
			ht.Add("linkmanRelationId", intLinkmanRelationId);
			ht.Add("province", strProvince);
			ht.Add("city", strCity);
			ht.Add("county", strCounty);
			ht.Add("address", strAddress);
			ht.Add("userSourceId", intUserSourceId);
			ht.Add("hospitalWorkerId", intHospitalWorkerId);
			ht.Add("hospitalWorkerContent", strHospitalWorkerContent);
			ht.Add("reserverCode", strReserverCode);
			ht.Add("reserverWorkerId", intReserverWorkerId);
			ht.Add("reserverDepartmentId", intReserverDepartmentId);
			ht.Add("allergicHistory", strAllergicHistory);
			ht.Add("content", strContent);

			if (new ModCard().setSave(ht) == 0) {
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
