using App.Common;

namespace App.Model {
	class ModCertificateType : DbHelper {
		//****************************************************************************************************
		public ModCertificateType() {
			this.strTable = "certificateType";
			this.strWhere = "(isPass = 1)";
		}
		//****************************************************************************************************
	}
}
