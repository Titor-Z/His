using CCWin;
using App.Common;
using App.Model;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace App.Dictionary {
	public partial class FrmWorkerEdit : CCSkinMain {
		private int intId;
		//****************************************************************************************************
		public FrmWorkerEdit(int intId) {
			InitializeComponent();

			this.intId = intId;
		}
		//****************************************************************************************************
		//加载
		private void FrmWorkerEdit_Load(object sender, EventArgs e) {
			if (intId == 0) {
				this.Text = "添加" + this.Text;

				ParseCombobox.setDepartment(cmbDepartmentId);
				ParseCombobox.setWorkerType(cmbWorkerTypeId);
				ParseCombobox.setSex(cmbSex);
			} else {
				this.Text = "修改" + this.Text;
				
				DataRow dr = new ModWorker().setWhere("id > 0", true).getFind(intId);
				if (dr == null) {
					Function.showMessage("记录为空");
					this.Close();
				} else {
					txtUsername.Enabled = false;
					chkIsPass.Checked = Convert.ToBoolean(dr["isPass"]);

					txtUsername.Text = dr["username"].ToString();
					txtPassword.Text = dr["password"].ToString();
					txtWorkerCode.Text = dr["workerCode"].ToString();
					txtRealname.Text = dr["realname"].ToString();
					txtTel.Text = dr["tel"].ToString();
					txtSpell.Text = dr["spell"].ToString();

					ParseCombobox.setDepartment(cmbDepartmentId, dr["departmentId"]);
					ParseCombobox.setWorkerType(cmbWorkerTypeId, dr["workerTypeId"]);
					ParseCombobox.setSex(cmbSex, dr["sex"].ToString());
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
			string strUsername = txtUsername.Text;
			if (strUsername == "") {
				Function.showMessage("登录名为空", txtUsername);
				
				return;
			}

			string strPassword = txtPassword.Text;
			if (strPassword == "") {
				Function.showMessage("密码为空", txtPassword);
				
				return;
			}

			int intDepartmentId = Convert.ToInt32(cmbDepartmentId.SelectedValue);
			if (intDepartmentId == 0) {
				Function.showMessage("请选择科室");

				return;
			}

			int intWorkerTypeId = Convert.ToInt32(cmbWorkerTypeId.SelectedValue);
			if (intWorkerTypeId == 0) {
				Function.showMessage("请选择员工类型");

				return;
			}

			string strWorkerCode = txtWorkerCode.Text;
			if (strWorkerCode == "") {
				Function.showMessage("员工编号为空", txtWorkerCode);
				
				return;
			}

			string strRealname = txtRealname.Text;
			if (strRealname == "") {
				Function.showMessage("姓名为空", txtRealname);
				
				return;
			}

			string strTel = txtTel.Text;
			string strSpell = txtSpell.Text;
			string strSex = cmbSex.SelectedValue.ToString();
			bool bolIsPass = chkIsPass.Checked;
			
			Hashtable ht = new Hashtable();
			ht.Add("id", intId);
			ht.Add("username", strUsername);
			ht.Add("password", strPassword);
			ht.Add("departmentId", intDepartmentId);
			ht.Add("workerTypeId", intWorkerTypeId);
			ht.Add("workerCode", strWorkerCode);
			ht.Add("realname", strRealname);
			ht.Add("spell", strSpell);
			ht.Add("tel", strTel);
			ht.Add("sex", strSex);
			ht.Add("isPass", bolIsPass);

			if (new ModWorker().setSave(ht) == 0) {
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
