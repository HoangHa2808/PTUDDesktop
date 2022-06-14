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

namespace OnTap
{
	public partial class frmQLBHang : Form
	{
		public string connStr = ConfigurationManager.ConnectionStrings["QLBanHang"].ConnectionString;
		public frmQLBHang()
		{
			InitializeComponent();
		}

		#region Function
		// Tải ds mặt hàng lên DGV
		private void Display()
		{
			SqlConnection conn = new SqlConnection(connStr);
			SqlCommand comd = conn.CreateCommand();
			comd.CommandText = "SELECT MaMatHang, TenMatHang, LoaiMatHang, SoLuongTon, DonGia " +
								"FROM LOAIMATHANG, MATHANG " +
								"WHERE MaLoai = LoaiMatHang";

			SqlDataAdapter adapter = new SqlDataAdapter(comd);
			DataTable table = new DataTable();

			conn.Open();
			adapter.Fill(table);
			conn.Close();

			dgvList.DataSource = table;
		}


		// tải ds lên comboBox
		private void LoadCategories()
		{

			SqlConnection conn = new SqlConnection(connStr);
			SqlCommand comd = conn.CreateCommand();
			comd.CommandText = "SELECT * " +
								"FROM MATHANG";

			SqlDataAdapter adapter = new SqlDataAdapter(comd);
			DataTable table = new DataTable();

			conn.Open();
			adapter.Fill(table);
			conn.Close();

			dgvList.DataSource = table;

			cboCategory.DisplayMember = "TenMatHang";
			cboCategory.ValueMember = "MaMatHang";
			cboCategory.DataSource = table;
		}
		#endregion

		#region Events

		private void frmQLBHang_Load(object sender, EventArgs e)
		{
			Display();
			LoadCategories();
		}

		private void btnAddCategory_Click(object sender, EventArgs e)
		{
				
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{

			if (txtID.Text != "" && txtName.Text != "" 
				&& cboCategory.SelectedIndex > -1 && nudDonGia.Value > 0)
			{
				SqlConnection conn = new SqlConnection(connStr);
				SqlCommand comd = conn.CreateCommand();
				comd.CommandText = "INSERT INTO MatHang " +
					"VALUES (N'" + txtName.Text + "', " + cboCategory.SelectedValue + "', " + nudDonGia.Value + "'," + nudSoLuong + ")";
				conn.Open();
				comd.ExecuteNonQuery();
				conn.Close();

				MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Display();
			}
			else
			{
				MessageBox.Show("Xảy ra lỗi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (txtID.Text != "" && txtName.Text != "" && cboCategory.SelectedIndex > -1 &&
				nudDonGia.Value > 0)
			{
				SqlConnection conn = new SqlConnection(connStr);
				SqlCommand comd = conn.CreateCommand();
				comd.CommandText = "UPDATE MatHang " +
									"SET TenMatHang = " + txtName.Text + "', " +
									"LoaiMatHang = " + cboCategory.SelectedValue + "', " +
									"SoLuongTon = " + nudSoLuong.Value + "'," +
									"DonGia = " + nudDonGia.Value + " " +
									"WHERE MaMatHang = " + txtID.Text;

				conn.Open();
				comd.ExecuteNonQuery();
				conn.Close();
				MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			else
				MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		#endregion

		private void dgvList_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvList.SelectedRows.Count > 0)
			{
				txtID.Text = dgvList.SelectedRows[0].Cells[0].Value.ToString();
				txtName.Text = dgvList.SelectedRows[0].Cells[1].Value.ToString();
				cboCategory.Text = dgvList.SelectedRows[0].Cells[2].Value.ToString();
				nudSoLuong.Text = dgvList.SelectedRows[0].Cells[3].Value.ToString();
				nudDonGia.Text = dgvList.SelectedRows[0].Cells[4].Value.ToString();
			}
		}

	}
}
