using App.Common;

namespace App.Model {
	class ModCardType : DbHelper {
		//****************************************************************************************************
		public ModCardType() {
			this.strTable = "cardType";
			this.strWhere = "(isPass = 1)";
		}
		//****************************************************************************************************
	}
}
