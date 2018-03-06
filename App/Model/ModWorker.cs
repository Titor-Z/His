using App.Common;

namespace App.Model {
	class ModWorker : DbHelper {
		//****************************************************************************************************
		public ModWorker() {
			this.strTable = "worker";
			this.strWhere = "(isPass = 1)";

			this.arrRelation.Add(new string[] { "ModHospital", "hospitalId", "hospitalName" });
			this.arrRelation.Add(new string[] { "ModWorkerType", "workerTypeId", "workerType" });
		}
		//****************************************************************************************************
	}
}
