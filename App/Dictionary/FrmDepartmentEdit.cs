using CCWin;
using App.Common;
using App.Model;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace App.Dictionary {
	public partial class FrmDepartmentEdit : CCSkinMain {
		private int intId;
		//****************************************************************************************************
		public FrmDepartmentEdit(int intId) {
			InitializeComponent();

			this.intId = intId;
		}
		//****************************************************************************************************
		//加载
		private void FrmDepartmentEdit_Load(object sender, EventArgs e) {
			if (intId == 0) {
				this.Text = "添加" + this.Text;

				ParseCombobox.setHospital(cmbHospitalId);
				ParseCombobox.setDepartmentType(cmbDepartmentTypeId);
			} else {
				this.Text = "修改" + this.Text;
				
				DataRow dr = new ModDepartment().setWhere("id > 0", true).getFind(intId);
				if (dr == null) {
					Function.showMessage("记录为空");
					this.Close();
				} else {
					txtDepartmentCode.Text = dr["departmentCode"].ToString();
					txtDepartmentName.Text = dr["departmentName"].ToString();
					txtSpell.Text = dr["spell"].ToString();
					chkIsPass.Checked = Convert.ToBoolean(dr["isPass"]);

					ParseCombobox.setHospital(cmbHospitalId, dr["hospitalId"]);
					ParseCombobox.setDepartmentType(cmbDepartmentTypeId, dr["departmentTypeId"]);
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
			int intHospitalId = Convert.ToInt32(cmbHospitalId.SelectedValue);
			if (intHospitalId == 0) {
				Function.showMessage("请选择所属院区");

				return;
			}

			int intDepartmentTypeId = Convert.ToInt32(cmbDepartmentTypeId.SelectedValue);
			if (intDepartmentTypeId == 0) {
				Function.showMessage("请选择科室类型");

				return;
			}

			string strDepartmentCode = txtDepartmentCode.Text;
			if (strDepartmentCode == "") {
				Function.showMessage("科室编号为空", txtDepartmentCode);
				
				return;
			}

			string strDepartmentName = txtDepartmentName.Text;
			if (strDepartmentName == "") {
				Function.showMessage("科室名称为空", txtDepartmentName);
				
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
			ht.Add("hospitalId", intHospitalId);
			ht.Add("departmentTypeId", intDepartmentTypeId);
			ht.Add("departmentCode", strDepartmentCode);
			ht.Add("departmentName", strDepartmentName);
			ht.Add("spell", strSpell);
			ht.Add("isPass", bolIsPass);

			if (new ModDepartment().setSave(ht) == 0) {
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
