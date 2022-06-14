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
	public partial class frmQuanLyNhaCungCap : Form
	{
		public string connectionString = ConfigurationManager.ConnectionStrings["QLBanHang"].ConnectionString;

		public frmQuanLyNhaCungCap()
		{
			InitializeComponent();
		}

		#region Function
		private void Display()
		{
			lvList.Items.Clear();
			var conn = new SqlConnection(connectionString);
			var comd = conn.CreateCommand();
			comd.CommandText = "SELECT MaNCC, TenNhaCC, DiaChi, SoDienThoai, MoTa FROM NhaCungCap";

			var adapter = new SqlDataAdapter(comd);
			var table = new DataTable();

			conn.Open();
			adapter.Fill(table);
			conn.Close();

			foreach (DataRow dr in table.Rows)
			{
				ListViewItem item = new ListViewItem(dr["MaNCC"].ToString());
				item.SubItems.Add(dr["TenNhaCC"].ToString());
				item.SubItems.Add(dr["DiaChi"].ToString());
				item.SubItems.Add(dr["SoDienThoai"].ToString());
				item.SubItems.Add(dr["MoTa"].ToString());

				lvList.Items.Add(item);
			}

		}

		#endregion

		#region Events
		private void frmQuanLyNhaCungCap_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void btnDefault_Click(object sender, EventArgs e)
		{
			txtID.Text = "";
			txtName.Text = "";
			txtAddress.Text = "";
			mtbPhone.Text = "";
			txtMoTa.Text = "";
			txtSearch.Text = "";
			rdName.Checked = true;
		}

		//private void lvList_SelectedIndexChanged(object sender, EventArgs e)
		//{
		//	var conn = new SqlConnection(connectionString);
		//	var comd = conn.CreateCommand();
		//	comd.CommandText = "SELECT * " +
		//						"FROM NhaCungCap";

		//	var adapted = new SqlDataAdapter(comd);
		//	var table = new DataTable("NhaCungCap");

		//	conn.Open();
		//	adapted.Fill(table);
		//	conn.Close();
		//}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (txtName.Text != "")
			{
				SqlConnection conn = new SqlConnection(connectionString);
				SqlCommand comd = conn.CreateCommand();

				if (txtID.Text != "")
				{
					comd.CommandText = "UPDATE NhaCungCap" +
						" SET TenNhaCC = N'" + txtName.Text + "', DiaChi = N'" + txtAddress.Text + "', SoDienThoai = N'" + mtbPhone.Text + "', MoTa = N'" + txtMoTa + "'" +
						" WHERE MaNCC =  " + txtID.Text;
				}

				else
				{
					comd.CommandText = "INSERT INTO NhaCungCap(TenNhaCC, DiaChi, SoDienThoai, MoTa)" +
						" VALUES (N'" + txtName.Text + "', N'" + txtAddress.Text + "', N'" + mtbPhone.Text + "', N'" + txtMoTa.Text + "')";
					// "INSERT INTO NhaCungCap " +
					// "VALUES (N'" + txtName.Text + "', N'" + txtAddress.Text + "', N'" + mtbPhone.Text + "', N'" + txtMoTa.Text + "')";
				}

				conn.Open();
				int numOfRowsEffected = comd.ExecuteNonQuery();
				conn.Close();
				if (numOfRowsEffected == 1)
				{
					MessageBox.Show("Lưu thành công.");
				}
				else
					MessageBox.Show("Đã xảy ra lỗi. Vui lòng nhập lại!");

				Display();
			}
			else 
			{ 
				MessageBox.Show("Cần nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void lvList_Click(object sender, EventArgs e)
		{
			if (lvList.SelectedItems.Count > 0)
			{
				ListViewItem item = lvList.SelectedItems[0];

				txtID.Text = item.Text;
				txtName.Text = item.SubItems[1].Text;
				txtAddress.Text = item.SubItems[2].Text;
				mtbPhone.Text = item.SubItems[3].Text;
				txtMoTa.Text = item.SubItems[4].Text;
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			var search = txtSearch.Text;

			var conn = new SqlConnection(connectionString);
			var comd = conn.CreateCommand();
			if (rdName.Checked == true)
			{
				comd.CommandText = "SELECT * " +
									"FROM NhaCungCap " +
									"WHERE TenNhaCC like N'%" + search + "%'";
			}
			if (rdPhone.Checked == true)
			{
				comd.CommandText = "SELECT * " +
									"FROM NhaCungCap " +
									"WHERE SoDienThoai like '%" + search + "%'";
			}

			var adapted = new SqlDataAdapter(comd);
			var table = new DataTable("NhaCungCap");

			conn.Open();
			adapted.Fill(table);
			conn.Close();

			Display();
		}

		#endregion

	}
}
