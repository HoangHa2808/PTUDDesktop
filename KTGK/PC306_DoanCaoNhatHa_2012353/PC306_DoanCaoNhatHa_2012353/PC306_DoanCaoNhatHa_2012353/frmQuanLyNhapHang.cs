using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC306_DoanCaoNhatHa_2012353
{
    public partial class frmQuanLyNhapHang : Form
    {
		public string connectionString = ConfigurationManager.ConnectionStrings["QLBanHang"].ConnectionString;
        public frmQuanLyNhapHang()
        {
            InitializeComponent();
        }

		#region Function

		#endregion


		#region Events
		
		private void frmQuanLyNhapHang_Load(object sender, EventArgs e)
		{
			var conn = new SqlConnection(connectionString);
			var comd = conn.CreateCommand();
			comd.CommandText = "SELECT MaNCC, TenNhaCC " +
								"FROM NhaCungCap ";

			var adapter = new SqlDataAdapter(comd);
			var table = new DataTable();

			conn.Open();
			adapter.Fill(table);
			conn.Close();

			cboNhaCungCap.DisplayMember = "TenNhaCC";
			cboNhaCungCap.ValueMember = "MaNCC";
			cboNhaCungCap.DataSource = table;

		}
		
		private void btnAddNhaCC_Click(object sender, EventArgs e)
		{
			frmQuanLyNhaCungCap frm = new frmQuanLyNhaCungCap();
			frm.ShowDialog();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

		}

		private void btnSelect_Click(object sender, EventArgs e)
		{

		}
		#endregion

	}
}
