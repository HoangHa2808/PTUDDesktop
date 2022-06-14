namespace PC306_DoanCaoNhatHa_2012353
{
    partial class frmQuanLyNhapHang
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
			this.lbText = new System.Windows.Forms.Label();
			this.lbDate = new System.Windows.Forms.Label();
			this.lbNhaCC = new System.Windows.Forms.Label();
			this.lbTongTien = new System.Windows.Forms.Label();
			this.lbSale = new System.Windows.Forms.Label();
			this.lbPhaiTra = new System.Windows.Forms.Label();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
			this.btnAddNhaCC = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSelect = new System.Windows.Forms.Button();
			this.nudSale = new System.Windows.Forms.NumericUpDown();
			this.txtTongTien = new System.Windows.Forms.TextBox();
			this.txtPhaiTra = new System.Windows.Forms.TextBox();
			this.gbChiTiet = new System.Windows.Forms.GroupBox();
			this.dgvChiTiet = new System.Windows.Forms.DataGridView();
			this.Hangname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.nudSale)).BeginInit();
			this.gbChiTiet.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
			this.SuspendLayout();
			// 
			// lbText
			// 
			this.lbText.AutoSize = true;
			this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbText.Location = new System.Drawing.Point(159, 9);
			this.lbText.Name = "lbText";
			this.lbText.Size = new System.Drawing.Size(392, 39);
			this.lbText.TabIndex = 0;
			this.lbText.Text = "HÓA ĐƠN NHẬP HÀNG";
			// 
			// lbDate
			// 
			this.lbDate.AutoSize = true;
			this.lbDate.Location = new System.Drawing.Point(66, 83);
			this.lbDate.Name = "lbDate";
			this.lbDate.Size = new System.Drawing.Size(65, 13);
			this.lbDate.TabIndex = 1;
			this.lbDate.Text = "Ngày nhập :";
			// 
			// lbNhaCC
			// 
			this.lbNhaCC.AutoSize = true;
			this.lbNhaCC.Location = new System.Drawing.Point(356, 83);
			this.lbNhaCC.Name = "lbNhaCC";
			this.lbNhaCC.Size = new System.Drawing.Size(81, 13);
			this.lbNhaCC.TabIndex = 1;
			this.lbNhaCC.Text = "Nhà cung cấp :";
			// 
			// lbTongTien
			// 
			this.lbTongTien.AutoSize = true;
			this.lbTongTien.Location = new System.Drawing.Point(66, 355);
			this.lbTongTien.Name = "lbTongTien";
			this.lbTongTien.Size = new System.Drawing.Size(58, 13);
			this.lbTongTien.TabIndex = 1;
			this.lbTongTien.Text = "Tổng tiền :";
			// 
			// lbSale
			// 
			this.lbSale.AutoSize = true;
			this.lbSale.Location = new System.Drawing.Point(277, 355);
			this.lbSale.Name = "lbSale";
			this.lbSale.Size = new System.Drawing.Size(65, 13);
			this.lbSale.TabIndex = 1;
			this.lbSale.Text = "% Giảm giá :";
			// 
			// lbPhaiTra
			// 
			this.lbPhaiTra.AutoSize = true;
			this.lbPhaiTra.Location = new System.Drawing.Point(504, 355);
			this.lbPhaiTra.Name = "lbPhaiTra";
			this.lbPhaiTra.Size = new System.Drawing.Size(49, 13);
			this.lbPhaiTra.TabIndex = 1;
			this.lbPhaiTra.Text = "Phải trả :";
			// 
			// dtpDate
			// 
			this.dtpDate.Enabled = false;
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDate.Location = new System.Drawing.Point(137, 79);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(160, 20);
			this.dtpDate.TabIndex = 2;
			// 
			// cboNhaCungCap
			// 
			this.cboNhaCungCap.FormattingEnabled = true;
			this.cboNhaCungCap.Location = new System.Drawing.Point(451, 79);
			this.cboNhaCungCap.Name = "cboNhaCungCap";
			this.cboNhaCungCap.Size = new System.Drawing.Size(121, 21);
			this.cboNhaCungCap.TabIndex = 3;
			// 
			// btnAddNhaCC
			// 
			this.btnAddNhaCC.Location = new System.Drawing.Point(601, 78);
			this.btnAddNhaCC.Name = "btnAddNhaCC";
			this.btnAddNhaCC.Size = new System.Drawing.Size(49, 23);
			this.btnAddNhaCC.TabIndex = 4;
			this.btnAddNhaCC.Text = "+";
			this.btnAddNhaCC.UseVisualStyleBackColor = true;
			this.btnAddNhaCC.Click += new System.EventHandler(this.btnAddNhaCC_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(272, 412);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(397, 412);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(81, 23);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Hủy hóa đơn";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(522, 412);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(89, 23);
			this.btnSelect.TabIndex = 4;
			this.btnSelect.Text = "Chọn HĐ nhập";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// nudSale
			// 
			this.nudSale.Location = new System.Drawing.Point(342, 351);
			this.nudSale.Name = "nudSale";
			this.nudSale.Size = new System.Drawing.Size(120, 20);
			this.nudSale.TabIndex = 5;
			// 
			// txtTongTien
			// 
			this.txtTongTien.Location = new System.Drawing.Point(124, 351);
			this.txtTongTien.Name = "txtTongTien";
			this.txtTongTien.Size = new System.Drawing.Size(100, 20);
			this.txtTongTien.TabIndex = 6;
			// 
			// txtPhaiTra
			// 
			this.txtPhaiTra.Location = new System.Drawing.Point(553, 351);
			this.txtPhaiTra.Name = "txtPhaiTra";
			this.txtPhaiTra.Size = new System.Drawing.Size(100, 20);
			this.txtPhaiTra.TabIndex = 6;
			// 
			// gbChiTiet
			// 
			this.gbChiTiet.Controls.Add(this.dgvChiTiet);
			this.gbChiTiet.Location = new System.Drawing.Point(26, 138);
			this.gbChiTiet.Name = "gbChiTiet";
			this.gbChiTiet.Size = new System.Drawing.Size(627, 189);
			this.gbChiTiet.TabIndex = 7;
			this.gbChiTiet.TabStop = false;
			this.gbChiTiet.Text = "Chi tiết hàng nhập";
			// 
			// dgvChiTiet
			// 
			this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hangname,
            this.Column1,
            this.Column2,
            this.Column3});
			this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgvChiTiet.Location = new System.Drawing.Point(3, 19);
			this.dgvChiTiet.Name = "dgvChiTiet";
			this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvChiTiet.Size = new System.Drawing.Size(621, 167);
			this.dgvChiTiet.TabIndex = 0;
			// 
			// Hangname
			// 
			this.Hangname.HeaderText = "Tên hàng";
			this.Hangname.Name = "Hangname";
			this.Hangname.Width = 200;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Số lượng";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Đơn giá nhập";
			this.Column2.Name = "Column2";
			this.Column2.Width = 150;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Thành tiền";
			this.Column3.Name = "Column3";
			this.Column3.Width = 150;
			// 
			// frmQuanLyNhapHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 461);
			this.Controls.Add(this.gbChiTiet);
			this.Controls.Add(this.txtPhaiTra);
			this.Controls.Add(this.txtTongTien);
			this.Controls.Add(this.nudSale);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnAddNhaCC);
			this.Controls.Add(this.cboNhaCungCap);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.lbPhaiTra);
			this.Controls.Add(this.lbSale);
			this.Controls.Add(this.lbTongTien);
			this.Controls.Add(this.lbNhaCC);
			this.Controls.Add(this.lbDate);
			this.Controls.Add(this.lbText);
			this.Name = "frmQuanLyNhapHang";
			this.Text = "Quản lý hàng nhập";
			this.Load += new System.EventHandler(this.frmQuanLyNhapHang_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudSale)).EndInit();
			this.gbChiTiet.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbNhaCC;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label lbSale;
        private System.Windows.Forms.Label lbPhaiTra;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.Button btnAddNhaCC;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.NumericUpDown nudSale;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtPhaiTra;
        private System.Windows.Forms.GroupBox gbChiTiet;
        private System.Windows.Forms.DataGridView dgvChiTiet;
		private System.Windows.Forms.DataGridViewTextBoxColumn Hangname;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
	}
}