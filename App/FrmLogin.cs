using CCWin;
using App.Common;
using App.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace App {
	public partial class FrmLogin : CCSkinMain {
		//****************************************************************************************************
		public FrmLogin() {
			InitializeComponent();
		}
		//****************************************************************************************************
		//加载
		private void FrmLogin_Load(object sender, EventArgs e) {
			cmbDepartmentId.SelectedIndex = 0;
		}
		//****************************************************************************************************
		//员工登录
		private void btnLogin_Click(object sender, EventArgs e) {
			if (txtUsername.Text == "") {
				Function.showMessage("用户名为空", txtUsername);
				
				return;
			}

			if (txtPassword.Text == "") {
				Function.showMessage("密码为空", txtPassword);
				
				return;
			}

			//if (cmbDepartmentId.SelectedValue.ToString() == "0") {
			//    MessageBox.Show("请选择科室！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			//    cmbDepartmentId.Focus();

			//    return;
			//}

			DataRow dr = new ModWorker().setWhere("(isPass = 1) and (username = '" + txtUsername.Text + "') and (password = '" + txtPassword.Text + "')").getFind();
			if (dr == null) {
				Function.showMessage("用户名、密码错误或该账号禁用");
			} else {
				Program.intWorkerId = int.Parse(dr["id"].ToString());
				Program.strUsername = dr["username"].ToString();
				Program.strRealname = dr["realname"].ToString();

				FrmMain frmMain = new FrmMain();
				frmMain.Show();

				this.Hide();
			}
		}
		//****************************************************************************************************
		//退出程序
		private void btnExit_Click(object sender, EventArgs e) {
			Application.Exit();
		}
		//****************************************************************************************************
		//关闭程序
		private void frmLogin_FormClosed(object sender, FormClosedEventArgs e) {
			Application.Exit();
		}
		//****************************************************************************************************
	}
}
