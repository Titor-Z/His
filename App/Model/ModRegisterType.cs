using App.Common;

namespace App.Model {
	class ModRegisterType : DbHelper {
		//****************************************************************************************************
		public ModRegisterType() {
			this.strTable = "registerType";
			this.strWhere = "(isPass = 1)";
		}
		//****************************************************************************************************
	}
}
