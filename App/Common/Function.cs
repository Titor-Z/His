using CCWin;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace App.Common {
	class Function {
		//****************************************************************************************************
		//显示消息
		public static void showMessage(string str, Control control = null) {
			MessageBoxEx.Show(str + "！          ", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			
			if (control != null) {
				control.Focus();
			}
		}
		//****************************************************************************************************
		//获取 md5 加密字符
		public static string getMd5(string strCode) {
			string strMd5 = "";

			MD5 md5 = new MD5CryptoServiceProvider();
			byte[] res = md5.ComputeHash(Encoding.Default.GetBytes(strCode), 0, strCode.Length);

			for (int i = 0; i < res.Length; i++) {
				strMd5 += res[i].ToString("x").PadLeft(2, '0');
			}

			return (strMd5);
		}
		//**********************************************************************************
		//获取远程 XML
		public string getXML(string str) {
			//MSXML.XMLHTTP xmlhttp = new MSXML.XMLHTTP();
			//try {
			//	xmlhttp.open("GET", strUrl, false, null, null);
			//	xmlhttp.send("");
			//	MSXML.XMLDocument dom = new XMLDocument();
			//	Byte[] b = (Byte[])xmlhttp.responseBody;
			//	return System.Text.Encoding.GetEncoding("UTF-8").GetString(b).Trim();
			//} catch (Exception e) {
			//	return "";
			//}

			return ("");
		}
		//**********************************************************************************
		//时间格式 转 时间戳  
		public static Int64 getTimeStamp(DateTime dt) {
			TimeSpan ts;
			DateTime dtEra = new DateTime(1970, 1, 1, 0, 0, 0, 0);

			if (dt == null) {
				ts = DateTime.UtcNow - dtEra;
			} else {
				ts = dt.AddHours(-8) - dtEra;
			}
			
			return Convert.ToInt64(ts.TotalSeconds);
		}
		//**********************************************************************************
		//显示时间
		public static DateTime getDate(Object obj) {
			DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
			long lTime = long.Parse(Convert.ToInt32(obj) + "0000000");
			TimeSpan toNow = new TimeSpan(lTime);

			return dtStart.Add(toNow);
		}
		//**********************************************************************************
		//字符转 Asc 码
		public static int stringToAsc(string str) {
			if (str.Length == 1) {
				System.Text.ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
				int intAsciiCode = (int)asciiEncoding.GetBytes(str)[0];

				return (intAsciiCode);
			} else {
				throw new Exception("Character is not valid.");
			}
		}
		//**********************************************************************************
		//十进制 转换成 十六进制
		public string stringToHex(int d) {
			string str = "";
			if (d < 16) {
				str = getHexChar(d);
			} else {
				int c;
				int s = 0;
				int n = d;
				int temp = d;

				while (n >= 16) {
					s++;
					n = n / 16;
				}

				string[] m = new string[s];
				int i = 0;

				do {
					c = d / 16;
					m[i++] = getHexChar(d % 16);//判断是否大于10，如果大于10，则转换为A~F的格式 　　
					d = c;
				}

				while (c >= 16);

				str = getHexChar(d);

				for (int j = m.Length - 1; j >= 0; j--) {
					str += m[j];
				}
			}

			return (str);
		}
		//**********************************************************************************
		//判断是否为10~15之间的数，如果是则进行转换
		public string getHexChar(int n) {
			string str = "";
			switch (n) {
				case 10:
					str = "A";

					break;
				case 11:
					str = "B";

					break;
				case 12:
					str = "C";

					break;
				case 13:
					str = "D";

					break;
				case 14:
					str = "E";

					break;
				case 15:
					str = "F";

					break;
				default:
					str = n.ToString();

					break;
			}

			return (str);
		}
		//**********************************************************************************
		//写入串口字符
		private void writePortHex(string str) {
			//byte[] sendData = stringToByte(str);
			//spKey.Write(sendData, 0, sendData.Length);
		}
		//**********************************************************************************
		//字符串 转 十六进制
		private byte[] stringToByte(string str) {
			MatchCollection mc = Regex.Matches(str, @"(?i)[\da-f]{2}");
			List<byte> list = new List<byte>();
											   
			foreach (Match m in mc) {
				list.Add(byte.Parse(m.Value, System.Globalization.NumberStyles.HexNumber));
			}

			byte[] byteBuffer = new byte[list.Count];
			for (int i = 0; i < list.Count; i++) {
				byteBuffer[i] = (byte)list[i];
			}

			return (byteBuffer);
		}
		//**********************************************************************************
	}
}
