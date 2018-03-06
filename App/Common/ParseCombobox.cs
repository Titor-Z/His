using App.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace App.Common {
	class ParseCombobox {
		//****************************************************************************************************
		//性别
		public static void setSex(ComboBox cmb, Object value = null) {
			DataTable dt = new DataTable();
			
			DataColumn dcText = new DataColumn("text");
			DataColumn dcValue = new DataColumn("value");

			dt.Columns.Add(dcText);
			dt.Columns.Add(dcValue);

			string[] arr = { "", "男", "女" };
			foreach (string val in arr) {
				DataRow dr = dt.NewRow();

				if (val == "") {
					dr["text"] = "--请选择性别--";
				} else {
					dr["text"] = val;
				}

				dr["value"] = val;

				dt.Rows.Add(dr);
			}

			cmb.DataSource = dt;
			cmb.DisplayMember = "text";
			cmb.ValueMember = "value";

			if (value == null) {
				cmb.SelectedValue = "";
			} else {
				cmb.SelectedValue = value.ToString();
			}
		}
		//****************************************************************************************************
		//婚姻状况
		public static void setMarital(ComboBox cmb, Object value = null) {
			DataTable dt = new DataTable();

			DataColumn dcText = new DataColumn("text");
			DataColumn dcValue = new DataColumn("value");

			dt.Columns.Add(dcText);
			dt.Columns.Add(dcValue);

			string[] arr = { "", "已婚", "未婚", "离异" };
			foreach (string val in arr) {
				DataRow dr = dt.NewRow();

				if (val == "") {
					dr["text"] = "--请选择婚姻状况--";
				} else {
					dr["text"] = val;
				}

				dr["value"] = val;

				dt.Rows.Add(dr);
			}

			cmb.DataSource = dt;
			cmb.DisplayMember = "text";
			cmb.ValueMember = "value";

			if (value == null) {
				cmb.SelectedValue = "";
			} else {
				cmb.SelectedValue = value.ToString();
			}
		}
		//****************************************************************************************************
		//血型
		public static void setBlood(ComboBox cmb, Object value = null) {
			DataTable dt = new DataTable();

			DataColumn dcText = new DataColumn("text");
			DataColumn dcValue = new DataColumn("value");

			dt.Columns.Add(dcText);
			dt.Columns.Add(dcValue);

			string[] arr = { "", "A型", "B型", "AB型", "O型", "Rh型" };
			foreach (string val in arr) {
				DataRow dr = dt.NewRow();

				if (val == "") {
					dr["text"] = "--请选择血型--";
				} else {
					dr["text"] = val;
				}

				dr["value"] = val;

				dt.Rows.Add(dr);
			}

			cmb.DataSource = dt;
			cmb.DisplayMember = "text";
			cmb.ValueMember = "value";

			if (value == null) {
				cmb.SelectedValue = "";
			} else {
				cmb.SelectedValue = value.ToString();
			}
		}
		//****************************************************************************************************
		//民族
		public static void setNation(ComboBox cmb, Object value = null) {
			DataTable dt = new DataTable();

			DataColumn dcText = new DataColumn("text");
			DataColumn dcValue = new DataColumn("value");

			dt.Columns.Add(dcText);
			dt.Columns.Add(dcValue);

			string[] arr = { "", "汉族", "回族", "满族", "蒙古族", "藏族", "维吾尔族", "苗族", "彝族", "壮族", "布依族", "朝鲜族", "侗族", "瑶族", "白族", "土家族", "哈尼族", "哈萨克族", "傣族", "黎族", "僳僳族", "佤族", "畲族", "高山族", "拉祜族", "水族", "东乡族", "纳西族", "景颇族", "柯尔克孜族", "土族", "达斡尔族", "仫佬族", "羌族", "布朗族", "撒拉族", "毛南族", "仡佬族", "锡伯族", "阿昌族", "普米族", "塔吉克族", "怒族", "乌孜别克族", "俄罗斯族", "鄂温克族", "德昂族", "保安族", "裕固族", "京族", "塔塔尔族", "独龙族", "鄂伦春族", "赫哲族", "门巴族", "珞巴族", "基诺族" };
			foreach (string val in arr) {
				DataRow dr = dt.NewRow();

				if (val == "") {
					dr["text"] = "--请选择民族--";
				} else {
					dr["text"] = val;
				}

				dr["value"] = val;

				dt.Rows.Add(dr);
			}

			cmb.DataSource = dt;
			cmb.DisplayMember = "text";
			cmb.ValueMember = "value";

			if (value == null) {
				cmb.SelectedValue = "";
			} else {
				cmb.SelectedValue = value.ToString();
			}
		}
		//****************************************************************************************************
		//院区
		public static void setHospital(ComboBox cmb, Object value = null) {
			DataTable dt = new ModHospital().getSelect();

			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["hospitalName"] = "--请选择院区--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "hospitalName";

			cmb.SelectedValue = Convert.ToInt32(value);
		}
		//****************************************************************************************************
		//科室类型
		public static void setDepartmentType(ComboBox cmb, Object value = null) {
			DataTable dt = new ModDepartmentType().getSelect();

			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["departmentType"] = "--请选择科室类型--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "departmentType";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//科室
		public static void setDepartment(ComboBox cmb, Object value = null) {
			DataTable dt = new ModDepartment().getSelect();

			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["departmentName"] = "--请选择科室--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "departmentName";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//员工类型
		public static void setWorkerType(ComboBox cmb, Object value = null) {
			DataTable dt = new ModWorkerType().getSelect();

			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["workerType"] = "--请选择员工类型--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "workerType";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//员工
		public static void setWorker(ComboBox cmb, Object value = null) {
			DataTable dt = new ModWorker().getSelect();

			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["realname"] = "--请选择员工--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "realname";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//会员级别
		public static void setUserLevel(ComboBox cmb, Object value = null) {
			DataTable dt = new ModUserLevel().getSelect();

			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["userLevel"] = "--请选择会员级别--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "userLevel";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//患者来源
		public static void setUserSource(ComboBox cmb, Object value = null) {
			DataTable dt = new ModUserSource().getSelect();

			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["userSource"] = "--请选择患者来源--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "userSource";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//患者类型
		public static void setUserType(ComboBox cmb, Object value = null) {
			DataTable dt = new ModUserType().getSelect();

			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["userType"] = "--请选择患者类型--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "userType";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//职业类型
		public static void setJobType(ComboBox cmb, Object value = null) {
			DataTable dt = new ModJobType().getSelect();

			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["jobType"] = "--请选择职业类型--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "jobType";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//证件类型
		public static void setCertificateType(ComboBox cmb, Object value = null) {
			DataTable dt = new ModCertificateType().getSelect();

			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["certificateType"] = "--请选择证件类型--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "certificateType";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//联系人关系
		public static void setRelation(ComboBox cmb, Object value = null) {
			DataTable dt = new ModRelation().getSelect();

			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["relationName"] = "--请选择联系人关系--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "relationName";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//短信模板
		public static void setSmsTemplate(ComboBox cmb, Object value = null) {
			DataTable dt = new ModSmsTemplate().getSelect();

			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["templateName"] = "--请选择短信模板--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "templateName";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//话术模板
		public static void setSayTemplate(ComboBox cmb, Object value = null) {
			DataTable dt = new ModSayTemplate().getSelect();

			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["templateName"] = "--请选择话术模板--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "templateName";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//备注模板
		public static void setRemarkTemplate(ComboBox cmb, Object value = null) {
			DataTable dt = new ModRemarkTemplate().getSelect();

			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["templateName"] = "--请选择备注模板--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "templateName";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//挂号类型
		public static void setRegisterType(ComboBox cmb, Object value = null) {
			DataTable dt = new ModRegisterType().getSelect();

			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["registerType"] = "--挂号类型--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "registerType";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
	}
}
