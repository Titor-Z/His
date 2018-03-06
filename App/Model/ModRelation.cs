using App.Common;

namespace App.Model {
	class ModRelation : DbHelper {
		//****************************************************************************************************
		public ModRelation() {
			this.strTable = "relation";
			this.strWhere = "(isPass = 1)";
		}
		//****************************************************************************************************
	}
}
