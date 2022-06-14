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
	public partial class frmQLKHang : Form
	{
		public string connectionString = ConfigurationManager.ConnectionStrings["QLBanHang"].ConnectionString;
		public frmQLKHang()
		{
			InitializeComponent();
		}

		#region Function
		private void Display()
		{
			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand comd = conn.CreateCommand();
			comd.CommandText = "SELECT MaKH, TenKH, SoDienThoai, DiaChiGH " +
								"FROM KhachHang";

			SqlDataAdapter adapter = new SqlDataAdapter(comd);
			DataTable table = new DataTable();

			conn.Open();
			adapter.Fill(table);
			conn.Close();
			dgvList.DataSource = table;
		}
		#endregion


		#region Events

		private void frmQLKHang_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void btnDefault_Click(object sender, EventArgs e)
		{
			txtID.Text = "";
			txtName.Text = "";
			mtbPhone.Text = "";
			txtAddress.Text = "";
			rdName.Checked = true;
			txtSearch.Text = "";
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (txtName.Text != "")
			{
				SqlConnection conn = new SqlConnection(connectionString);
				SqlCommand comd = conn.CreateCommand();

				if (txtID.Text != "")
				{
					// Sửa
					comd.CommandText = "UPDATE KhachHang" +
						" SET TenKH = N'" + txtName.Text + "', SoDienThoai = N'" + mtbPhone.Text + "', DiaChiGH = N'" + txtAddress + "'" +
						" WHERE MaKH = " + txtID.Text;
					// Xóa
					//comd.CommandText = "DELETE FROM KhachHang" +
					//	" WHERE MaKH = " + txtID.Text;
				}
				else
				{   // Thêm
					comd.CommandText = "INSERT INTO KhachHang" +
						" VALUES (N'" + txtName.Text + "', N'" + mtbPhone.Text + "', N'" + txtAddress.Text + "')";
				}

				conn.Open();
				int numOfRows = comd.ExecuteNonQuery();
				conn.Close();

				if (numOfRows > 0)
				{
					MessageBox.Show("Lưu thành công!", "Thông báo");
				}
				else
				{
					MessageBox.Show("Đã xảy ra lỗi. Vui lòng nhập lại!", "Thông báo");
				}
				Display();
			}
			else
			{
				MessageBox.Show("Cần nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			var search = txtSearch.Text;
			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand comd = conn.CreateCommand();

			if (rdName.Checked == true)
			{
				comd.CommandText = "SELECT * " +
									"FROM KhachHang " +
									"WHERE TenKH like N'%" + search + "%'";
			}
			if (rdPhone.Checked == true)
			{
				comd.CommandText = "SELECT * " +
									"FROM KhachHang " +
									"WHERE SoDienThoai like '%" + search + "%'";
			}

			SqlDataAdapter adapter = new SqlDataAdapter(comd);
			DataTable table = new DataTable();

			conn.Open();
			adapter.Fill(table);
			conn.Close();

			dgvList.DataSource = table;
		}

		
		private void dgvList_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvList.SelectedRows.Count > 0)
			{
				txtID.Text = dgvList.SelectedRows[0].Cells[0].Value.ToString();
				txtName.Text = dgvList.SelectedRows[0].Cells[1].Value.ToString();
				mtbPhone.Text = dgvList.SelectedRows[0].Cells[2].Value.ToString();
				txtAddress.Text = dgvList.SelectedRows[0].Cells[3].Value.ToString();
			}
		}

		#endregion

	}
}
