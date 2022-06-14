namespace PC306_DoanCaoNhatHa_2012353
{
    partial class frmQuanLyNhaCungCap
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
			this.lbID = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			this.lbAddress = new System.Windows.Forms.Label();
			this.lbPhone = new System.Windows.Forms.Label();
			this.lbMota = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.txtMoTa = new System.Windows.Forms.TextBox();
			this.btnDefault = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.gbSearch = new System.Windows.Forms.GroupBox();
			this.rdPhone = new System.Windows.Forms.RadioButton();
			this.rdName = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.gbList = new System.Windows.Forms.GroupBox();
			this.lvList = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
			this.gbSearch.SuspendLayout();
			this.panel1.SuspendLayout();
			this.gbList.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbID
			// 
			this.lbID.AutoSize = true;
			this.lbID.Location = new System.Drawing.Point(43, 42);
			this.lbID.Name = "lbID";
			this.lbID.Size = new System.Drawing.Size(97, 13);
			this.lbID.TabIndex = 0;
			this.lbID.Text = "Mã nhà cung cấp :";
			// 
			// lbName
			// 
			this.lbName.AutoSize = true;
			this.lbName.Location = new System.Drawing.Point(43, 83);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(101, 13);
			this.lbName.TabIndex = 0;
			this.lbName.Text = "Tên nhà cung cấp :";
			// 
			// lbAddress
			// 
			this.lbAddress.AutoSize = true;
			this.lbAddress.Location = new System.Drawing.Point(43, 127);
			this.lbAddress.Name = "lbAddress";
			this.lbAddress.Size = new System.Drawing.Size(49, 13);
			this.lbAddress.TabIndex = 0;
			this.lbAddress.Text = "Địa chỉ : ";
			// 
			// lbPhone
			// 
			this.lbPhone.AutoSize = true;
			this.lbPhone.Location = new System.Drawing.Point(364, 42);
			this.lbPhone.Name = "lbPhone";
			this.lbPhone.Size = new System.Drawing.Size(76, 13);
			this.lbPhone.TabIndex = 0;
			this.lbPhone.Text = "Số điện thoại :";
			// 
			// lbMota
			// 
			this.lbMota.AutoSize = true;
			this.lbMota.Location = new System.Drawing.Point(364, 79);
			this.lbMota.Name = "lbMota";
			this.lbMota.Size = new System.Drawing.Size(40, 13);
			this.lbMota.TabIndex = 0;
			this.lbMota.Text = "Mô tả :";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(151, 38);
			this.txtID.Name = "txtID";
			this.txtID.ReadOnly = true;
			this.txtID.Size = new System.Drawing.Size(181, 20);
			this.txtID.TabIndex = 0;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(151, 79);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(181, 20);
			this.txtName.TabIndex = 1;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(151, 123);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(181, 20);
			this.txtAddress.TabIndex = 2;
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(187, 25);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(100, 20);
			this.txtSearch.TabIndex = 2;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// txtMoTa
			// 
			this.txtMoTa.Location = new System.Drawing.Point(446, 79);
			this.txtMoTa.Multiline = true;
			this.txtMoTa.Name = "txtMoTa";
			this.txtMoTa.Size = new System.Drawing.Size(195, 75);
			this.txtMoTa.TabIndex = 4;
			// 
			// btnDefault
			// 
			this.btnDefault.Location = new System.Drawing.Point(213, 171);
			this.btnDefault.Name = "btnDefault";
			this.btnDefault.Size = new System.Drawing.Size(75, 23);
			this.btnDefault.TabIndex = 6;
			this.btnDefault.Text = "Mặc định";
			this.btnDefault.UseVisualStyleBackColor = true;
			this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(360, 171);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// gbSearch
			// 
			this.gbSearch.Controls.Add(this.rdPhone);
			this.gbSearch.Controls.Add(this.rdName);
			this.gbSearch.Controls.Add(this.txtSearch);
			this.gbSearch.Location = new System.Drawing.Point(335, 211);
			this.gbSearch.Name = "gbSearch";
			this.gbSearch.Size = new System.Drawing.Size(306, 59);
			this.gbSearch.TabIndex = 7;
			this.gbSearch.TabStop = false;
			this.gbSearch.Text = "Tìm kiếm";
			// 
			// rdPhone
			// 
			this.rdPhone.AutoSize = true;
			this.rdPhone.Location = new System.Drawing.Point(96, 25);
			this.rdPhone.Name = "rdPhone";
			this.rdPhone.Size = new System.Drawing.Size(75, 17);
			this.rdPhone.TabIndex = 1;
			this.rdPhone.TabStop = true;
			this.rdPhone.Text = "Theo SĐT";
			this.rdPhone.UseVisualStyleBackColor = true;
			// 
			// rdName
			// 
			this.rdName.AutoSize = true;
			this.rdName.Checked = true;
			this.rdName.Location = new System.Drawing.Point(6, 25);
			this.rdName.Name = "rdName";
			this.rdName.Size = new System.Drawing.Size(68, 17);
			this.rdName.TabIndex = 0;
			this.rdName.TabStop = true;
			this.rdName.Text = "Theo tên";
			this.rdName.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.gbList);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 276);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(684, 235);
			this.panel1.TabIndex = 4;
			// 
			// gbList
			// 
			this.gbList.Controls.Add(this.lvList);
			this.gbList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbList.Location = new System.Drawing.Point(0, 0);
			this.gbList.Name = "gbList";
			this.gbList.Size = new System.Drawing.Size(684, 235);
			this.gbList.TabIndex = 0;
			this.gbList.TabStop = false;
			this.gbList.Text = "Danh sách nhà cung cấp";
			// 
			// lvList
			// 
			this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.lvList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvList.FullRowSelect = true;
			this.lvList.HideSelection = false;
			this.lvList.Location = new System.Drawing.Point(3, 16);
			this.lvList.Name = "lvList";
			this.lvList.Size = new System.Drawing.Size(678, 216);
			this.lvList.TabIndex = 0;
			this.lvList.UseCompatibleStateImageBehavior = false;
			this.lvList.View = System.Windows.Forms.View.Details;
			this.lvList.SelectedIndexChanged += new System.EventHandler(this.lvList_SelectedIndexChanged);
			this.lvList.Click += new System.EventHandler(this.lvList_Click);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Mã nhà cc";
			this.columnHeader1.Width = 80;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Tên nhà cc";
			this.columnHeader2.Width = 200;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Địa chỉ";
			this.columnHeader3.Width = 250;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Số điện thoại";
			this.columnHeader4.Width = 90;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Mô tả";
			this.columnHeader5.Width = 300;
			// 
			// mtbPhone
			// 
			this.mtbPhone.Location = new System.Drawing.Point(446, 38);
			this.mtbPhone.Mask = "0000000000";
			this.mtbPhone.Name = "mtbPhone";
			this.mtbPhone.Size = new System.Drawing.Size(195, 20);
			this.mtbPhone.TabIndex = 3;
			// 
			// frmQuanLyNhaCungCap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 511);
			this.Controls.Add(this.mtbPhone);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.gbSearch);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnDefault);
			this.Controls.Add(this.txtMoTa);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.lbMota);
			this.Controls.Add(this.lbPhone);
			this.Controls.Add(this.lbAddress);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.lbID);
			this.Name = "frmQuanLyNhaCungCap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý nhà cung cấp";
			this.Load += new System.EventHandler(this.frmQuanLyNhaCungCap_Load);
			this.gbSearch.ResumeLayout(false);
			this.gbSearch.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.gbList.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbMota;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.RadioButton rdPhone;
        private System.Windows.Forms.RadioButton rdName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

