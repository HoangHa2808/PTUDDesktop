namespace demobt
{
	partial class Management
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
			this.btnAddFood = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSearchFood = new System.Windows.Forms.TextBox();
			this.dgvListFood = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.cboCategoryFood = new System.Windows.Forms.ComboBox();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.foodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvListFood)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAddFood
			// 
			this.btnAddFood.Location = new System.Drawing.Point(609, 101);
			this.btnAddFood.Name = "btnAddFood";
			this.btnAddFood.Size = new System.Drawing.Size(59, 23);
			this.btnAddFood.TabIndex = 2;
			this.btnAddFood.Text = "+";
			this.btnAddFood.UseVisualStyleBackColor = true;
			this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(151, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhóm món ăn";
			// 
			// txtSearchFood
			// 
			this.txtSearchFood.Location = new System.Drawing.Point(360, 102);
			this.txtSearchFood.Name = "txtSearchFood";
			this.txtSearchFood.Size = new System.Drawing.Size(243, 20);
			this.txtSearchFood.TabIndex = 1;
			this.txtSearchFood.TextChanged += new System.EventHandler(this.txtSearchFood_TextChanged);
			// 
			// dgvListFood
			// 
			this.dgvListFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.foodName,
            this.Unit,
            this.Price,
            this.Category});
			this.dgvListFood.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgvListFood.Location = new System.Drawing.Point(16, 138);
			this.dgvListFood.Name = "dgvListFood";
			this.dgvListFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListFood.Size = new System.Drawing.Size(652, 241);
			this.dgvListFood.TabIndex = 3;
			this.dgvListFood.DoubleClick += new System.EventHandler(this.dgvListFood_DoubleClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Danh sách món ăn";
			// 
			// cboCategoryFood
			// 
			this.cboCategoryFood.FormattingEnabled = true;
			this.cboCategoryFood.Location = new System.Drawing.Point(273, 34);
			this.cboCategoryFood.Name = "cboCategoryFood";
			this.cboCategoryFood.Size = new System.Drawing.Size(269, 21);
			this.cboCategoryFood.TabIndex = 4;
			this.cboCategoryFood.SelectedIndexChanged += new System.EventHandler(this.cboCategoryFood_SelectedIndexChanged);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "MaMonAn";
			this.ID.HeaderText = "Mã";
			this.ID.Name = "ID";
			// 
			// foodName
			// 
			this.foodName.DataPropertyName = "TenMonAn";
			this.foodName.HeaderText = "Tên món ăn";
			this.foodName.Name = "foodName";
			this.foodName.Width = 200;
			// 
			// Unit
			// 
			this.Unit.DataPropertyName = "DonViTinh";
			this.Unit.HeaderText = "Đơn vị tính";
			this.Unit.Name = "Unit";
			this.Unit.Width = 150;
			// 
			// Price
			// 
			this.Price.DataPropertyName = "DonGia";
			this.Price.HeaderText = "Đơn giá";
			this.Price.Name = "Price";
			this.Price.Width = 150;
			// 
			// Category
			// 
			this.Category.DataPropertyName = "TenNhom";
			this.Category.HeaderText = "Nhóm";
			this.Category.Name = "Category";
			this.Category.Width = 200;
			// 
			// Management
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 411);
			this.Controls.Add(this.cboCategoryFood);
			this.Controls.Add(this.dgvListFood);
			this.Controls.Add(this.txtSearchFood);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAddFood);
			this.Name = "Management";
			this.Padding = new System.Windows.Forms.Padding(16, 16, 16, 32);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý";
			this.Load += new System.EventHandler(this.Management_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvListFood)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAddFood;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSearchFood;
		private System.Windows.Forms.DataGridView dgvListFood;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboCategoryFood;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn foodName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn Category;
	}
}