namespace Lab06_Basic_Command
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
			this.btnLoad = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lvCategory = new System.Windows.Forms.ListView();
			this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDetele = new System.Windows.Forms.Button();
			this.lbID = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			this.lbType = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtType = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiViewFood = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(27, 149);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(95, 23);
			this.btnLoad.TabIndex = 0;
			this.btnLoad.Text = "Lấy danh sách";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lvCategory);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 187);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(8, 0, 8, 4);
			this.panel1.Size = new System.Drawing.Size(584, 274);
			this.panel1.TabIndex = 1;
			// 
			// lvCategory
			// 
			this.lvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chType});
			this.lvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvCategory.FullRowSelect = true;
			this.lvCategory.GridLines = true;
			this.lvCategory.HideSelection = false;
			this.lvCategory.Location = new System.Drawing.Point(8, 0);
			this.lvCategory.MultiSelect = false;
			this.lvCategory.Name = "lvCategory";
			this.lvCategory.Size = new System.Drawing.Size(568, 270);
			this.lvCategory.TabIndex = 0;
			this.lvCategory.UseCompatibleStateImageBehavior = false;
			this.lvCategory.View = System.Windows.Forms.View.Details;
			this.lvCategory.Click += new System.EventHandler(this.lvCategory_Click);
			// 
			// chID
			// 
			this.chID.Text = "Mã loại";
			this.chID.Width = 110;
			// 
			// chName
			// 
			this.chName.Text = "Tên loại món ăn";
			this.chName.Width = 240;
			// 
			// chType
			// 
			this.chType.Text = "Loại";
			this.chType.Width = 90;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(300, 149);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Enabled = false;
			this.btnUpdate.Location = new System.Drawing.Point(391, 148);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "Cập nhật";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDetele
			// 
			this.btnDetele.Enabled = false;
			this.btnDetele.Location = new System.Drawing.Point(485, 149);
			this.btnDetele.Name = "btnDetele";
			this.btnDetele.Size = new System.Drawing.Size(75, 23);
			this.btnDetele.TabIndex = 2;
			this.btnDetele.Text = "Xóa";
			this.btnDetele.UseVisualStyleBackColor = true;
			this.btnDetele.Click += new System.EventHandler(this.btnDetele_Click);
			// 
			// lbID
			// 
			this.lbID.AutoSize = true;
			this.lbID.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbID.Location = new System.Drawing.Point(36, 30);
			this.lbID.Name = "lbID";
			this.lbID.Size = new System.Drawing.Size(64, 15);
			this.lbID.TabIndex = 3;
			this.lbID.Text = "Mã nhóm :";
			// 
			// lbName
			// 
			this.lbName.AutoSize = true;
			this.lbName.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbName.Location = new System.Drawing.Point(36, 61);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(109, 15);
			this.lbName.TabIndex = 3;
			this.lbName.Text = "Tên nhóm thức ăn :";
			// 
			// lbType
			// 
			this.lbType.AutoSize = true;
			this.lbType.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbType.Location = new System.Drawing.Point(36, 93);
			this.lbType.Name = "lbType";
			this.lbType.Size = new System.Drawing.Size(35, 15);
			this.lbType.TabIndex = 3;
			this.lbType.Text = "Loại :";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(160, 27);
			this.txtID.Name = "txtID";
			this.txtID.ReadOnly = true;
			this.txtID.Size = new System.Drawing.Size(288, 20);
			this.txtID.TabIndex = 4;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(160, 59);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(288, 20);
			this.txtName.TabIndex = 4;
			// 
			// txtType
			// 
			this.txtType.Location = new System.Drawing.Point(160, 91);
			this.txtType.Name = "txtType";
			this.txtType.Size = new System.Drawing.Size(288, 20);
			this.txtType.TabIndex = 4;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete,
            this.tsmiViewFood});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(200, 48);
			// 
			// tsmiDelete
			// 
			this.tsmiDelete.Name = "tsmiDelete";
			this.tsmiDelete.Size = new System.Drawing.Size(199, 22);
			this.tsmiDelete.Text = "Xóa nhóm sản phẩm";
			this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
			// 
			// tsmiViewFood
			// 
			this.tsmiViewFood.Name = "tsmiViewFood";
			this.tsmiViewFood.Size = new System.Drawing.Size(199, 22);
			this.tsmiViewFood.Text = "Xem danh sách món ăn";
			this.tsmiViewFood.Click += new System.EventHandler(this.tsmiViewFood_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 461);
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.Controls.Add(this.txtType);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.lbType);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.lbID);
			this.Controls.Add(this.btnDetele);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnLoad);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListView lvCategory;
		private System.Windows.Forms.ColumnHeader chID;
		private System.Windows.Forms.ColumnHeader chName;
		private System.Windows.Forms.ColumnHeader chType;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDetele;
		private System.Windows.Forms.Label lbID;
		private System.Windows.Forms.Label lbName;
		private System.Windows.Forms.Label lbType;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtType;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
		private System.Windows.Forms.ToolStripMenuItem tsmiViewFood;
	}
}

