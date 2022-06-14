namespace Lab06_Basic_Command
{
	partial class frmFood
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvFood = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tmsiAddFood = new System.Windows.Forms.ToolStripMenuItem();
			this.tmsiDeleteFood = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
			this.contextMenuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dgvFood);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(8, 4, 8, 0);
			this.panel1.Size = new System.Drawing.Size(684, 361);
			this.panel1.TabIndex = 9;
			// 
			// dgvFood
			// 
			this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFood.ContextMenuStrip = this.contextMenuStrip2;
			this.dgvFood.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvFood.Location = new System.Drawing.Point(8, 4);
			this.dgvFood.Name = "dgvFood";
			this.dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvFood.Size = new System.Drawing.Size(668, 357);
			this.dgvFood.TabIndex = 0;
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiAddFood,
            this.tmsiDeleteFood});
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(138, 48);
			// 
			// tmsiAddFood
			// 
			this.tmsiAddFood.Name = "tmsiAddFood";
			this.tmsiAddFood.Size = new System.Drawing.Size(137, 22);
			this.tmsiAddFood.Text = "Thêm đồ ăn";
			this.tmsiAddFood.Click += new System.EventHandler(this.tmsiAddFood_Click);
			// 
			// tmsiDeleteFood
			// 
			this.tmsiDeleteFood.Name = "tmsiDeleteFood";
			this.tmsiDeleteFood.Size = new System.Drawing.Size(137, 22);
			this.tmsiDeleteFood.Text = "Xóa đồ ăn";
			this.tmsiDeleteFood.Click += new System.EventHandler(this.tmsiDeleteFood_Click);
			// 
			// frmFood
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 361);
			this.Controls.Add(this.panel1);
			this.Name = "frmFood";
			this.Text = "FoodForm";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
			this.contextMenuStrip2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tmsiAddFood;
        private System.Windows.Forms.ToolStripMenuItem tmsiDeleteFood;
    }
}