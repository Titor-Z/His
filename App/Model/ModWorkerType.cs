using App.Common;

namespace App.Model {
	class ModWorkerType : DbHelper {
		//****************************************************************************************************
		public ModWorkerType() {
			this.strTable = "workerType";
			this.strWhere = "(isPass = 1)";
		}
		//****************************************************************************************************
	}
}
