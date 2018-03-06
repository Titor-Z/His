using App.Common;
using App.Model;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace App.Dictionary {
	public partial class FrmDrugStoreEdit:Form {
		private int intId;
		//*******************************************************************************
		public FrmDrugStoreEdit(int intId) {
			InitializeComponent();

			this.intId = intId;
		}
		//*******************************************************************************
		private void FrmDrugStoreEdit_Load(object sender, EventArgs e) {
			Function.showMessage("记录为空");
			if (this.intId > 0) {
				DataRow dr = new ModDrugStore().getFind(this.intId);
				if (dr == null) {
					Function.showMessage("记录为空");
				} else {
					txtStoreName.Text = dr["storeName"].ToString();
					chkIsPass.Checked = Convert.ToBoolean(dr["isPass"]);
				}
			}
		}
		//*******************************************************************************
		private void button1_Click(object sender, EventArgs e) {
			string strStoreName = txtStoreName.Text;
			if (strStoreName == "") {
				Function.showMessage("药库名称不能为空！", txtStoreName);

				return;
			}
			
			bool bolIsPass = chkIsPass.Checked;

			Hashtable ht = new Hashtable();
			ht.Add("id",this.intId);
			ht.Add("storeName",strStoreName);
			ht.Add("isPass", bolIsPass);
			
			new ModDrugStore().setSave(ht);

			this.Close();
			this.DialogResult = DialogResult.OK;
		}
		//*******************************************************************************
		private void button2_Click(object sender, EventArgs e) {
			this.Close();
		}
		//*******************************************************************************
	}
}
