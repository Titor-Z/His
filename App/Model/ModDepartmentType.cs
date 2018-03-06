using App.Common;

namespace App.Model {
	class ModDepartmentType: DbHelper {
		//****************************************************************************************************
		public ModDepartmentType() {
			this.strTable = "departmentType";
			this.strWhere = "(isPass = 1)";
		}
		//****************************************************************************************************
	}
}
