using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Dictionary {
	class ClsMenu {
		public static string strMenu = "{" +
			"	\"数据字典\": [" +
			"		{" +
			"			\"menuName\": \"院区定义\"," +
			"			\"menuClass\": \"Dictionary.FrmHospital\"," +
			"			\"role\": \"Insert,Update,Delete,Print,Exportz\"," +
			"			\"isShow\": true" +
			"		}," +
			"		{" +
			"			\"menuName\": \"科室类型定义\"," +
			"			\"menuClass\": \"Dictionary.FrmDepartmentType\"," +
			"			\"role\": \"Insert,Update,Delete,Print,Export\"," +
			"			\"isShow\": true" +
			"		}," +
			"		{" +
			"			\"menuName\": \"科室定义\"," +
			"			\"menuClass\": \"Dictionary.FrmDepartment\"," +
			"			\"role\": \"Insert,Update,Delete,Print,Export\"," +
			"			\"isShow\": true" +
			"		}," +
			"		{" +
			"			\"menuName\": \"角色定义\"," +
			"			\"menuClass\": \"Dictionary.FrmRole\"," +
			"			\"role\": \"Insert,Update,Delete,Print,Export\"," +
			"			\"isShow\": true" +
			"		}," +
			"		{" +
			"			\"menuName\": \"短信模板\"," +
			"			\"menuClass\": \"Dictionary.FrmSmsTemplate\"," +
			"			\"role\": \"Insert,Update,Delete,Print,Export\"," +
			"			\"isShow\": true" +
			"		}," +
			"		{" +
			"			\"menuName\": \"话术模板\"," +
			"			\"menuClass\": \"Dictionary.FrmSayTemplate\"," +
			"			\"role\": \"Insert,Update,Delete,Print,Export\"," +
			"			\"isShow\": true" +
			"		}," +
			"		{" +
			"			\"menuName\": \"备注模板\"," +
			"			\"menuClass\": \"Dictionary.FrmRemarkTemplate\"," +
			"			\"role\": \"Insert,Update,Delete,Print,Export\"," +
			"			\"isShow\": true" +
			"		}," +
			"		{" +
			"			\"menuName\": \"员工类型\"," +
			"			\"menuClass\": \"Dictionary.FrmWorkerType\"," +
			"			\"role\": \"Insert,Update,Delete,Print,Export\"," +
			"			\"isShow\": true" +
			"		}," +
			"		{" +
			"			\"menuName\": \"职业类型\"," +
			"			\"menuClass\": \"Dictionary.FrmJobType\"," +
			"			\"role\": \"Insert,Update,Delete,Print,Export\"," +
			"			\"isShow\": true" +
			"		}," +
			"		{" +
			"			\"menuName\": \"病种定义\"," +
			"			\"menuClass\": \"Dictionary.FrmEntity\"," +
			"			\"role\": \"Insert,Update,Delete,Print,Export\"," +
			"			\"isShow\": true" +
			"		}," +
			"		{" +
			"			\"menuName\": \"证件类型\"," +
			"			\"menuClass\": \"Dictionary.FrmCertificateType\"," +
			"			\"role\": \"Insert,Update,Delete,Print,Export\"," +
			"			\"isShow\": true" +
			"		}," +
			"		{" +
			"			\"menuName\": \"建卡类型\"," +
			"			\"menuClass\": \"Dictionary.FrmCardType\"," +
			"			\"role\": \"Insert,Update,Delete,Print,Export\"," +
			"			\"isShow\": true" +
			"		}," +
			"		{" +
			"			\"menuName\": \"挂号类型\"," +
			"			\"menuClass\": \"Dictionary.FrmRegisterType\"," +
			"			\"role\": \"Insert,Update,Delete,Print,Export\"," +
			"			\"isShow\": true" +
			"		}," +
			"		{" +
			"			\"menuName\": \"患者来源\"," +
			"			\"menuClass\": \"Dictionary.FrmUserSource\"," +
			"			\"role\": \"Insert,Update,Delete,Print,Export\"," +
			"			\"isShow\": true" +
			"		}," +
			"		{" +
			"			\"menuName\": \"患者类型\"," +
			"			\"menuClass\": \"Dictionary.FrmUserType\"," +
			"			\"role\": \"Insert,Update,Delete,Print,Export\"," +
			"			\"isShow\": true" +
			"		}," +
			"		{" +
			"			\"menuName\": \"联系人关系\"," +
			"			\"menuClass\": \"Dictionary.FrmRelation\"," +
			"			\"role\": \"Insert,Update,Delete,Print,Export\"," +
			"			\"isShow\": true" +
			"		}," +
			"		{" +
			"			\"menuName\": \"会员级别\"," +
			"			\"menuClass\": \"Dictionary.FrmUserLevel\"," +
			"			\"role\": \"Insert,Update,Delete,Print,Export\"," +
			"			\"isShow\": true" +
			"		}," +
			"		{" +
			"			\"menuName\": \"员工定义\"," +
			"			\"menuClass\": \"Dictionary.FrmWorker\"," +
			"			\"role\": \"Insert,Update,Delete,Print,Export\"," +
			"			\"isShow\": true" +
			"		}," +
			"	]," +
			"	\"患者预约\": [" +
			"		{" +
			"			\"menuName\": \"预约管理\"," +
			"			\"menuClass\": \"Reserver.FrmReserver\"," +
			"			\"role\": \"Insert,Update,Delete,Print,Export\"," +
			"			\"isShow\": true" +
			"		}," +
			"	]," +
			"	\"导诊管理\": [" +
			"		{" +
			"			\"menuName\": \"就诊卡\"," +
			"			\"menuClass\": \"Guidance.FrmCard\"," +
			"			\"role\": \"Insert,Update,Delete,Print,Export\"," +
			"			\"isShow\": true" +
			"		}," +
			"		{" +
			"			\"menuName\": \"补卡\"," +
			"			\"menuClass\": \"Guidance.FrmCard\"," +
			"			\"role\": \"Insert,Update,Delete,Print,Export\"," +
			"			\"isShow\": true" +
			"		}," +
			"		{" +
			"			\"menuName\": \"挂失\"," +
			"			\"menuClass\": \"Guidance.FrmCard\"," +
			"			\"role\": \"Insert,Update,Delete,Print,Export\"," +
			"			\"isShow\": true" +
			"		}," +
			"	]," +
			"	\"药库管理\": [" +
			"	]," +
			"	\"药房管理\": [" +
			"	]," +
			"	\"门诊医生\": [" +
			"	]," +
			"	\"检查管理\": [" +
			"	]," +
			"	\"化验管理\": [" +
			"	]," +
			"	\"治疗管理\": [" +
			"	]," +
			"	\"划价收费\": [" +
			"	]," +
			"	\"财务管理\": [" +
			"		{" +
			"			\"menuName\": \"成本汇总\"," +
			"			\"menuClass\": \"\"," +
			"			\"role\": \"Insert,Update,Delete,Print,Export\"," +
			"			\"isShow\": true" +
			"		}," +
			"		{" +
			"			\"menuName\": \"利润汇总\"," +
			"			\"menuClass\": \"\"," +
			"			\"role\": \"Insert,Update,Delete,Print,Export\"," +
			"			\"isShow\": true" +
			"		}," +
			"		{" +
			"			\"menuName\": \"工资汇总\"," +
			"			\"menuClass\": \"\"," +
			"			\"role\": \"Insert,Update,Delete,Print,Export\"," +
			"			\"isShow\": true" +
			"		}," +
			"	]," +
			"	\"院长查询\": [" +
			"	]," +
			"	\"修改密码\": {" +
			"		\"menuClass\": \"FrmPassword\"," +
			"		\"role\": \"\"," +
			"			\"isShow\": true" +
			"	}" +
			"}";
	}
}
