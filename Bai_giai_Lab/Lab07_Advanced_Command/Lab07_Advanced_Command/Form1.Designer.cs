namespace Lab07_Advanced_Command
{
	partial class Form1
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
			this.lbCategory = new System.Windows.Forms.Label();
			this.cboCategory = new System.Windows.Forms.ComboBox();
			this.dgvFoodList = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbCatName = new System.Windows.Forms.Label();
			this.lbQuantity = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tmsiCalculateQuality = new System.Windows.Forms.ToolStripMenuItem();
			this.tmsiAddFood = new System.Windows.Forms.ToolStripMenuItem();
			this.tmsiUpdateFood = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
			this.panel1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbCategory
			// 
			this.lbCategory.AutoSize = true;
			this.lbCategory.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCategory.Location = new System.Drawing.Point(128, 33);
			this.lbCategory.Name = "lbCategory";
			this.lbCategory.Size = new System.Drawing.Size(112, 14);
			this.lbCategory.TabIndex = 0;
			this.lbCategory.Text = "Chọn nhóm thức ăn";
			// 
			// cboCategory
			// 
			this.cboCategory.FormattingEnabled = true;
			this.cboCategory.Location = new System.Drawing.Point(265, 30);
			this.cboCategory.Name = "cboCategory";
			this.cboCategory.Size = new System.Drawing.Size(178, 21);
			this.cboCategory.TabIndex = 1;
			this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
			// 
			// dgvFoodList
			// 
			this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFoodList.ContextMenuStrip = this.contextMenuStrip1;
			this.dgvFoodList.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgvFoodList.Location = new System.Drawing.Point(0, 0);
			this.dgvFoodList.Name = "dgvFoodList";
			this.dgvFoodList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvFoodList.Size = new System.Drawing.Size(584, 347);
			this.dgvFoodList.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lbCatName);
			this.panel1.Controls.Add(this.lbQuantity);
			this.panel1.Controls.Add(this.dgvFoodList);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 75);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(584, 386);
			this.panel1.TabIndex = 3;
			// 
			// lbCatName
			// 
			this.lbCatName.AutoSize = true;
			this.lbCatName.Location = new System.Drawing.Point(247, 360);
			this.lbCatName.Name = "lbCatName";
			this.lbCatName.Size = new System.Drawing.Size(22, 13);
			this.lbCatName.TabIndex = 3;
			this.lbCatName.Text = ".....";
			// 
			// lbQuantity
			// 
			this.lbQuantity.AutoSize = true;
			this.lbQuantity.Location = new System.Drawing.Point(77, 359);
			this.lbQuantity.Name = "lbQuantity";
			this.lbQuantity.Size = new System.Drawing.Size(22, 13);
			this.lbQuantity.TabIndex = 3;
			this.lbQuantity.Text = ".....";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(123, 359);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(118, 14);
			this.label3.TabIndex = 0;
			this.label3.Text = "món ăn thuộc nhóm :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 359);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 14);
			this.label2.TabIndex = 0;
			this.label2.Text = "Có tất cả :";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiCalculateQuality,
            this.tmsiAddFood,
            this.tmsiUpdateFood});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(186, 70);
			// 
			// tmsiCalculateQuality
			// 
			this.tmsiCalculateQuality.Name = "tmsiCalculateQuality";
			this.tmsiCalculateQuality.Size = new System.Drawing.Size(185, 22);
			this.tmsiCalculateQuality.Text = "Tính số lượng đã bán";
			this.tmsiCalculateQuality.Click += new System.EventHandler(this.tmsiCalculateQuality_Click);
			// 
			// tmsiAddFood
			// 
			this.tmsiAddFood.Name = "tmsiAddFood";
			this.tmsiAddFood.Size = new System.Drawing.Size(185, 22);
			this.tmsiAddFood.Text = "Thêm đồ ăn";
			this.tmsiAddFood.Click += new System.EventHandler(this.tmsiAddFood_Click);
			// 
			// tmsiUpdateFood
			// 
			this.tmsiUpdateFood.Name = "tmsiUpdateFood";
			this.tmsiUpdateFood.Size = new System.Drawing.Size(185, 22);
			this.tmsiUpdateFood.Text = "Cập nhật";
			this.tmsiUpdateFood.Click += new System.EventHandler(this.tmsiUpdateFood_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 461);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.cboCategory);
			this.Controls.Add(this.lbCategory);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbCategory;
		private System.Windows.Forms.ComboBox cboCategory;
		private System.Windows.Forms.DataGridView dgvFoodList;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbCatName;
		private System.Windows.Forms.Label lbQuantity;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tmsiCalculateQuality;
		private System.Windows.Forms.ToolStripMenuItem tmsiAddFood;
		private System.Windows.Forms.ToolStripMenuItem tmsiUpdateFood;
	}
}

