namespace demobt
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtIDFood = new System.Windows.Forms.TextBox();
			this.txtFoodName = new System.Windows.Forms.TextBox();
			this.txtUnit = new System.Windows.Forms.TextBox();
			this.cboCategory = new System.Windows.Forms.ComboBox();
			this.nudPrice = new System.Windows.Forms.NumericUpDown();
			this.btnSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã món ăn/ uống";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên món ăn/ uống";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Đơn vị tính";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 149);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Đơn giá";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(19, 190);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Nhóm món ăn";
			// 
			// txtIDFood
			// 
			this.txtIDFood.Location = new System.Drawing.Point(132, 17);
			this.txtIDFood.Name = "txtIDFood";
			this.txtIDFood.ReadOnly = true;
			this.txtIDFood.Size = new System.Drawing.Size(275, 20);
			this.txtIDFood.TabIndex = 0;
			this.txtIDFood.Text = "0";
			// 
			// txtFoodName
			// 
			this.txtFoodName.Location = new System.Drawing.Point(132, 61);
			this.txtFoodName.Name = "txtFoodName";
			this.txtFoodName.Size = new System.Drawing.Size(275, 20);
			this.txtFoodName.TabIndex = 1;
			// 
			// txtUnit
			// 
			this.txtUnit.Location = new System.Drawing.Point(132, 104);
			this.txtUnit.Name = "txtUnit";
			this.txtUnit.Size = new System.Drawing.Size(275, 20);
			this.txtUnit.TabIndex = 2;
			// 
			// cboCategory
			// 
			this.cboCategory.FormattingEnabled = true;
			this.cboCategory.Location = new System.Drawing.Point(132, 186);
			this.cboCategory.Name = "cboCategory";
			this.cboCategory.Size = new System.Drawing.Size(275, 21);
			this.cboCategory.TabIndex = 4;
			// 
			// nudPrice
			// 
			this.nudPrice.Location = new System.Drawing.Point(132, 145);
			this.nudPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.nudPrice.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudPrice.Name = "nudPrice";
			this.nudPrice.Size = new System.Drawing.Size(275, 20);
			this.nudPrice.TabIndex = 3;
			this.nudPrice.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(180, 220);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 32);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 261);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.nudPrice);
			this.Controls.Add(this.cboCategory);
			this.Controls.Add(this.txtUnit);
			this.Controls.Add(this.txtFoodName);
			this.Controls.Add(this.txtIDFood);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtIDFood;
		private System.Windows.Forms.TextBox txtFoodName;
		private System.Windows.Forms.TextBox txtUnit;
		private System.Windows.Forms.ComboBox cboCategory;
		private System.Windows.Forms.NumericUpDown nudPrice;
		private System.Windows.Forms.Button btnSave;
	}
}

