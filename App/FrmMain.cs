using App.Dictionary;
using App.Guidance;
using App.Model;
using App.Reserver;
using CCWin;
using Newtonsoft.Json.Linq;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace App {
	public partial class FrmMain : CCSkinMain {
		//****************************************************************************************************
		public FrmMain() {
			InitializeComponent();
		}
		//****************************************************************************************************
		//加载
		private void FrmMain_Load(object sender, EventArgs e) {
			this.Text = Program.strAppTitle + this.Text;

			//任务栏
			tspInfo.Text = Program.strRealname + "-" + Program.strRealname + "-" + Program.strRealname;

			//遍历 菜单json
			JToken jtMenu = JToken.Parse(ClsMenu.strMenu);
			foreach (JProperty jpMenu in jtMenu) {
				ToolStripMenuItem mnuMain = new ToolStripMenuItem();
				mnuMain.Text = jpMenu.Name;
				mnuApp.Items.Add(mnuMain);

				if (jpMenu.Value.GetType().ToString() == "Newtonsoft.Json.Linq.JObject") {
					JToken jtMain = jpMenu.Value;

					mnuMain.Tag = jtMain["menuClass"];
					mnuMain.Click += Menu_Click;
				} else {
					foreach (JToken jtSub in jpMenu.Value) {
						ToolStripMenuItem mnuSub = new ToolStripMenuItem();
						mnuSub.Text = jtSub["menuName"].ToString();
						mnuSub.Tag = jtSub["menuClass"];
						mnuSub.Click += Menu_Click;
						mnuMain.DropDownItems.Add(mnuSub);
					}
				}
			}
		}
		//****************************************************************************************************
		//打开子菜单
		private void Menu_Click(object sender, EventArgs e) {
			//动态生成窗体
			Assembly assm = Assembly.GetAssembly(this.GetType());
			ToolStripMenuItem mnu = sender as ToolStripMenuItem;
			Form frm = (Form)assm.CreateInstance("App." + mnu.Tag.ToString());

			//通过反射获取 tabForm 属性
			Type type = frm.GetType();
			PropertyInfo propertyInfo = type.GetProperty("tabForm");
			if (propertyInfo == null) {
				frm.ShowDialog();
			} else {
				int intIndex = -1;
				string strMenuName = mnu.Text;

				for (int i = 0; i < tab.TabPages.Count; i++) {
					if (tab.TabPages[i].Text == strMenuName) {
						intIndex = i;
					}
				}

				if (intIndex == -1) {
					intIndex = tab.TabPages.Count;

					tab.TabPages.Add(strMenuName);
					tab.SelectTab(intIndex);
					
					frm.Dock = DockStyle.Fill;
					frm.TopLevel = false;
					frm.Parent = tab.TabPages[intIndex];
					propertyInfo.SetValue(frm, this, null);

					frm.Show();
				} else {
					frm.Dispose();

					tab.SelectTab(intIndex);
				}
			}
		}
		//****************************************************************************************************
		//删除 tab 标签
		public void removeTabItem() {
			tab.TabPages.RemoveAt(tab.SelectedIndex);
		}
		//****************************************************************************************************
		//时间
		private void tmr_Tick(object sender, EventArgs e) {
			tspTime.Text = "当前时间：" + Convert.ToString(System.DateTime.Now);
		}
		//****************************************************************************************************
		//退出程序
		private void frmMain_FormClosed(object sender, FormClosedEventArgs e) {
			Application.Exit();
		}
		//****************************************************************************************************
	}
}
