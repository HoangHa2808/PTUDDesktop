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

namespace GiaiDe1
{
	public partial class frmQLBHang : Form
	{
		public string connStr = ConfigurationManager.ConnectionStrings["QLBanHang"].ConnectionString;
		public frmQLBHang()
		{
			InitializeComponent();
		}

		#region Function

		#endregion

		#region Events
		private void btnAddClien_Click(object sender, EventArgs e)
		{
			frmQLKHang frm = new frmQLKHang();
			frm.ShowDialog();
		}

		private void frmQLBHang_Load(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(connStr);
			SqlCommand comd = conn.CreateCommand();
			comd.CommandText = "SELECT MaKH, TenKH " +
								"FROM KhachHang";

			SqlDataAdapter adapter = new SqlDataAdapter(comd);
			DataTable table = new DataTable();

			conn.Open();
			adapter.Fill(table);
			conn.Close();

			cboKHang.DisplayMember = "TenKH";
			cboKHang.ValueMember = "MaKH";
			cboKHang.DataSource = table;
		}

		private void dgvChiTiet_SelectionChanged(object sender, EventArgs e)
		{
			//SqlConnection conn = new SqlConnection(connStr);
			//SqlCommand comd = conn.CreateCommand();
			//comd.CommandText = "SELECT TenMatHang, SoLuong, DonGia, DonGia * SoLuong AS ThanhTien " +
			//					"FROM MatHang";

			//SqlDataAdapter adapter = new SqlDataAdapter(comd);
			//DataTable table = new DataTable();

			//conn.Open();
			//adapter.Fill(table);
			//conn.Close();

			//cboKHang.DisplayMember = "TenMatHang";
			//cboKHang.ValueMember = "MaMatHang";
			//cboKHang.DataSource = table;
			
		}

		#endregion

		private void cboKHang_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
