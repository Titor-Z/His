using App.Common;

namespace App.Model {
	class ModDepartment : DbHelper {
		//****************************************************************************************************
		public ModDepartment() {
			this.strTable = "department";
			this.strWhere = "(isPass = 1)";
			
			this.arrRelation.Add(new string[] { "ModHospital", "hospitalId", "hospitalName" });
			this.arrRelation.Add(new string[] { "ModDepartmentType", "departmentTypeID", "departmentType" });
		}
		//****************************************************************************************************
	}
}
