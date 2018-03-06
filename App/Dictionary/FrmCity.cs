using App.Common;
using App.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace App.Dictionary {
	public partial class FrmCity : Form {
		private DataSet ds = new DataSet();

		//****************************************************************************************************
		public FrmCity() {
			InitializeComponent();
		}
		//****************************************************************************************************
		private void FrmCity_Load(object sender, EventArgs e) {
			//importExcel();
			//addProvince();
			//addCity();
			//addCounty();

			JObject json = (JObject)JsonConvert.DeserializeObject(ClsMenu.strMenu);
			//JArray arr = (JArray)json["rows"];
			
			textBox1.Text = json["字典"][1]["role"].ToString();
		}
		//****************************************************************************************************
		private void MenuCity_Click(object sender, EventArgs e) {
			ToolStripMenuItem mnu = sender as ToolStripMenuItem;

			MessageBox.Show(mnu.Tag.ToString());
		}
		//****************************************************************************************************
		//导入数据
		private void importExcel() {
			string strPath = "H:\\a.爱眼医院\\行政区划清单.xlsx";
			string strConn = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + strPath + "; Extended Properties=Excel 8.0;";
			string strSql = "select * from [Sheet1$]";

			OleDbDataAdapter da = new OleDbDataAdapter(strSql, strConn);
			da.Fill(ds, "table1");
		}
		//****************************************************************************************************
		//添加省
		private void addProvince() {
			foreach (DataRow dr in ds.Tables[0].Rows) {
				if (dr[4].ToString() == "") {
					string strInsert = string.Format("insert into ay_city (cityCode, cityName, spell, firstSpell) values ('{0}', '{1}', '{2}', '{3}')", dr[6], dr[3], ConvertSpell.get(dr[3].ToString()), ConvertSpell.getFirst(dr[3].ToString()));

					int n = new ModCity().getQuery(strInsert);
				}
			}
		}
		//****************************************************************************************************
		//添加市
		private void addCity() {
			foreach (DataRow dr in ds.Tables[0].Rows) {
				if (((dr[4].ToString() != "") && (dr[5].ToString() == "")) || (dr[1].ToString() == "北京市" || dr[1].ToString() == "天津市" || dr[1].ToString() == "上海市" || dr[1].ToString() == "重庆市") && (dr[4].ToString() != "") && (dr[5].ToString() != "")) {
					string strParentId = new ModCity().setWhere("cityCode = '" + dr[4].ToString() + "'").getField("id");
					string strInsert = string.Format("insert into ay_city (parentId, cityCode, cityName, spell, firstSpell) values ({0}, '{1}', '{2}', '{3}', '{4}')", strParentId, dr[6], dr[3], ConvertSpell.get(dr[3].ToString()), ConvertSpell.getFirst(dr[3].ToString()));

					int n = new ModCity().getQuery(strInsert);
				}
			}
		}
		//****************************************************************************************************
		//添加县
		private void addCounty() {
			foreach (DataRow dr in ds.Tables[0].Rows) {
				if (dr[4].ToString() != "" && dr[5].ToString() != "" && dr[6].ToString() != "" && dr[1].ToString() != "北京市" && dr[1].ToString() != "天津市" && dr[1].ToString() != "上海市" && dr[1].ToString() != "重庆市") {
					string strParentId = new ModCity().setWhere("cityCode = '" + dr[5].ToString() + "'").getField("id");
					if (strParentId == "") {
						strParentId = "-1";
					}

					string strInsert = string.Format("insert into ay_city (parentId, cityCode, cityName, spell, firstSpell) values ({0}, '{1}', '{2}', '{3}', '{4}')", strParentId, dr[6], dr[3], ConvertSpell.get(dr[3].ToString()), ConvertSpell.getFirst(dr[3].ToString()));
					int n = new ModCity().getQuery(strInsert);
				}
			}

			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '徐州市' and cityCode = '320300') where parentId = -1 and cityCode = '320402';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '徐州市' and cityCode = '320300') where parentId = -1 and cityCode = '320404';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '徐州市' and cityCode = '320300') where parentId = -1 and cityCode = '320411';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '徐州市' and cityCode = '320300') where parentId = -1 and cityCode = '320412';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '徐州市' and cityCode = '320300') where parentId = -1 and cityCode = '320413';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '徐州市' and cityCode = '320300') where parentId = -1 and cityCode = '320481';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '驻马店市' and cityCode = '411700') where parentId = -1 and cityCode = '419001';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '恩施土家族苗族自治州' and cityCode = '422800') where parentId = -1 and cityCode = '429004';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '潜江市' and cityCode = '429005') where parentId = -1 and cityCode = '429006';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '潜江市' and cityCode = '429005') where parentId = -1 and cityCode = '429021';
			//-- update ay_city set parentId = (select top 1 id from ay_city where cityName = '' and cityCode = '') where parentId = -1 and cityCode = '441900'; --东莞市
			//-- update ay_city set parentId = (select top 1 id from ay_city where cityName = '' and cityCode = '') where parentId = -1 and cityCode = '442000'; --中山市
			//-- update ay_city set parentId = (select top 1 id from ay_city where cityName = '' and cityCode = '') where parentId = -1 and cityCode = '460400'; --儋州市
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '三亚市' and cityCode = '460200') where parentId = -1 and cityCode = '469001';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '琼海市' and cityCode = '469002') where parentId = -1 and cityCode = '469005';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '琼海市' and cityCode = '469002') where parentId = -1 and cityCode = '469006';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '琼海市' and cityCode = '469002') where parentId = -1 and cityCode = '469007';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '琼海市' and cityCode = '469002') where parentId = -1 and cityCode = '469021';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '琼海市' and cityCode = '469002') where parentId = -1 and cityCode = '469022';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '琼海市' and cityCode = '469002') where parentId = -1 and cityCode = '469023';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '琼海市' and cityCode = '469002') where parentId = -1 and cityCode = '469024';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '琼海市' and cityCode = '469002') where parentId = -1 and cityCode = '469025';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '琼海市' and cityCode = '469002') where parentId = -1 and cityCode = '469026';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '琼海市' and cityCode = '469002') where parentId = -1 and cityCode = '469027';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '琼海市' and cityCode = '469002') where parentId = -1 and cityCode = '469028';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '琼海市' and cityCode = '469002') where parentId = -1 and cityCode = '469029';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '琼海市' and cityCode = '469002') where parentId = -1 and cityCode = '469030';
			//-- update ay_city set parentId = (select top 1 id from ay_city where cityName = '' and cityCode = '') where parentId = -1 and cityCode = '620201'; --嘉峪关市
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '武威市' and cityCode = '620600') where parentId = -1 and cityCode = '620702';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '武威市' and cityCode = '620600') where parentId = -1 and cityCode = '620721';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '武威市' and cityCode = '620600') where parentId = -1 and cityCode = '620722';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '武威市' and cityCode = '620600') where parentId = -1 and cityCode = '620723';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '武威市' and cityCode = '620600') where parentId = -1 and cityCode = '620724';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '武威市' and cityCode = '620600') where parentId = -1 and cityCode = '620725';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '海北藏族自治州' and cityCode = '632200') where parentId = -1 and cityCode = '632321';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '海北藏族自治州' and cityCode = '632200') where parentId = -1 and cityCode = '632322';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '海北藏族自治州' and cityCode = '632200') where parentId = -1 and cityCode = '632323';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '海北藏族自治州' and cityCode = '632200') where parentId = -1 and cityCode = '632324';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '海北藏族自治州' and cityCode = '632200') where parentId = -1 and cityCode = '632521';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '海北藏族自治州' and cityCode = '632200') where parentId = -1 and cityCode = '632522';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '海北藏族自治州' and cityCode = '632200') where parentId = -1 and cityCode = '632523';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '海北藏族自治州' and cityCode = '632200') where parentId = -1 and cityCode = '632524';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '海北藏族自治州' and cityCode = '632200') where parentId = -1 and cityCode = '632525';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '阿勒泰地区' and cityCode = '654300') where parentId = -1 and cityCode = '659001';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '阿勒泰地区' and cityCode = '654300') where parentId = -1 and cityCode = '659002';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '阿勒泰地区' and cityCode = '654300') where parentId = -1 and cityCode = '659003';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '阿勒泰地区' and cityCode = '654300') where parentId = -1 and cityCode = '659004';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '阿勒泰地区' and cityCode = '654300') where parentId = -1 and cityCode = '659005';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '阿勒泰地区' and cityCode = '654300') where parentId = -1 and cityCode = '659007';
			//update ay_city set parentId = (select top 1 id from ay_city where cityName = '阿勒泰地区' and cityCode = '654300') where parentId = -1 and cityCode = '659008';
		}
		//****************************************************************************************************
		private void cmbCity_KeyUp(object sender, KeyEventArgs e) {
			if (cmbCity.Text == "") {
				lstCity.Visible = false;
			} else {
				List<CityData> cityData = CityData.getCityData(cmbCity.Text);
				if (cityData == null) {
					lstCity.Visible = false;
				} else {
					lstCity.Visible = true;
					lstCity.DataSource = cityData;
					lstCity.DisplayMember = "cityName";
					lstCity.ValueMember = "cityName";
				}
			}
		}
		//****************************************************************************************************
	}

	public class CityData {
		private static List<CityData> cityData;
		public string cityName { get; set; }
		public string spell { get; set; }
		public string firstSpell { get; set; }
		//****************************************************************************************************
		public static List<CityData> getCityData(string str) {
			str = str.ToLower();

			List<CityData> data = new List<CityData>();
			if (cityData == null) {
				DataTable dt = new ModCity().getSelect();
				foreach (DataRow dr in dt.Rows) {
					CityData item = new CityData() {
						cityName = dr["cityName"].ToString(),
						spell = dr["spell"].ToString().ToLower(),
						firstSpell = dr["firstSpell"].ToString().ToLower()
					};
					
					data.Add(item);
				}
				
				cityData = data;
			} else {
				data = cityData;
			}

			return (data.Where(
				item => 
					(item.cityName.Contains(str)) ||
					(item.spell.Contains(str)) ||
					(item.firstSpell.Contains(str))
			)).ToList<CityData>();
		}
		//****************************************************************************************************
	}
}
