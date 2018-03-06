using App.Common;

namespace App.Model {
	class ModUserType : DbHelper {
		//****************************************************************************************************
		public ModUserType() {
			this.strTable = "userType";
			this.strWhere = "(isPass = 1)";
		}
		//****************************************************************************************************
	}
}
