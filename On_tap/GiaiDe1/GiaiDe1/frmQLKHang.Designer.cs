namespace GiaiDe1
{
	partial class frmQLKHang
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
			this.btnDefault = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.gbSearch = new System.Windows.Forms.GroupBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.rdPhone = new System.Windows.Forms.RadioButton();
			this.rdName = new System.Windows.Forms.RadioButton();
			this.gbList = new System.Windows.Forms.GroupBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
			this.dgvList = new System.Windows.Forms.DataGridView();
			this.gbSearch.SuspendLayout();
			this.gbList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
			this.SuspendLayout();
			// 
			// btnDefault
			// 
			this.btnDefault.Location = new System.Drawing.Point(255, 139);
			this.btnDefault.Name = "btnDefault";
			this.btnDefault.Size = new System.Drawing.Size(75, 23);
			this.btnDefault.TabIndex = 4;
			this.btnDefault.Text = "Mặc định";
			this.btnDefault.UseVisualStyleBackColor = true;
			this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(374, 139);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(41, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã khách hàng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(41, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên khách hàng";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(41, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Số điện thoại";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(392, 25);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Địa chỉ giao hàng";
			// 
			// gbSearch
			// 
			this.gbSearch.Controls.Add(this.txtSearch);
			this.gbSearch.Controls.Add(this.rdPhone);
			this.gbSearch.Controls.Add(this.rdName);
			this.gbSearch.Location = new System.Drawing.Point(352, 177);
			this.gbSearch.Name = "gbSearch";
			this.gbSearch.Size = new System.Drawing.Size(299, 54);
			this.gbSearch.TabIndex = 5;
			this.gbSearch.TabStop = false;
			this.gbSearch.Text = "Tìm kiếm";
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(193, 23);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(100, 20);
			this.txtSearch.TabIndex = 1;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// rdPhone
			// 
			this.rdPhone.AutoSize = true;
			this.rdPhone.Location = new System.Drawing.Point(105, 25);
			this.rdPhone.Name = "rdPhone";
			this.rdPhone.Size = new System.Drawing.Size(75, 17);
			this.rdPhone.TabIndex = 2;
			this.rdPhone.Text = "Theo SĐT";
			this.rdPhone.UseVisualStyleBackColor = true;
			// 
			// rdName
			// 
			this.rdName.AutoSize = true;
			this.rdName.Checked = true;
			this.rdName.Location = new System.Drawing.Point(14, 25);
			this.rdName.Name = "rdName";
			this.rdName.Size = new System.Drawing.Size(68, 17);
			this.rdName.TabIndex = 0;
			this.rdName.TabStop = true;
			this.rdName.Text = "Theo tên";
			this.rdName.UseVisualStyleBackColor = true;
			// 
			// gbList
			// 
			this.gbList.Controls.Add(this.dgvList);
			this.gbList.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gbList.Location = new System.Drawing.Point(16, 237);
			this.gbList.Name = "gbList";
			this.gbList.Size = new System.Drawing.Size(652, 168);
			this.gbList.TabIndex = 6;
			this.gbList.TabStop = false;
			this.gbList.Text = "Danh sách khách hàng";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(141, 21);
			this.txtID.Name = "txtID";
			this.txtID.ReadOnly = true;
			this.txtID.Size = new System.Drawing.Size(190, 20);
			this.txtID.TabIndex = 0;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(141, 58);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(190, 20);
			this.txtName.TabIndex = 0;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(395, 47);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(256, 70);
			this.txtAddress.TabIndex = 2;
			// 
			// mtbPhone
			// 
			this.mtbPhone.Location = new System.Drawing.Point(141, 97);
			this.mtbPhone.Mask = "0000000000";
			this.mtbPhone.Name = "mtbPhone";
			this.mtbPhone.Size = new System.Drawing.Size(190, 20);
			this.mtbPhone.TabIndex = 1;
			// 
			// dgvList
			// 
			this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvList.Location = new System.Drawing.Point(3, 16);
			this.dgvList.Name = "dgvList";
			this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvList.Size = new System.Drawing.Size(646, 149);
			this.dgvList.TabIndex = 0;
			this.dgvList.SelectionChanged += new System.EventHandler(this.dgvList_SelectionChanged);
			// 
			// frmQLKHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 411);
			this.Controls.Add(this.mtbPhone);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.gbList);
			this.Controls.Add(this.gbSearch);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnDefault);
			this.Name = "frmQLKHang";
			this.Padding = new System.Windows.Forms.Padding(16, 6, 16, 6);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý khách hàng";
			this.Load += new System.EventHandler(this.frmQLKHang_Load);
			this.gbSearch.ResumeLayout(false);
			this.gbSearch.PerformLayout();
			this.gbList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnDefault;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox gbSearch;
		private System.Windows.Forms.RadioButton rdPhone;
		private System.Windows.Forms.RadioButton rdName;
		private System.Windows.Forms.GroupBox gbList;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.MaskedTextBox mtbPhone;
		private System.Windows.Forms.DataGridView dgvList;
	}
}

