namespace Lab05
{
	partial class StudentJsonForm
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
			this.btnJson = new System.Windows.Forms.Button();
			this.btnXml = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnJson
			// 
			this.btnJson.Location = new System.Drawing.Point(70, 99);
			this.btnJson.Name = "btnJson";
			this.btnJson.Size = new System.Drawing.Size(75, 23);
			this.btnJson.TabIndex = 0;
			this.btnJson.Text = "Json";
			this.btnJson.UseVisualStyleBackColor = true;
			this.btnJson.Click += new System.EventHandler(this.btnJson_Click);
			// 
			// btnXml
			// 
			this.btnXml.Location = new System.Drawing.Point(205, 99);
			this.btnXml.Name = "btnXml";
			this.btnXml.Size = new System.Drawing.Size(75, 23);
			this.btnXml.TabIndex = 0;
			this.btnXml.Text = "Xml";
			this.btnXml.UseVisualStyleBackColor = true;
			this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
			// 
			// StudentJsonForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 261);
			this.Controls.Add(this.btnXml);
			this.Controls.Add(this.btnJson);
			this.Name = "StudentJsonForm";
			this.Text = "StudentJson";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnJson;
		private System.Windows.Forms.Button btnXml;
	}
}