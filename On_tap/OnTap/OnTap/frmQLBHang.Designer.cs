namespace OnTap
{
	partial class frmQLBHang
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
			this.btnAddCategory = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.cboCategory = new System.Windows.Forms.ComboBox();
			this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
			this.nudDonGia = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.dgvList = new System.Windows.Forms.DataGridView();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAddCategory
			// 
			this.btnAddCategory.Location = new System.Drawing.Point(476, 130);
			this.btnAddCategory.Name = "btnAddCategory";
			this.btnAddCategory.Size = new System.Drawing.Size(75, 23);
			this.btnAddCategory.TabIndex = 0;
			this.btnAddCategory.Text = "Thêm loại";
			this.btnAddCategory.UseVisualStyleBackColor = true;
			this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(349, 251);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(476, 251);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 0;
			this.btnUpdate.Text = "Cập nhật";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// cboCategory
			// 
			this.cboCategory.FormattingEnabled = true;
			this.cboCategory.Location = new System.Drawing.Point(208, 131);
			this.cboCategory.Name = "cboCategory";
			this.cboCategory.Size = new System.Drawing.Size(252, 21);
			this.cboCategory.TabIndex = 1;
			// 
			// nudSoLuong
			// 
			this.nudSoLuong.Location = new System.Drawing.Point(208, 170);
			this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudSoLuong.Name = "nudSoLuong";
			this.nudSoLuong.Size = new System.Drawing.Size(252, 20);
			this.nudSoLuong.TabIndex = 2;
			this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// nudDonGia
			// 
			this.nudDonGia.Location = new System.Drawing.Point(208, 207);
			this.nudDonGia.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.nudDonGia.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.nudDonGia.Name = "nudDonGia";
			this.nudDonGia.Size = new System.Drawing.Size(252, 20);
			this.nudDonGia.TabIndex = 2;
			this.nudDonGia.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Thông tin chi tiết mặt hàng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(54, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Mã mặt hàng";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(54, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Tên mặt hàng";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(54, 135);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Loại mặt hàng";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(54, 174);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "Số lượng";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(54, 211);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "Đơn giá";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(20, 312);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(106, 13);
			this.label9.TabIndex = 3;
			this.label9.Text = "Danh sách mặt hàng";
			// 
			// dgvList
			// 
			this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvList.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvList.Location = new System.Drawing.Point(8, 345);
			this.dgvList.MultiSelect = false;
			this.dgvList.Name = "dgvList";
			this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvList.Size = new System.Drawing.Size(568, 308);
			this.dgvList.TabIndex = 4;
			this.dgvList.SelectionChanged += new System.EventHandler(this.dgvList_SelectionChanged);
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(206, 59);
			this.txtID.Name = "txtID";
			this.txtID.ReadOnly = true;
			this.txtID.Size = new System.Drawing.Size(254, 20);
			this.txtID.TabIndex = 5;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(206, 92);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(254, 20);
			this.txtName.TabIndex = 5;
			// 
			// frmQLBHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 661);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.dgvList);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nudDonGia);
			this.Controls.Add(this.nudSoLuong);
			this.Controls.Add(this.cboCategory);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnAddCategory);
			this.Name = "frmQLBHang";
			this.Padding = new System.Windows.Forms.Padding(8);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý bán hàng shop ABC";
			this.Load += new System.EventHandler(this.frmQLBHang_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAddCategory;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.ComboBox cboCategory;
		private System.Windows.Forms.NumericUpDown nudSoLuong;
		private System.Windows.Forms.NumericUpDown nudDonGia;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DataGridView dgvList;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtName;
	}
}

