using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace App.Common {
	class DbHelper {
		private string strField = "*";
		private bool bolRelation = false;

		protected int intNumber = 100;
		protected string strPrefix = "";
		protected string strTable = "";
		protected string strFindField = "";
		protected string strSelectField = "";
		protected string strWhere = "";
		protected string strOrder = "id asc";
		protected ArrayList arrRelation = new ArrayList();
		//****************************************************************************************************
		public DbHelper() {
			strPrefix = Program.xmlApp.SelectSingleNode("/config/database/prefix").InnerText;
			
			openConn();
		}
		//****************************************************************************************************
		//打开数据库
		private SqlConnection openConn() {
			if (Program.conn.State == ConnectionState.Closed) {
				string strHost = Program.xmlApp.SelectSingleNode("/config/database/host").InnerText;
				string strDatabase = Program.xmlApp.SelectSingleNode("/config/database/database").InnerText;
				string strUsername = Program.xmlApp.SelectSingleNode("/config/database/username").InnerText;
				string strPassword = Program.xmlApp.SelectSingleNode("/config/database/password").InnerText;

				string strConn = "Data Source=" + strHost + "; Initial Catalog=" + strDatabase + "; User ID=" + strUsername + "; Password=" + strPassword + ";";
				SqlConnection sqlConnection = new SqlConnection(strConn);

				Program.conn = sqlConnection;
				Program.conn.Open();
			}
			
			return (Program.conn);

			//string connString = "User ID=cityhos; Password=hiscss; Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.2.12)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=oracle)));";
			//OracleConnection conn = new OracleConnection(connString);
			//try {
			//    conn.Open();
			//} catch (Exception ex) {
			//    //MessageBox.Show(ex.Message.ToString());
			//} finally {
			//    conn.Close();
			//}

			////string sql = "select * from CLINICBILLDETAIL";
			//string sql = "select * from AAAA";
			//OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(sql, conn);
			//DataSet ds = new DataSet();
			//oracleDataAdapter.Fill(ds);

			//dataGridView1.DataSource = ds.Tables[0];
		}
		//****************************************************************************************************
		//关闭数据库
		public void closeConn() {
			Program.conn.Close();
		}
		//****************************************************************************************************
		//设置 查询字段
		public DbHelper setField(string strField, string strFieldType = "select") {
			if (strField != "") {
				if (strFieldType == "select") {
					this.strField = strField;
				} else if (strFieldType == "find") {
					this.strField = strField;
				}
			}

			return (this);
		}
		//****************************************************************************************************
		//设置 关联模型
		public DbHelper setRelation(bool bol) {
			bolRelation = true;

			return (this);
		}
		//****************************************************************************************************
		//设置 查询条件
		public DbHelper setWhere(string strWhere, bool isCover = false) {
			if (strWhere != "") {
				if (isCover) {
					this.strWhere = strWhere;
				} else {
					if (this.strWhere == "") {
						this.strWhere = strWhere;
					} else {
						this.strWhere += " and " + strWhere;
					}
				}
			}

			return (this);
		}
		//****************************************************************************************************
		//设置 查询排序
		public DbHelper setOrder(string strOrder) {
			if (strOrder != "") {
				this.strOrder = strOrder;
			}

			return (this);
		}
		//****************************************************************************************************
		//批量保存
		public void setSaveAll() {

		}
		//****************************************************************************************************
		//删除
		public int setDelete(int intId) {
			string strSql = "delete from " + strPrefix + strTable + " where id = " + intId.ToString();
			SqlCommand cmd = new SqlCommand(strSql, Program.conn);
			int n = cmd.ExecuteNonQuery();

			return (n);
		}
		//****************************************************************************************************
		//查询多笔记录
		public DataTable getSelect() {
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(parseSelectSql("select"), Program.conn);
			DataSet ds = new DataSet();
			sqlDataAdapter.Fill(ds);

			if (ds.Tables[0].Rows.Count == 0) {
				return (null);
			} else {
				return (ds.Tables[0]);
			}
		}
		//****************************************************************************************************
		//查询单笔记录
		public DataRow getFind(int intId = 0) {
			if (intId > 0) {
				setWhere("id = " + intId.ToString());
			}

			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(parseSelectSql("find"), Program.conn);
			DataSet ds = new DataSet();
			sqlDataAdapter.Fill(ds);

			if (ds.Tables[0].Rows.Count == 0) {
				return (null);
			} else {
				return (ds.Tables[0].Rows[0]);
			}
		}
		//****************************************************************************************************
		//保存
		public int setSave(Hashtable ht) {
			int n = 0;
			string strSql = "";

			strTable = strPrefix + strTable;

			if (Convert.ToInt32(ht["id"]) == 0) {
				strSql = "insert into " + strTable + " (";

				foreach (DictionaryEntry de in ht) {
					if (de.Key.ToString() != "id") {
						if (n > 0) {
							strSql += ", ";
						}

						strSql += de.Key;
						n++;
					}
				}

				n = 0;
				strSql += ") values (";

				foreach (DictionaryEntry de in ht) {
					if (de.Key.ToString() != "id") {
						if (n > 0) {
							strSql += ", ";
						}

						strSql += "'" + de.Value + "'";
						n++;
					}
				}

				strSql += ")";
			} else {
				strSql = "update " + strTable + " set ";

				foreach (DictionaryEntry de in ht) {
					if (de.Key.ToString() != "id") {
						if (n > 0) {
							strSql += ", ";
						}

						strSql += de.Key + " = '" + de.Value + "'";
						n++;
					}
				}

				strSql += " where id = " + ht["id"].ToString();
			}

			SqlCommand sqlCommand = new SqlCommand(strSql, Program.conn);
			int intRows = sqlCommand.ExecuteNonQuery();

			return (intRows);
		}
		//****************************************************************************************************
		//查找字段
		public string getField(string strField) {
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(parseSelectSql("find"), Program.conn);
			DataSet ds = new DataSet();
			sqlDataAdapter.Fill(ds);

			if (ds.Tables[0].Rows.Count == 0) {
				return ("");
			} else {
				return (ds.Tables[0].Rows[0][strField].ToString());
			}
		}
		//****************************************************************************************************
		//统计数量
		public int getCount() {
			return (0);
		}
		//****************************************************************************************************
		//合计
		public float getSum(string strField, int intDecimal = 2) {
			return (0);
		}
		//****************************************************************************************************
		//最大值
		public float getMax(string strField) {
			return (0);
		}
		//****************************************************************************************************
		//最小值
		public float getMin(string strField) {
			return (0);
		}
		//****************************************************************************************************
		//平均值
		public float getAvg(string strField) {
			return (0);
		}
		//****************************************************************************************************
		//执行 sql 语句
		public int getQuery(string strSql) {
			SqlCommand cmd = new SqlCommand(strSql, Program.conn);
			
			int n = cmd.ExecuteNonQuery();

			return (n);
		}
		//****************************************************************************************************
		private string parseSelectSql(string strType = "select") {
			string strSql = "select ";

			if (strType == "find") {
				strSql += " top 1 ";
			}

			strSql += parseField();
			strSql += parseTable();
			strSql += parseWhere();
			strSql += parseOrder();

			//Function.showMessage(strSql);
			//Console.WriteLine(strSql);

			return (strSql);
		}
		//****************************************************************************************************
		private string parseField() {
			string str = strField;

			if (bolRelation) {
				foreach (string[] arrModel in this.arrRelation) {
					str += ", " + arrModel[2];
				}
			}

			return (str);
		}
		//****************************************************************************************************
		private string parseTable() {
			string str = " from " + this.strPrefix + this.strTable;

			if (bolRelation) {
				foreach (string[] arrModel in this.arrRelation) {
					Assembly assm = Assembly.GetAssembly(this.GetType());
					DbHelper db = (DbHelper)assm.CreateInstance("App.Model." + arrModel[0]);
				
					string strModelTable = this.strPrefix + db.strTable;

					str += " inner join " + strModelTable + " on " + this.strPrefix + this.strTable + "." + arrModel[1] + " = " + strModelTable + ".id";
				}
			}
			
			return (str);
		}
		//****************************************************************************************************
		private string parseWhere() {
			string str = "";

			if (strWhere.Trim() != "") {
				if (bolRelation) {
					str = " where " + strPrefix + strTable + "." + strWhere;
				} else {
					str = " where " + strWhere;
				}
			}

			return (str);
		}
		//****************************************************************************************************
		private string parseOrder() {
			string str = " order by ";

			if (bolRelation) {
				str += this.strPrefix + this.strTable + "." + strOrder;
			} else {
				str += strOrder;
			}

			return (str);
		}
		//****************************************************************************************************
	}
}
