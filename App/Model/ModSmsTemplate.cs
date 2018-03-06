using App.Common;

namespace App.Model {
	class ModSmsTemplate : DbHelper {
		//****************************************************************************************************
		public ModSmsTemplate() {
			this.strTable = "smsTemplate";
			this.strWhere = "(isPass = 1)";
		}
		//****************************************************************************************************
	}
}
