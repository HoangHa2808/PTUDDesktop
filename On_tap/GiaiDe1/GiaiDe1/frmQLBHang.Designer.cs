namespace GiaiDe1
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
			this.btnAddClien = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSelect = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dgvChiTiet = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtTongTien = new System.Windows.Forms.TextBox();
			this.txtPhaiTra = new System.Windows.Forms.TextBox();
			this.nudSale = new System.Windows.Forms.NumericUpDown();
			this.dtpNgXuat = new System.Windows.Forms.DateTimePicker();
			this.cboKHang = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSale)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAddClien
			// 
			this.btnAddClien.Location = new System.Drawing.Point(611, 75);
			this.btnAddClien.Name = "btnAddClien";
			this.btnAddClien.Size = new System.Drawing.Size(43, 23);
			this.btnAddClien.TabIndex = 1;
			this.btnAddClien.Text = "+";
			this.btnAddClien.UseVisualStyleBackColor = true;
			this.btnAddClien.Click += new System.EventHandler(this.btnAddClien_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(268, 361);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(406, 361);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(81, 23);
			this.btnDelete.TabIndex = 6;
			this.btnDelete.Text = "Hủy hóa đơn";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(542, 361);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(98, 23);
			this.btnSelect.TabIndex = 7;
			this.btnSelect.Text = "Chọn HĐ đã bán";
			this.btnSelect.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(301, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 37);
			this.label1.TabIndex = 1;
			this.label1.Text = "BILL";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(39, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ngày xuất";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(366, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Khách hàng";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(39, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Chi tiết bán hàng";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(39, 320);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Tổng tiền";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(247, 320);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "% Giảm giá";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(490, 320);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 13);
			this.label7.TabIndex = 1;
			this.label7.Text = "Phải trả";
			// 
			// dgvChiTiet
			// 
			this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
			this.dgvChiTiet.Location = new System.Drawing.Point(35, 144);
			this.dgvChiTiet.Name = "dgvChiTiet";
			this.dgvChiTiet.Size = new System.Drawing.Size(619, 147);
			this.dgvChiTiet.TabIndex = 2;
			this.dgvChiTiet.SelectionChanged += new System.EventHandler(this.dgvChiTiet_SelectionChanged);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Tên hàng";
			this.Column1.Name = "Column1";
			this.Column1.Width = 200;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Số lượng";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Đơn giá";
			this.Column3.Name = "Column3";
			this.Column3.Width = 150;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Thành tiền";
			this.Column4.Name = "Column4";
			this.Column4.Width = 150;
			// 
			// txtTongTien
			// 
			this.txtTongTien.Location = new System.Drawing.Point(97, 316);
			this.txtTongTien.Name = "txtTongTien";
			this.txtTongTien.Size = new System.Drawing.Size(101, 20);
			this.txtTongTien.TabIndex = 3;
			// 
			// txtPhaiTra
			// 
			this.txtPhaiTra.Location = new System.Drawing.Point(542, 316);
			this.txtPhaiTra.Name = "txtPhaiTra";
			this.txtPhaiTra.Size = new System.Drawing.Size(112, 20);
			this.txtPhaiTra.TabIndex = 4;
			// 
			// nudSale
			// 
			this.nudSale.Location = new System.Drawing.Point(312, 316);
			this.nudSale.Name = "nudSale";
			this.nudSale.Size = new System.Drawing.Size(120, 20);
			this.nudSale.TabIndex = 4;
			// 
			// dtpNgXuat
			// 
			this.dtpNgXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgXuat.Location = new System.Drawing.Point(100, 76);
			this.dtpNgXuat.Name = "dtpNgXuat";
			this.dtpNgXuat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dtpNgXuat.Size = new System.Drawing.Size(125, 20);
			this.dtpNgXuat.TabIndex = 0;
			// 
			// cboKHang
			// 
			this.cboKHang.FormattingEnabled = true;
			this.cboKHang.Location = new System.Drawing.Point(452, 76);
			this.cboKHang.Name = "cboKHang";
			this.cboKHang.Size = new System.Drawing.Size(153, 21);
			this.cboKHang.TabIndex = 0;
			this.cboKHang.SelectedIndexChanged += new System.EventHandler(this.cboKHang_SelectedIndexChanged);
			// 
			// frmQLBHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 411);
			this.Controls.Add(this.cboKHang);
			this.Controls.Add(this.dtpNgXuat);
			this.Controls.Add(this.nudSale);
			this.Controls.Add(this.txtPhaiTra);
			this.Controls.Add(this.txtTongTien);
			this.Controls.Add(this.dgvChiTiet);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnAddClien);
			this.Name = "frmQLBHang";
			this.Padding = new System.Windows.Forms.Padding(8);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý bán hàng";
			this.Load += new System.EventHandler(this.frmQLBHang_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSale)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAddClien;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dgvChiTiet;
		private System.Windows.Forms.TextBox txtTongTien;
		private System.Windows.Forms.TextBox txtPhaiTra;
		private System.Windows.Forms.NumericUpDown nudSale;
		private System.Windows.Forms.DateTimePicker dtpNgXuat;
		private System.Windows.Forms.ComboBox cboKHang;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
	}
}