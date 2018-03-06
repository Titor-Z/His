using App.Common;
using System;
using System.Windows.Forms;

namespace App {
	public partial class FrmPassword : Form {
		//****************************************************************************************************
		public FrmPassword() {
			InitializeComponent();
		}
		//****************************************************************************************************
		//关闭
		private void btnClose_Click(object sender, EventArgs e) {
			this.Close();
		}
		//****************************************************************************************************
		//保存
		private void btnSave_Click(object sender, EventArgs e) {
			string strOldPassword = txtOldPassword.Text;
			if (strOldPassword == "") {
				Function.showMessage("旧密码为空", txtOldPassword);
				
				return;
			}

			string strNewPassword = txtNewPassword.Text;
			if (strNewPassword.Length < 6) {
				Function.showMessage("新密码小于 6 位", txtNewPassword);
				
				return;
			}

			string strConfirmPassword = txtConfirmPassword.Text;
			if (strConfirmPassword != strNewPassword) {
				Function.showMessage("两次输入的密码不同", txtConfirmPassword);
				
				return;
			}
		}
		//****************************************************************************************************
	}
}
