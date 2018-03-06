using App.Common;

namespace App.Model {
	class ModHospital : DbHelper {
		//****************************************************************************************************
		public ModHospital() {
			this.strTable = "hospital";
			this.strWhere = "(isPass = 1)";
		}
		//****************************************************************************************************
	}
}
