using App.Common;

namespace App.Model {
	class ModSayTemplate : DbHelper {
		//****************************************************************************************************
		public ModSayTemplate() {
			this.strTable = "sayTemplate";
			this.strWhere = "(isPass = 1)";
		}
		//****************************************************************************************************
	}
}
