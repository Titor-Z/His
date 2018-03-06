using App.Common;

namespace App.Model {
	class ModUserLevel : DbHelper {
		//****************************************************************************************************
		public ModUserLevel() {
			this.strTable = "userLevel";
			this.strWhere = "(isPass = 1)";
		}
		//****************************************************************************************************
	}
}
