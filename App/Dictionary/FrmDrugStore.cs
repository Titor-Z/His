using App.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App.Dictionary {
	public partial class FrmDrugStore:Form {
		private int intId;
		//*******************************************************************************
		public FrmDrugStore() {
			InitializeComponent();
		}
		//*******************************************************************************
		private void FrmDrugStore_Load(object sender, EventArgs e) {
			showData();
		}
		//*******************************************************************************
		private void showData() {
			drugStore.AutoGenerateColumns = false;
			DataTable dt = new ModDrugStore().getSelect();
			if (dt == null) {
				button2.Enabled = false;
			}
			drugStore.DataSource = dt;
		}
		//*******************************************************************************
		private void edit() {
			FrmDrugStoreEdit edit = new FrmDrugStoreEdit(this.intId);
			if (edit.ShowDialog() == DialogResult.OK) {
				showData();
			}
		}
		//*******************************************************************************
		private void button1_Click(object sender, EventArgs e) {
			this.intId = 0;
			edit();
		}
		//*******************************************************************************
		private void button2_Click(object sender, EventArgs e) {
			int id = Convert.ToInt32(drugStore.CurrentRow.Cells["id"].Value);
			this.intId = id;
			edit();
		}
		//*******************************************************************************
	}
}
