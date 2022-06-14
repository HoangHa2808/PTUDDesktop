namespace Lab05
{
	partial class InformationForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationForm));
			this.lbMSSV = new System.Windows.Forms.Label();
			this.lbHoDem = new System.Windows.Forms.Label();
			this.lbBirthday = new System.Windows.Forms.Label();
			this.lbCMND = new System.Windows.Forms.Label();
			this.lbAdderss = new System.Windows.Forms.Label();
			this.lbRegistrationSubject = new System.Windows.Forms.Label();
			this.lbGender = new System.Windows.Forms.Label();
			this.lbFirstName = new System.Windows.Forms.Label();
			this.lbClass = new System.Windows.Forms.Label();
			this.lbPhone = new System.Windows.Forms.Label();
			this.rdMale = new System.Windows.Forms.RadioButton();
			this.rdFemale = new System.Windows.Forms.RadioButton();
			this.clbFaculty = new System.Windows.Forms.CheckedListBox();
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiDeleteRegistration = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiAddRegistration = new System.Windows.Forms.ToolStripMenuItem();
			this.lvStudent = new System.Windows.Forms.ListView();
			this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Birthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Class = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CMND = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.mtbID = new System.Windows.Forms.MaskedTextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
			this.mtbCMND = new System.Windows.Forms.MaskedTextBox();
			this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
			this.txtAdderss = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.cboClass = new System.Windows.Forms.ComboBox();
			this.lbStudentList = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.contextMenuStrip2.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbMSSV
			// 
			this.lbMSSV.AutoSize = true;
			this.lbMSSV.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMSSV.Location = new System.Drawing.Point(42, 36);
			this.lbMSSV.Name = "lbMSSV";
			this.lbMSSV.Size = new System.Drawing.Size(49, 13);
			this.lbMSSV.TabIndex = 0;
			this.lbMSSV.Text = "MSSV :";
			// 
			// lbHoDem
			// 
			this.lbHoDem.AutoSize = true;
			this.lbHoDem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbHoDem.Location = new System.Drawing.Point(42, 78);
			this.lbHoDem.Name = "lbHoDem";
			this.lbHoDem.Size = new System.Drawing.Size(89, 13);
			this.lbHoDem.TabIndex = 0;
			this.lbHoDem.Text = "Họ và tên lót :";
			// 
			// lbBirthday
			// 
			this.lbBirthday.AutoSize = true;
			this.lbBirthday.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbBirthday.Location = new System.Drawing.Point(42, 124);
			this.lbBirthday.Name = "lbBirthday";
			this.lbBirthday.Size = new System.Drawing.Size(72, 13);
			this.lbBirthday.TabIndex = 0;
			this.lbBirthday.Text = "Ngày sinh :";
			// 
			// lbCMND
			// 
			this.lbCMND.AutoSize = true;
			this.lbCMND.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCMND.Location = new System.Drawing.Point(42, 171);
			this.lbCMND.Name = "lbCMND";
			this.lbCMND.Size = new System.Drawing.Size(70, 13);
			this.lbCMND.TabIndex = 0;
			this.lbCMND.Text = "Số CMND :";
			// 
			// lbAdderss
			// 
			this.lbAdderss.AutoSize = true;
			this.lbAdderss.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAdderss.Location = new System.Drawing.Point(42, 214);
			this.lbAdderss.Name = "lbAdderss";
			this.lbAdderss.Size = new System.Drawing.Size(99, 13);
			this.lbAdderss.TabIndex = 0;
			this.lbAdderss.Text = "Địa chỉ liên lạc :";
			// 
			// lbRegistrationSubject
			// 
			this.lbRegistrationSubject.AutoSize = true;
			this.lbRegistrationSubject.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbRegistrationSubject.Location = new System.Drawing.Point(42, 267);
			this.lbRegistrationSubject.Name = "lbRegistrationSubject";
			this.lbRegistrationSubject.Size = new System.Drawing.Size(113, 13);
			this.lbRegistrationSubject.TabIndex = 0;
			this.lbRegistrationSubject.Text = "Môn học đăng ký :";
			// 
			// lbGender
			// 
			this.lbGender.AutoSize = true;
			this.lbGender.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbGender.Location = new System.Drawing.Point(435, 36);
			this.lbGender.Name = "lbGender";
			this.lbGender.Size = new System.Drawing.Size(63, 13);
			this.lbGender.TabIndex = 0;
			this.lbGender.Text = "Giới tính :";
			// 
			// lbFirstName
			// 
			this.lbFirstName.AutoSize = true;
			this.lbFirstName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFirstName.Location = new System.Drawing.Point(435, 78);
			this.lbFirstName.Name = "lbFirstName";
			this.lbFirstName.Size = new System.Drawing.Size(37, 13);
			this.lbFirstName.TabIndex = 0;
			this.lbFirstName.Text = "Tên :";
			// 
			// lbClass
			// 
			this.lbClass.AutoSize = true;
			this.lbClass.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbClass.Location = new System.Drawing.Point(435, 124);
			this.lbClass.Name = "lbClass";
			this.lbClass.Size = new System.Drawing.Size(36, 13);
			this.lbClass.TabIndex = 0;
			this.lbClass.Text = "Lớp :";
			// 
			// lbPhone
			// 
			this.lbPhone.AutoSize = true;
			this.lbPhone.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPhone.Location = new System.Drawing.Point(435, 171);
			this.lbPhone.Name = "lbPhone";
			this.lbPhone.Size = new System.Drawing.Size(46, 13);
			this.lbPhone.TabIndex = 0;
			this.lbPhone.Text = "Số ĐT:";
			// 
			// rdMale
			// 
			this.rdMale.AutoSize = true;
			this.rdMale.Checked = true;
			this.rdMale.Location = new System.Drawing.Point(517, 32);
			this.rdMale.Name = "rdMale";
			this.rdMale.Size = new System.Drawing.Size(47, 17);
			this.rdMale.TabIndex = 1;
			this.rdMale.TabStop = true;
			this.rdMale.Text = "Nam";
			this.rdMale.UseVisualStyleBackColor = true;
			// 
			// rdFemale
			// 
			this.rdFemale.AutoSize = true;
			this.rdFemale.Location = new System.Drawing.Point(628, 32);
			this.rdFemale.Name = "rdFemale";
			this.rdFemale.Size = new System.Drawing.Size(39, 17);
			this.rdFemale.TabIndex = 2;
			this.rdFemale.Text = "Nữ";
			this.rdFemale.UseVisualStyleBackColor = true;
			// 
			// clbFaculty
			// 
			this.clbFaculty.ColumnWidth = 275;
			this.clbFaculty.ContextMenuStrip = this.contextMenuStrip2;
			this.clbFaculty.FormattingEnabled = true;
			this.clbFaculty.Items.AddRange(new object[] {
            "Mạng máy tính",
            "Hệ điều hành",
            "Lập trình CSDL",
            "Lập trình mạng",
            "Đồ án cơ sở",
            "Phương pháp NCKH",
            "Lập trình trên thiết bị di động",
            "An toàn và bảo mật hệ thống"});
			this.clbFaculty.Location = new System.Drawing.Point(169, 245);
			this.clbFaculty.MultiColumn = true;
			this.clbFaculty.Name = "clbFaculty";
			this.clbFaculty.Size = new System.Drawing.Size(554, 64);
			this.clbFaculty.TabIndex = 10;
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeleteRegistration,
            this.tsmiAddRegistration});
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(131, 48);
			// 
			// tsmiDeleteRegistration
			// 
			this.tsmiDeleteRegistration.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsmiDeleteRegistration.Name = "tsmiDeleteRegistration";
			this.tsmiDeleteRegistration.Size = new System.Drawing.Size(130, 22);
			this.tsmiDeleteRegistration.Text = " Xóa môn";
			this.tsmiDeleteRegistration.Click += new System.EventHandler(this.tsmiDeleteRegistration_Click);
			// 
			// tsmiAddRegistration
			// 
			this.tsmiAddRegistration.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsmiAddRegistration.Name = "tsmiAddRegistration";
			this.tsmiAddRegistration.Size = new System.Drawing.Size(130, 22);
			this.tsmiAddRegistration.Text = "Thêm môn";
			this.tsmiAddRegistration.Click += new System.EventHandler(this.tsmiAddRegistration_Click);
			// 
			// lvStudent
			// 
			this.lvStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.LastName,
            this.FirstName,
            this.Gender,
            this.Birthday,
            this.Class,
            this.CMND,
            this.Phone,
            this.Address});
			this.lvStudent.ContextMenuStrip = this.contextMenuStrip1;
			this.lvStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lvStudent.FullRowSelect = true;
			this.lvStudent.GridLines = true;
			this.lvStudent.HideSelection = false;
			this.lvStudent.Location = new System.Drawing.Point(8, 31);
			this.lvStudent.Name = "lvStudent";
			this.lvStudent.Size = new System.Drawing.Size(768, 264);
			this.lvStudent.TabIndex = 0;
			this.lvStudent.UseCompatibleStateImageBehavior = false;
			this.lvStudent.View = System.Windows.Forms.View.Details;
			this.lvStudent.SelectedIndexChanged += new System.EventHandler(this.lvStudent_SelectedIndexChanged);
			// 
			// ID
			// 
			this.ID.Text = "MSSV";
			this.ID.Width = 80;
			// 
			// LastName
			// 
			this.LastName.Text = "Họ và tên lót";
			this.LastName.Width = 130;
			// 
			// FirstName
			// 
			this.FirstName.Text = "Tên";
			this.FirstName.Width = 80;
			// 
			// Gender
			// 
			this.Gender.Text = "Giới tính";
			this.Gender.Width = 70;
			// 
			// Birthday
			// 
			this.Birthday.Text = "Ngày sinh";
			this.Birthday.Width = 90;
			// 
			// Class
			// 
			this.Class.Text = "Lớp";
			this.Class.Width = 70;
			// 
			// CMND
			// 
			this.CMND.Text = "CMND";
			this.CMND.Width = 110;
			// 
			// Phone
			// 
			this.Phone.Text = "Số ĐT";
			this.Phone.Width = 100;
			// 
			// Address
			// 
			this.Address.Text = "Địa chỉ";
			this.Address.Width = 200;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
			// 
			// tsmiDelete
			// 
			this.tsmiDelete.Name = "tsmiDelete";
			this.tsmiDelete.Size = new System.Drawing.Size(94, 22);
			this.tsmiDelete.Text = "Xóa";
			this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
			// 
			// mtbID
			// 
			this.mtbID.Location = new System.Drawing.Point(169, 29);
			this.mtbID.Mask = "0000000";
			this.mtbID.Name = "mtbID";
			this.mtbID.Size = new System.Drawing.Size(207, 20);
			this.mtbID.TabIndex = 0;
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(169, 71);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(207, 20);
			this.txtLastName.TabIndex = 3;
			// 
			// dtpBirthday
			// 
			this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpBirthday.Location = new System.Drawing.Point(169, 117);
			this.dtpBirthday.Name = "dtpBirthday";
			this.dtpBirthday.Size = new System.Drawing.Size(207, 20);
			this.dtpBirthday.TabIndex = 5;
			// 
			// mtbCMND
			// 
			this.mtbCMND.Location = new System.Drawing.Point(169, 164);
			this.mtbCMND.Mask = "000000000";
			this.mtbCMND.Name = "mtbCMND";
			this.mtbCMND.Size = new System.Drawing.Size(207, 20);
			this.mtbCMND.TabIndex = 7;
			// 
			// mtbPhone
			// 
			this.mtbPhone.Location = new System.Drawing.Point(516, 164);
			this.mtbPhone.Mask = "0000.000.000";
			this.mtbPhone.Name = "mtbPhone";
			this.mtbPhone.Size = new System.Drawing.Size(207, 20);
			this.mtbPhone.TabIndex = 8;
			// 
			// txtAdderss
			// 
			this.txtAdderss.Location = new System.Drawing.Point(169, 207);
			this.txtAdderss.Name = "txtAdderss";
			this.txtAdderss.Size = new System.Drawing.Size(554, 20);
			this.txtAdderss.TabIndex = 9;
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Location = new System.Drawing.Point(352, 334);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 13;
			this.btnSearch.Text = "Tìm kiếm";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(466, 334);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 11;
			this.btnAdd.Text = "Thêm mới";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(580, 334);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 12;
			this.btnUpdate.Text = "Cập nhật";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(688, 334);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 14;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(516, 71);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(207, 20);
			this.txtFirstName.TabIndex = 4;
			// 
			// cboClass
			// 
			this.cboClass.FormattingEnabled = true;
			this.cboClass.Items.AddRange(new object[] {
            "CTK40",
            "CTK42",
            "CTK43",
            "CTK44",
            "CTK45"});
			this.cboClass.Location = new System.Drawing.Point(516, 116);
			this.cboClass.Name = "cboClass";
			this.cboClass.Size = new System.Drawing.Size(207, 21);
			this.cboClass.TabIndex = 6;
			// 
			// lbStudentList
			// 
			this.lbStudentList.AutoSize = true;
			this.lbStudentList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbStudentList.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbStudentList.Location = new System.Drawing.Point(8, 4);
			this.lbStudentList.Name = "lbStudentList";
			this.lbStudentList.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
			this.lbStudentList.Size = new System.Drawing.Size(149, 14);
			this.lbStudentList.TabIndex = 0;
			this.lbStudentList.Text = "Danh sách sinh viên";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lvStudent);
			this.panel1.Controls.Add(this.lbStudentList);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 362);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
			this.panel1.Size = new System.Drawing.Size(784, 299);
			this.panel1.TabIndex = 15;
			// 
			// InformationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 661);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.cboClass);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtAdderss);
			this.Controls.Add(this.dtpBirthday);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.mtbPhone);
			this.Controls.Add(this.mtbCMND);
			this.Controls.Add(this.mtbID);
			this.Controls.Add(this.clbFaculty);
			this.Controls.Add(this.rdFemale);
			this.Controls.Add(this.rdMale);
			this.Controls.Add(this.lbPhone);
			this.Controls.Add(this.lbClass);
			this.Controls.Add(this.lbFirstName);
			this.Controls.Add(this.lbGender);
			this.Controls.Add(this.lbRegistrationSubject);
			this.Controls.Add(this.lbAdderss);
			this.Controls.Add(this.lbCMND);
			this.Controls.Add(this.lbBirthday);
			this.Controls.Add(this.lbHoDem);
			this.Controls.Add(this.lbMSSV);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "InformationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nhập thông tin sinh viên";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InformationForm_FormClosing);
			this.Load += new System.EventHandler(this.InformationForm_Load);
			this.contextMenuStrip2.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbMSSV;
		private System.Windows.Forms.Label lbHoDem;
		private System.Windows.Forms.Label lbBirthday;
		private System.Windows.Forms.Label lbCMND;
		private System.Windows.Forms.Label lbAdderss;
		private System.Windows.Forms.Label lbRegistrationSubject;
		private System.Windows.Forms.Label lbGender;
		private System.Windows.Forms.Label lbFirstName;
		private System.Windows.Forms.Label lbClass;
		private System.Windows.Forms.Label lbPhone;
		private System.Windows.Forms.RadioButton rdMale;
		private System.Windows.Forms.RadioButton rdFemale;
		private System.Windows.Forms.CheckedListBox clbFaculty;
		private System.Windows.Forms.MaskedTextBox mtbID;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.DateTimePicker dtpBirthday;
		private System.Windows.Forms.MaskedTextBox mtbCMND;
		private System.Windows.Forms.MaskedTextBox mtbPhone;
		private System.Windows.Forms.TextBox txtAdderss;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.ComboBox cboClass;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.ToolStripMenuItem tsmiDeleteRegistration;
		private System.Windows.Forms.ToolStripMenuItem tsmiAddRegistration;
		private System.Windows.Forms.ListView lvStudent;
		private System.Windows.Forms.ColumnHeader ID;
		private System.Windows.Forms.ColumnHeader LastName;
		private System.Windows.Forms.ColumnHeader FirstName;
		private System.Windows.Forms.ColumnHeader Gender;
		private System.Windows.Forms.ColumnHeader Birthday;
		private System.Windows.Forms.ColumnHeader Class;
		private System.Windows.Forms.ColumnHeader CMND;
		private System.Windows.Forms.ColumnHeader Phone;
		private System.Windows.Forms.ColumnHeader Address;
		private System.Windows.Forms.Label lbStudentList;
		private System.Windows.Forms.Panel panel1;
	}
}

