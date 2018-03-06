using App.Common;

namespace App.Model {
	class ModJobType : DbHelper {
		//****************************************************************************************************
		public ModJobType() {
			this.strTable = "jobType";
			this.strWhere = "(isPass = 1)";
		}
		//****************************************************************************************************
	}
}
