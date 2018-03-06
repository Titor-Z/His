namespace App.Guidance {
	partial class FrmCardEdit {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.nudAge = new System.Windows.Forms.NumericUpDown();
			this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
			this.txtContent = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmbProvinceCityCounty = new App.Common.ComboboxProvinceCityCounty();
			this.cmbReserverWorkerId = new System.Windows.Forms.ComboBox();
			this.txtHospitalWorkerContent = new System.Windows.Forms.TextBox();
			this.label33 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.txtReserverCode = new System.Windows.Forms.TextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.cmbHospitalWorkerId = new System.Windows.Forms.ComboBox();
			this.cmbLinkmanRelationId = new System.Windows.Forms.ComboBox();
			this.txtLinkmanTel = new System.Windows.Forms.TextBox();
			this.txtLinkman = new System.Windows.Forms.TextBox();
			this.txtPost = new System.Windows.Forms.TextBox();
			this.cmbMarital = new System.Windows.Forms.ComboBox();
			this.cmbUserTypeId = new System.Windows.Forms.ComboBox();
			this.cmbJobTypeId = new System.Windows.Forms.ComboBox();
			this.label29 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.txtAllergicHistory = new System.Windows.Forms.TextBox();
			this.cmbBlood = new System.Windows.Forms.ComboBox();
			this.cmbNation = new System.Windows.Forms.ComboBox();
			this.label21 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.txtCertificateCode = new System.Windows.Forms.TextBox();
			this.cmbCertificateTypeId = new System.Windows.Forms.ComboBox();
			this.cmbReserverDepartmentId = new System.Windows.Forms.ComboBox();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.cmbSex = new System.Windows.Forms.ComboBox();
			this.txtRealname = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.cmbRegisterTypeId = new System.Windows.Forms.ComboBox();
			this.cmbUserSourceId = new System.Windows.Forms.ComboBox();
			this.txtUserCode = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbUserLevelId = new System.Windows.Forms.ComboBox();
			this.txtUserMoney = new System.Windows.Forms.TextBox();
			this.txtCardCode = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// nudAge
			// 
			this.nudAge.Location = new System.Drawing.Point(389, 97);
			this.nudAge.Name = "nudAge";
			this.nudAge.Size = new System.Drawing.Size(200, 21);
			this.nudAge.TabIndex = 32;
			// 
			// dtpBirthday
			// 
			this.dtpBirthday.CustomFormat = "yyyy-MM-dd";
			this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpBirthday.Location = new System.Drawing.Point(86, 97);
			this.dtpBirthday.Name = "dtpBirthday";
			this.dtpBirthday.Size = new System.Drawing.Size(200, 21);
			this.dtpBirthday.TabIndex = 25;
			// 
			// txtContent
			// 
			this.txtContent.Location = new System.Drawing.Point(86, 420);
			this.txtContent.MaxLength = 1000;
			this.txtContent.Multiline = true;
			this.txtContent.Name = "txtContent";
			this.txtContent.Size = new System.Drawing.Size(1120, 60);
			this.txtContent.TabIndex = 21;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(43, 444);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 12);
			this.label7.TabIndex = 6;
			this.label7.Text = "备注：";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(614, 14);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "保存(&S)";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(533, 14);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "关闭(&C)";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmbProvinceCityCounty);
			this.groupBox2.Controls.Add(this.cmbReserverWorkerId);
			this.groupBox2.Controls.Add(this.txtHospitalWorkerContent);
			this.groupBox2.Controls.Add(this.label33);
			this.groupBox2.Controls.Add(this.label32);
			this.groupBox2.Controls.Add(this.label31);
			this.groupBox2.Controls.Add(this.txtReserverCode);
			this.groupBox2.Controls.Add(this.label30);
			this.groupBox2.Controls.Add(this.cmbHospitalWorkerId);
			this.groupBox2.Controls.Add(this.cmbLinkmanRelationId);
			this.groupBox2.Controls.Add(this.txtLinkmanTel);
			this.groupBox2.Controls.Add(this.txtLinkman);
			this.groupBox2.Controls.Add(this.txtPost);
			this.groupBox2.Controls.Add(this.cmbMarital);
			this.groupBox2.Controls.Add(this.cmbUserTypeId);
			this.groupBox2.Controls.Add(this.cmbJobTypeId);
			this.groupBox2.Controls.Add(this.label29);
			this.groupBox2.Controls.Add(this.label28);
			this.groupBox2.Controls.Add(this.label27);
			this.groupBox2.Controls.Add(this.label26);
			this.groupBox2.Controls.Add(this.label25);
			this.groupBox2.Controls.Add(this.label24);
			this.groupBox2.Controls.Add(this.label23);
			this.groupBox2.Controls.Add(this.label22);
			this.groupBox2.Controls.Add(this.txtAllergicHistory);
			this.groupBox2.Controls.Add(this.cmbBlood);
			this.groupBox2.Controls.Add(this.cmbNation);
			this.groupBox2.Controls.Add(this.label21);
			this.groupBox2.Controls.Add(this.label20);
			this.groupBox2.Controls.Add(this.label19);
			this.groupBox2.Controls.Add(this.txtCertificateCode);
			this.groupBox2.Controls.Add(this.cmbCertificateTypeId);
			this.groupBox2.Controls.Add(this.cmbReserverDepartmentId);
			this.groupBox2.Controls.Add(this.txtTel);
			this.groupBox2.Controls.Add(this.label18);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.cmbSex);
			this.groupBox2.Controls.Add(this.txtRealname);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.cmbRegisterTypeId);
			this.groupBox2.Controls.Add(this.cmbUserSourceId);
			this.groupBox2.Controls.Add(this.txtUserCode);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.cmbUserLevelId);
			this.groupBox2.Controls.Add(this.txtUserMoney);
			this.groupBox2.Controls.Add(this.txtCardCode);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.txtAddress);
			this.groupBox2.Controls.Add(this.nudAge);
			this.groupBox2.Controls.Add(this.dtpBirthday);
			this.groupBox2.Controls.Add(this.txtContent);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Location = new System.Drawing.Point(10, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1224, 494);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			// 
			// cmbProvinceCityCounty
			// 
			this.cmbProvinceCityCounty.Location = new System.Drawing.Point(30, 218);
			this.cmbProvinceCityCounty.Name = "cmbProvinceCityCounty";
			this.cmbProvinceCityCounty.Size = new System.Drawing.Size(560, 22);
			this.cmbProvinceCityCounty.TabIndex = 101;
			// 
			// cmbReserverWorkerId
			// 
			this.cmbReserverWorkerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbReserverWorkerId.FormattingEnabled = true;
			this.cmbReserverWorkerId.Location = new System.Drawing.Point(389, 299);
			this.cmbReserverWorkerId.Name = "cmbReserverWorkerId";
			this.cmbReserverWorkerId.Size = new System.Drawing.Size(200, 20);
			this.cmbReserverWorkerId.TabIndex = 100;
			// 
			// txtHospitalWorkerContent
			// 
			this.txtHospitalWorkerContent.Location = new System.Drawing.Point(707, 259);
			this.txtHospitalWorkerContent.Name = "txtHospitalWorkerContent";
			this.txtHospitalWorkerContent.Size = new System.Drawing.Size(499, 21);
			this.txtHospitalWorkerContent.TabIndex = 99;
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Location = new System.Drawing.Point(605, 263);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(101, 12);
			this.label33.TabIndex = 98;
			this.label33.Text = "院内联系人备注：";
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Location = new System.Drawing.Point(641, 223);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(65, 12);
			this.label32.TabIndex = 97;
			this.label32.Text = "详细地址：";
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Location = new System.Drawing.Point(322, 303);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(65, 12);
			this.label31.TabIndex = 95;
			this.label31.Text = "预约员工：";
			// 
			// txtReserverCode
			// 
			this.txtReserverCode.Location = new System.Drawing.Point(86, 299);
			this.txtReserverCode.Name = "txtReserverCode";
			this.txtReserverCode.Size = new System.Drawing.Size(200, 21);
			this.txtReserverCode.TabIndex = 94;
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(31, 303);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(53, 12);
			this.label30.TabIndex = 93;
			this.label30.Text = "预约号：";
			// 
			// cmbHospitalWorkerId
			// 
			this.cmbHospitalWorkerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbHospitalWorkerId.FormattingEnabled = true;
			this.cmbHospitalWorkerId.Location = new System.Drawing.Point(389, 259);
			this.cmbHospitalWorkerId.Name = "cmbHospitalWorkerId";
			this.cmbHospitalWorkerId.Size = new System.Drawing.Size(200, 20);
			this.cmbHospitalWorkerId.TabIndex = 92;
			// 
			// cmbLinkmanRelationId
			// 
			this.cmbLinkmanRelationId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLinkmanRelationId.FormattingEnabled = true;
			this.cmbLinkmanRelationId.Location = new System.Drawing.Point(1006, 178);
			this.cmbLinkmanRelationId.Name = "cmbLinkmanRelationId";
			this.cmbLinkmanRelationId.Size = new System.Drawing.Size(200, 20);
			this.cmbLinkmanRelationId.TabIndex = 87;
			// 
			// txtLinkmanTel
			// 
			this.txtLinkmanTel.Location = new System.Drawing.Point(707, 178);
			this.txtLinkmanTel.Name = "txtLinkmanTel";
			this.txtLinkmanTel.Size = new System.Drawing.Size(200, 21);
			this.txtLinkmanTel.TabIndex = 86;
			// 
			// txtLinkman
			// 
			this.txtLinkman.Location = new System.Drawing.Point(389, 178);
			this.txtLinkman.Name = "txtLinkman";
			this.txtLinkman.Size = new System.Drawing.Size(200, 21);
			this.txtLinkman.TabIndex = 85;
			// 
			// txtPost
			// 
			this.txtPost.Location = new System.Drawing.Point(86, 178);
			this.txtPost.Name = "txtPost";
			this.txtPost.Size = new System.Drawing.Size(200, 21);
			this.txtPost.TabIndex = 84;
			// 
			// cmbMarital
			// 
			this.cmbMarital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMarital.FormattingEnabled = true;
			this.cmbMarital.Location = new System.Drawing.Point(1006, 138);
			this.cmbMarital.Name = "cmbMarital";
			this.cmbMarital.Size = new System.Drawing.Size(200, 20);
			this.cmbMarital.TabIndex = 83;
			// 
			// cmbUserTypeId
			// 
			this.cmbUserTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbUserTypeId.FormattingEnabled = true;
			this.cmbUserTypeId.Location = new System.Drawing.Point(86, 138);
			this.cmbUserTypeId.Name = "cmbUserTypeId";
			this.cmbUserTypeId.Size = new System.Drawing.Size(200, 20);
			this.cmbUserTypeId.TabIndex = 82;
			// 
			// cmbJobTypeId
			// 
			this.cmbJobTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbJobTypeId.FormattingEnabled = true;
			this.cmbJobTypeId.Location = new System.Drawing.Point(389, 138);
			this.cmbJobTypeId.Name = "cmbJobTypeId";
			this.cmbJobTypeId.Size = new System.Drawing.Size(200, 20);
			this.cmbJobTypeId.TabIndex = 81;
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(310, 263);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(77, 12);
			this.label29.TabIndex = 80;
			this.label29.Text = "院内联系人：";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(927, 182);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(77, 12);
			this.label28.TabIndex = 79;
			this.label28.Text = "联系人关系：";
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(629, 182);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(77, 12);
			this.label27.TabIndex = 78;
			this.label27.Text = "联系人电话：";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(334, 182);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(53, 12);
			this.label26.TabIndex = 77;
			this.label26.Text = "联系人：";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(43, 182);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(41, 12);
			this.label25.TabIndex = 76;
			this.label25.Text = "邮编：";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(939, 142);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(65, 12);
			this.label24.TabIndex = 75;
			this.label24.Text = "婚姻状况：";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(19, 142);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(65, 12);
			this.label23.TabIndex = 74;
			this.label23.Text = "患者类型：";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(346, 142);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(41, 12);
			this.label22.TabIndex = 73;
			this.label22.Text = "职业：";
			// 
			// txtAllergicHistory
			// 
			this.txtAllergicHistory.Location = new System.Drawing.Point(86, 340);
			this.txtAllergicHistory.Multiline = true;
			this.txtAllergicHistory.Name = "txtAllergicHistory";
			this.txtAllergicHistory.Size = new System.Drawing.Size(1120, 60);
			this.txtAllergicHistory.TabIndex = 72;
			// 
			// cmbBlood
			// 
			this.cmbBlood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBlood.FormattingEnabled = true;
			this.cmbBlood.Location = new System.Drawing.Point(707, 138);
			this.cmbBlood.Name = "cmbBlood";
			this.cmbBlood.Size = new System.Drawing.Size(200, 20);
			this.cmbBlood.TabIndex = 71;
			// 
			// cmbNation
			// 
			this.cmbNation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbNation.FormattingEnabled = true;
			this.cmbNation.Location = new System.Drawing.Point(1006, 97);
			this.cmbNation.Name = "cmbNation";
			this.cmbNation.Size = new System.Drawing.Size(200, 20);
			this.cmbNation.TabIndex = 70;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(31, 364);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(53, 12);
			this.label21.TabIndex = 69;
			this.label21.Text = "过敏史：";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(665, 142);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(41, 12);
			this.label20.TabIndex = 68;
			this.label20.Text = "血型：";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(963, 101);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(41, 12);
			this.label19.TabIndex = 67;
			this.label19.Text = "民族：";
			// 
			// txtCertificateCode
			// 
			this.txtCertificateCode.Location = new System.Drawing.Point(1006, 56);
			this.txtCertificateCode.Name = "txtCertificateCode";
			this.txtCertificateCode.Size = new System.Drawing.Size(200, 21);
			this.txtCertificateCode.TabIndex = 66;
			// 
			// cmbCertificateTypeId
			// 
			this.cmbCertificateTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCertificateTypeId.FormattingEnabled = true;
			this.cmbCertificateTypeId.Location = new System.Drawing.Point(707, 56);
			this.cmbCertificateTypeId.Name = "cmbCertificateTypeId";
			this.cmbCertificateTypeId.Size = new System.Drawing.Size(200, 20);
			this.cmbCertificateTypeId.TabIndex = 65;
			// 
			// cmbReserverDepartmentId
			// 
			this.cmbReserverDepartmentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbReserverDepartmentId.FormattingEnabled = true;
			this.cmbReserverDepartmentId.Location = new System.Drawing.Point(707, 299);
			this.cmbReserverDepartmentId.Name = "cmbReserverDepartmentId";
			this.cmbReserverDepartmentId.Size = new System.Drawing.Size(200, 20);
			this.cmbReserverDepartmentId.TabIndex = 64;
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(707, 97);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(200, 21);
			this.txtTel.TabIndex = 63;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(939, 60);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(65, 12);
			this.label18.TabIndex = 62;
			this.label18.Text = "证件号码：";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(641, 60);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(65, 12);
			this.label17.TabIndex = 61;
			this.label17.Text = "证件类型：";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(641, 303);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(65, 12);
			this.label16.TabIndex = 60;
			this.label16.Text = "预约科室：";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(665, 101);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(41, 12);
			this.label15.TabIndex = 59;
			this.label15.Text = "电话：";
			// 
			// cmbSex
			// 
			this.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSex.FormattingEnabled = true;
			this.cmbSex.Location = new System.Drawing.Point(389, 56);
			this.cmbSex.Name = "cmbSex";
			this.cmbSex.Size = new System.Drawing.Size(200, 20);
			this.cmbSex.TabIndex = 58;
			// 
			// txtRealname
			// 
			this.txtRealname.Location = new System.Drawing.Point(86, 56);
			this.txtRealname.Name = "txtRealname";
			this.txtRealname.Size = new System.Drawing.Size(200, 21);
			this.txtRealname.TabIndex = 57;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(346, 101);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(41, 12);
			this.label14.TabIndex = 56;
			this.label14.Text = "年龄：";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(19, 101);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(65, 12);
			this.label13.TabIndex = 55;
			this.label13.Text = "出生日期：";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.ForeColor = System.Drawing.Color.Red;
			this.label12.Location = new System.Drawing.Point(346, 60);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(41, 12);
			this.label12.TabIndex = 54;
			this.label12.Text = "性别：";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.ForeColor = System.Drawing.Color.Red;
			this.label11.Location = new System.Drawing.Point(19, 60);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(65, 12);
			this.label11.TabIndex = 53;
			this.label11.Text = "患者姓名：";
			// 
			// cmbRegisterTypeId
			// 
			this.cmbRegisterTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRegisterTypeId.FormattingEnabled = true;
			this.cmbRegisterTypeId.Location = new System.Drawing.Point(1006, 15);
			this.cmbRegisterTypeId.Name = "cmbRegisterTypeId";
			this.cmbRegisterTypeId.Size = new System.Drawing.Size(200, 20);
			this.cmbRegisterTypeId.TabIndex = 52;
			// 
			// cmbUserSourceId
			// 
			this.cmbUserSourceId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbUserSourceId.FormattingEnabled = true;
			this.cmbUserSourceId.Location = new System.Drawing.Point(86, 259);
			this.cmbUserSourceId.Name = "cmbUserSourceId";
			this.cmbUserSourceId.Size = new System.Drawing.Size(200, 20);
			this.cmbUserSourceId.TabIndex = 50;
			// 
			// txtUserCode
			// 
			this.txtUserCode.Location = new System.Drawing.Point(389, 15);
			this.txtUserCode.Name = "txtUserCode";
			this.txtUserCode.Size = new System.Drawing.Size(200, 21);
			this.txtUserCode.TabIndex = 49;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.ForeColor = System.Drawing.Color.Red;
			this.label10.Location = new System.Drawing.Point(939, 19);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(65, 12);
			this.label10.TabIndex = 48;
			this.label10.Text = "挂号类型：";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(19, 263);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 12);
			this.label6.TabIndex = 46;
			this.label6.Text = "患者来源：";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(334, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 12);
			this.label5.TabIndex = 45;
			this.label5.Text = "病历号：";
			// 
			// cmbUserLevelId
			// 
			this.cmbUserLevelId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbUserLevelId.FormattingEnabled = true;
			this.cmbUserLevelId.Location = new System.Drawing.Point(707, 15);
			this.cmbUserLevelId.Name = "cmbUserLevelId";
			this.cmbUserLevelId.Size = new System.Drawing.Size(200, 20);
			this.cmbUserLevelId.TabIndex = 44;
			// 
			// txtUserMoney
			// 
			this.txtUserMoney.Enabled = false;
			this.txtUserMoney.Location = new System.Drawing.Point(1006, 299);
			this.txtUserMoney.Name = "txtUserMoney";
			this.txtUserMoney.Size = new System.Drawing.Size(200, 21);
			this.txtUserMoney.TabIndex = 42;
			// 
			// txtCardCode
			// 
			this.txtCardCode.Location = new System.Drawing.Point(86, 15);
			this.txtCardCode.Name = "txtCardCode";
			this.txtCardCode.Size = new System.Drawing.Size(200, 21);
			this.txtCardCode.TabIndex = 39;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(945, 303);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 12);
			this.label4.TabIndex = 38;
			this.label4.Text = "剩余金额：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(641, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 12);
			this.label3.TabIndex = 37;
			this.label3.Text = "会员级别：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(43, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 35;
			this.label1.Text = "卡号：";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(707, 219);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(499, 21);
			this.txtAddress.TabIndex = 34;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSave);
			this.groupBox1.Controls.Add(this.btnClose);
			this.groupBox1.Location = new System.Drawing.Point(10, 513);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1222, 50);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// FrmCardEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1244, 575);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmCardEdit";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "就诊卡";
			this.Load += new System.EventHandler(this.FrmCardEdit_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NumericUpDown nudAge;
		private System.Windows.Forms.DateTimePicker dtpBirthday;
		private System.Windows.Forms.TextBox txtContent;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUserMoney;
		private System.Windows.Forms.TextBox txtCardCode;
		private System.Windows.Forms.ComboBox cmbUserLevelId;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbRegisterTypeId;
		private System.Windows.Forms.ComboBox cmbUserSourceId;
		private System.Windows.Forms.TextBox txtUserCode;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cmbSex;
		private System.Windows.Forms.TextBox txtRealname;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtCertificateCode;
		private System.Windows.Forms.ComboBox cmbCertificateTypeId;
		private System.Windows.Forms.ComboBox cmbReserverDepartmentId;
		private System.Windows.Forms.TextBox txtTel;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txtAllergicHistory;
		private System.Windows.Forms.ComboBox cmbBlood;
		private System.Windows.Forms.ComboBox cmbNation;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.TextBox txtPost;
		private System.Windows.Forms.ComboBox cmbMarital;
		private System.Windows.Forms.ComboBox cmbUserTypeId;
		private System.Windows.Forms.ComboBox cmbJobTypeId;
		private System.Windows.Forms.ComboBox cmbLinkmanRelationId;
		private System.Windows.Forms.TextBox txtLinkmanTel;
		private System.Windows.Forms.TextBox txtLinkman;
		private System.Windows.Forms.ComboBox cmbHospitalWorkerId;
		private System.Windows.Forms.TextBox txtReserverCode;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.TextBox txtHospitalWorkerContent;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.ComboBox cmbReserverWorkerId;
		private Common.ComboboxProvinceCityCounty cmbProvinceCityCounty;
	}
}