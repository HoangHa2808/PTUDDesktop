namespace _2011401_TranBaoLam_Lab04
{
    partial class StudentManagermentForm
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
            this.pbStudentImage = new System.Windows.Forms.PictureBox();
            this.gbStudentInformation = new System.Windows.Forms.GroupBox();
            this.mtxtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.mtxtID = new System.Windows.Forms.MaskedTextBox();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblStudentFullName = new System.Windows.Forms.Label();
            this.lblStudentEmail = new System.Windows.Forms.Label();
            this.lblStudentAddress = new System.Windows.Forms.Label();
            this.lblStudentImage = new System.Windows.Forms.Label();
            this.lblStudentDateOfBirth = new System.Windows.Forms.Label();
            this.lblStudentClass = new System.Windows.Forms.Label();
            this.lblStudentPhoneNumber = new System.Windows.Forms.Label();
            this.lblStudentGender = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbStudentList = new System.Windows.Forms.GroupBox();
            this.lvStudent = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.cmsStudent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDeleteStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReload = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentImage)).BeginInit();
            this.gbStudentInformation.SuspendLayout();
            this.gbStudentList.SuspendLayout();
            this.cmsStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbStudentImage
            // 
            this.pbStudentImage.Location = new System.Drawing.Point(12, 12);
            this.pbStudentImage.Name = "pbStudentImage";
            this.pbStudentImage.Size = new System.Drawing.Size(210, 280);
            this.pbStudentImage.TabIndex = 0;
            this.pbStudentImage.TabStop = false;
            // 
            // gbStudentInformation
            // 
            this.gbStudentInformation.Controls.Add(this.btnExit);
            this.gbStudentInformation.Controls.Add(this.btnSave);
            this.gbStudentInformation.Controls.Add(this.btnDefault);
            this.gbStudentInformation.Controls.Add(this.btnSelectImage);
            this.gbStudentInformation.Controls.Add(this.cboClass);
            this.gbStudentInformation.Controls.Add(this.rdFemale);
            this.gbStudentInformation.Controls.Add(this.rdMale);
            this.gbStudentInformation.Controls.Add(this.dtpDateOfBirth);
            this.gbStudentInformation.Controls.Add(this.mtxtPhoneNumber);
            this.gbStudentInformation.Controls.Add(this.mtxtID);
            this.gbStudentInformation.Controls.Add(this.txtImage);
            this.gbStudentInformation.Controls.Add(this.txtEmail);
            this.gbStudentInformation.Controls.Add(this.txtAddress);
            this.gbStudentInformation.Controls.Add(this.txtFullName);
            this.gbStudentInformation.Controls.Add(this.lblStudentFullName);
            this.gbStudentInformation.Controls.Add(this.lblStudentEmail);
            this.gbStudentInformation.Controls.Add(this.lblStudentAddress);
            this.gbStudentInformation.Controls.Add(this.lblStudentImage);
            this.gbStudentInformation.Controls.Add(this.lblStudentDateOfBirth);
            this.gbStudentInformation.Controls.Add(this.lblStudentClass);
            this.gbStudentInformation.Controls.Add(this.lblStudentPhoneNumber);
            this.gbStudentInformation.Controls.Add(this.lblStudentGender);
            this.gbStudentInformation.Controls.Add(this.lblStudentID);
            this.gbStudentInformation.Location = new System.Drawing.Point(228, 12);
            this.gbStudentInformation.Name = "gbStudentInformation";
            this.gbStudentInformation.Size = new System.Drawing.Size(704, 280);
            this.gbStudentInformation.TabIndex = 1;
            this.gbStudentInformation.TabStop = false;
            this.gbStudentInformation.Text = "Thông tin sinh viên";
            // 
            // mtxtPhoneNumber
            // 
            this.mtxtPhoneNumber.Location = new System.Drawing.Point(532, 159);
            this.mtxtPhoneNumber.Mask = "0000.000.000";
            this.mtxtPhoneNumber.Name = "mtxtPhoneNumber";
            this.mtxtPhoneNumber.Size = new System.Drawing.Size(154, 20);
            this.mtxtPhoneNumber.TabIndex = 8;
            // 
            // mtxtID
            // 
            this.mtxtID.Location = new System.Drawing.Point(92, 25);
            this.mtxtID.Mask = "0000000";
            this.mtxtID.Name = "mtxtID";
            this.mtxtID.Size = new System.Drawing.Size(315, 20);
            this.mtxtID.TabIndex = 0;
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(92, 204);
            this.txtImage.Name = "txtImage";
            this.txtImage.ReadOnly = true;
            this.txtImage.Size = new System.Drawing.Size(491, 20);
            this.txtImage.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(92, 115);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(315, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(92, 159);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(315, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(92, 70);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(315, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // lblStudentFullName
            // 
            this.lblStudentFullName.AutoSize = true;
            this.lblStudentFullName.Location = new System.Drawing.Point(18, 73);
            this.lblStudentFullName.Name = "lblStudentFullName";
            this.lblStudentFullName.Size = new System.Drawing.Size(54, 13);
            this.lblStudentFullName.TabIndex = 8;
            this.lblStudentFullName.Text = "Họ và tên";
            // 
            // lblStudentEmail
            // 
            this.lblStudentEmail.AutoSize = true;
            this.lblStudentEmail.Location = new System.Drawing.Point(18, 118);
            this.lblStudentEmail.Name = "lblStudentEmail";
            this.lblStudentEmail.Size = new System.Drawing.Size(32, 13);
            this.lblStudentEmail.TabIndex = 7;
            this.lblStudentEmail.Text = "Email";
            // 
            // lblStudentAddress
            // 
            this.lblStudentAddress.AutoSize = true;
            this.lblStudentAddress.Location = new System.Drawing.Point(18, 162);
            this.lblStudentAddress.Name = "lblStudentAddress";
            this.lblStudentAddress.Size = new System.Drawing.Size(40, 13);
            this.lblStudentAddress.TabIndex = 6;
            this.lblStudentAddress.Text = "Địa chỉ";
            // 
            // lblStudentImage
            // 
            this.lblStudentImage.AutoSize = true;
            this.lblStudentImage.Location = new System.Drawing.Point(18, 207);
            this.lblStudentImage.Name = "lblStudentImage";
            this.lblStudentImage.Size = new System.Drawing.Size(29, 13);
            this.lblStudentImage.TabIndex = 5;
            this.lblStudentImage.Text = "Hình";
            // 
            // lblStudentDateOfBirth
            // 
            this.lblStudentDateOfBirth.AutoSize = true;
            this.lblStudentDateOfBirth.Location = new System.Drawing.Point(439, 25);
            this.lblStudentDateOfBirth.Name = "lblStudentDateOfBirth";
            this.lblStudentDateOfBirth.Size = new System.Drawing.Size(54, 13);
            this.lblStudentDateOfBirth.TabIndex = 4;
            this.lblStudentDateOfBirth.Text = "Ngày sinh";
            // 
            // lblStudentClass
            // 
            this.lblStudentClass.AutoSize = true;
            this.lblStudentClass.Location = new System.Drawing.Point(439, 118);
            this.lblStudentClass.Name = "lblStudentClass";
            this.lblStudentClass.Size = new System.Drawing.Size(25, 13);
            this.lblStudentClass.TabIndex = 3;
            this.lblStudentClass.Text = "Lớp";
            // 
            // lblStudentPhoneNumber
            // 
            this.lblStudentPhoneNumber.AutoSize = true;
            this.lblStudentPhoneNumber.Location = new System.Drawing.Point(439, 162);
            this.lblStudentPhoneNumber.Name = "lblStudentPhoneNumber";
            this.lblStudentPhoneNumber.Size = new System.Drawing.Size(70, 13);
            this.lblStudentPhoneNumber.TabIndex = 2;
            this.lblStudentPhoneNumber.Text = "Số điện thoại";
            // 
            // lblStudentGender
            // 
            this.lblStudentGender.AutoSize = true;
            this.lblStudentGender.Location = new System.Drawing.Point(439, 73);
            this.lblStudentGender.Name = "lblStudentGender";
            this.lblStudentGender.Size = new System.Drawing.Size(28, 13);
            this.lblStudentGender.TabIndex = 1;
            this.lblStudentGender.Text = "Phái";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(18, 28);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(37, 13);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "MSSV";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(532, 25);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(154, 20);
            this.dtpDateOfBirth.TabIndex = 4;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Checked = true;
            this.rdMale.Location = new System.Drawing.Point(532, 71);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(47, 17);
            this.rdMale.TabIndex = 5;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Nam";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(611, 71);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(39, 17);
            this.rdFemale.TabIndex = 6;
            this.rdFemale.Text = "Nữ";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Items.AddRange(new object[] {
            "CTK43",
            "CTK44",
            "CTK45",
            "CTK46"});
            this.cboClass.Location = new System.Drawing.Point(532, 112);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(154, 21);
            this.cboClass.TabIndex = 7;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(611, 201);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(75, 23);
            this.btnSelectImage.TabIndex = 9;
            this.btnSelectImage.Text = "Chọn hình";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(404, 239);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(75, 23);
            this.btnDefault.TabIndex = 10;
            this.btnDefault.Text = "Mặc định";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(508, 239);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(611, 239);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbStudentList
            // 
            this.gbStudentList.Controls.Add(this.lvStudent);
            this.gbStudentList.Location = new System.Drawing.Point(12, 298);
            this.gbStudentList.Name = "gbStudentList";
            this.gbStudentList.Size = new System.Drawing.Size(920, 251);
            this.gbStudentList.TabIndex = 2;
            this.gbStudentList.TabStop = false;
            this.gbStudentList.Text = "Danh sách sinh viên";
            // 
            // lvStudent
            // 
            this.lvStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvStudent.ContextMenuStrip = this.cmsStudent;
            this.lvStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvStudent.FullRowSelect = true;
            this.lvStudent.HideSelection = false;
            this.lvStudent.Location = new System.Drawing.Point(3, 16);
            this.lvStudent.Name = "lvStudent";
            this.lvStudent.Size = new System.Drawing.Size(914, 232);
            this.lvStudent.TabIndex = 0;
            this.lvStudent.UseCompatibleStateImageBehavior = false;
            this.lvStudent.View = System.Windows.Forms.View.Details;
            this.lvStudent.SelectedIndexChanged += new System.EventHandler(this.lvStudent_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MSSV";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phái";
            this.columnHeader3.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày sinh";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Lớp";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số điện thoại";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Email";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Địa chỉ";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Hình";
            this.columnHeader9.Width = 110;
            // 
            // ofdImage
            // 
            this.ofdImage.FileName = "openFileDialog1";
            this.ofdImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            // 
            // cmsStudent
            // 
            this.cmsStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeleteStudent,
            this.tsmiReload});
            this.cmsStudent.Name = "cmsStudent";
            this.cmsStudent.Size = new System.Drawing.Size(162, 48);
            // 
            // tsmiDeleteStudent
            // 
            this.tsmiDeleteStudent.Name = "tsmiDeleteStudent";
            this.tsmiDeleteStudent.Size = new System.Drawing.Size(180, 22);
            this.tsmiDeleteStudent.Text = "Xóa";
            this.tsmiDeleteStudent.Click += new System.EventHandler(this.tsmiDeleteStudent_Click);
            // 
            // tsmiReload
            // 
            this.tsmiReload.Name = "tsmiReload";
            this.tsmiReload.Size = new System.Drawing.Size(180, 22);
            this.tsmiReload.Text = "Tải lại danh sách";
            this.tsmiReload.Click += new System.EventHandler(this.tsmiReload_Click);
            // 
            // StudentManagermentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.gbStudentList);
            this.Controls.Add(this.gbStudentInformation);
            this.Controls.Add(this.pbStudentImage);
            this.Name = "StudentManagermentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thông tin sinh viên khoa CNTT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentManagermentForm_FormClosing);
            this.Load += new System.EventHandler(this.StudentManagermentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentImage)).EndInit();
            this.gbStudentInformation.ResumeLayout(false);
            this.gbStudentInformation.PerformLayout();
            this.gbStudentList.ResumeLayout(false);
            this.cmsStudent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbStudentImage;
        private System.Windows.Forms.GroupBox gbStudentInformation;
        private System.Windows.Forms.MaskedTextBox mtxtPhoneNumber;
        private System.Windows.Forms.MaskedTextBox mtxtID;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblStudentFullName;
        private System.Windows.Forms.Label lblStudentEmail;
        private System.Windows.Forms.Label lblStudentAddress;
        private System.Windows.Forms.Label lblStudentImage;
        private System.Windows.Forms.Label lblStudentDateOfBirth;
        private System.Windows.Forms.Label lblStudentClass;
        private System.Windows.Forms.Label lblStudentPhoneNumber;
        private System.Windows.Forms.Label lblStudentGender;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.GroupBox gbStudentList;
        private System.Windows.Forms.ListView lvStudent;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.ContextMenuStrip cmsStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmiReload;
    }
}

