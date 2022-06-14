namespace Lab05
{
	partial class SearchForm
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
			this.lbClass = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.cbbClass = new System.Windows.Forms.ComboBox();
			this.btnExitSearch = new System.Windows.Forms.Button();
			this.btnSearchStudent = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbID
			// 
			this.lbID.AutoSize = true;
			this.lbID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbID.Location = new System.Drawing.Point(69, 38);
			this.lbID.Name = "lbID";
			this.lbID.Size = new System.Drawing.Size(49, 13);
			this.lbID.TabIndex = 0;
			this.lbID.Text = "MSSV :";
			// 
			// lbName
			// 
			this.lbName.AutoSize = true;
			this.lbName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbName.Location = new System.Drawing.Point(69, 95);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(37, 13);
			this.lbName.TabIndex = 0;
			this.lbName.Text = "Tên :";
			// 
			// lbClass
			// 
			this.lbClass.AutoSize = true;
			this.lbClass.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbClass.Location = new System.Drawing.Point(69, 156);
			this.lbClass.Name = "lbClass";
			this.lbClass.Size = new System.Drawing.Size(36, 13);
			this.lbClass.TabIndex = 0;
			this.lbClass.Text = "Lớp :";
			// 
			// txtID
			// 
			this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtID.Location = new System.Drawing.Point(166, 34);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(242, 21);
			this.txtID.TabIndex = 0;
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(166, 91);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(242, 21);
			this.txtName.TabIndex = 1;
			// 
			// cbbClass
			// 
			this.cbbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbClass.FormattingEnabled = true;
			this.cbbClass.Location = new System.Drawing.Point(166, 152);
			this.cbbClass.Name = "cbbClass";
			this.cbbClass.Size = new System.Drawing.Size(242, 23);
			this.cbbClass.TabIndex = 2;
			// 
			// btnExitSearch
			// 
			this.btnExitSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExitSearch.Location = new System.Drawing.Point(369, 206);
			this.btnExitSearch.Name = "btnExitSearch";
			this.btnExitSearch.Size = new System.Drawing.Size(75, 23);
			this.btnExitSearch.TabIndex = 4;
			this.btnExitSearch.Text = "Thoát";
			this.btnExitSearch.UseVisualStyleBackColor = true;
			this.btnExitSearch.Click += new System.EventHandler(this.btnExitSearch_Click);
			// 
			// btnSearchStudent
			// 
			this.btnSearchStudent.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearchStudent.Location = new System.Drawing.Point(264, 206);
			this.btnSearchStudent.Name = "btnSearchStudent";
			this.btnSearchStudent.Size = new System.Drawing.Size(75, 23);
			this.btnSearchStudent.TabIndex = 3;
			this.btnSearchStudent.Text = "Tìm";
			this.btnSearchStudent.UseVisualStyleBackColor = true;
			this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
			// 
			// SearchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 261);
			this.Controls.Add(this.btnSearchStudent);
			this.Controls.Add(this.btnExitSearch);
			this.Controls.Add(this.cbbClass);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.lbClass);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.lbID);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "SearchForm";
			this.Text = "Tìm kiếm thông tin sinh viên";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbID;
		private System.Windows.Forms.Label lbName;
		private System.Windows.Forms.Label lbClass;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.ComboBox cbbClass;
		private System.Windows.Forms.Button btnExitSearch;
		private System.Windows.Forms.Button btnSearchStudent;
	}
}