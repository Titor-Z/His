using App.Common;

namespace App.Model {
	class ModEntity : DbHelper {
		//****************************************************************************************************
		public ModEntity() {
			this.strTable = "entity";
			this.strWhere = "(isPass = 1)";
		}
		//****************************************************************************************************
	}
}
