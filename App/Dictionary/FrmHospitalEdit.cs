using CCWin;
using App.Common;
using App.Model;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace App.Dictionary {
	public partial class FrmHospitalEdit : CCSkinMain {
		private int intId;
		//****************************************************************************************************
		public FrmHospitalEdit(int intId) {
			InitializeComponent();

			this.intId = intId;
		}
		//****************************************************************************************************
		//加载
		private void FrmHospitalEdit_Load(object sender, EventArgs e) {
			if (intId == 0) {
				this.Text = "添加" + this.Text;
			} else {
				this.Text = "修改" + this.Text;

				DataRow dr = new ModHospital().setWhere("id > 0", true).getFind(intId);
				if (dr == null) {
					Function.showMessage("记录为空");
					this.Close();
				} else {
					txtHospitalCode.Text = dr["hospitalCode"].ToString();
					txtHospitalName.Text = dr["hospitalName"].ToString();
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
			string strHospitalCode = txtHospitalCode.Text;
			if (strHospitalCode == "") {
				Function.showMessage("院区编号为空", txtHospitalCode);

				return;
			}

			string strHospitalName = txtHospitalName.Text;
			if (strHospitalName == "") {
				Function.showMessage("院区名称为空", txtHospitalName);

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
			ht.Add("hospitalCode", strHospitalCode);
			ht.Add("hospitalName", strHospitalName);
			ht.Add("spell", strSpell);
			ht.Add("isPass", bolIsPass);
			
			int intRow = new ModHospital().setSave(ht);
			if (intRow == 0) {
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
