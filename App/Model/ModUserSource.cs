using App.Common;

namespace App.Model {
	class ModUserSource : DbHelper {
		//****************************************************************************************************
		public ModUserSource() {
			this.strTable = "userSource";
			this.strWhere = "(isPass = 1)";
		}
		//****************************************************************************************************
	}
}
