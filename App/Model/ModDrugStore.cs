using App.Common;

namespace App.Model {
	class ModDrugStore : DbHelper {
		public ModDrugStore() {
			this.strTable = "drug_store";
		}
	}
}
