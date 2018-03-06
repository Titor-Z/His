using App.Common;

namespace App.Model {
	class ModRemarkTemplate : DbHelper {
		//****************************************************************************************************
		public ModRemarkTemplate() {
			this.strTable = "remarkTemplate";
			this.strWhere = "(isPass = 1)";
		}
		//****************************************************************************************************
	}
}
