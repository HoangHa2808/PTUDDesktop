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

namespace demobt
{
	public partial class Form1 : Form
	{
		public string connectionString = ConfigurationManager.ConnectionStrings["QLMonAn"].ConnectionString;
		public int categoryFood = 0;
		private int _idFood;
		public Form1(int id = 0)
		{
			InitializeComponent();
			_idFood = id;
		}

		#region Function
		 private void ShowCategoryFood()
		{
			var conn = new SqlConnection(connectionString);
			var comd = conn.CreateCommand();
			comd.CommandText = "SELECT * FROM NhomMonAn";

			var adapter = new SqlDataAdapter(comd);
			var table = new DataTable("NhomMonAn");

			conn.Open();
			adapter.Fill(table);
			conn.Close();

			cboCategory.DisplayMember = "TenNhom";
			cboCategory.ValueMember = "MaNhom";
			cboCategory.DataSource = table;

		}

		private void GetFoodToID(int id)
		{
			var conn = new SqlConnection(connectionString);
			var comd = conn.CreateCommand();
			comd.CommandText = "SELECT *" +
								"FROM MonAn" +
								"WHERE MaMonAn = " + id;

			conn.Open();
			var reader = comd.ExecuteReader();

			while (reader.Read())
			{
				txtIDFood.Text = _idFood.ToString();
				txtFoodName.Text = reader["TenMonAn"].ToString();
				txtUnit.Text = reader["DonViTinh"].ToString();
				nudPrice.Text = reader["DonGia"].ToString();
				cboCategory.SelectedValue = Convert.ToInt32(reader["Nhom"]);
			}
			conn.Close();
		}
		#endregion



		#region Events
		private void Form1_Load(object sender, EventArgs e)
		{
			ShowCategoryFood();
			if (_idFood > 0)
			{
				GetFoodToID(_idFood);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var id = int.Parse(txtIDFood.Text);
			var name = txtFoodName.Text;
			var unit = txtUnit.Text;
			var price = Convert.ToInt32(nudPrice.Text);
			var category = Convert.ToInt32(cboCategory.SelectedValue);

			if (string.IsNullOrWhiteSpace(name))
			{
				MessageBox.Show("Cần nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			var conn = new SqlConnection(connectionString);
			var commd = conn.CreateCommand();

			if (id == 0)
			{
				//Thêm
				commd.CommandText = "INSERT MonAn VALUES(@TenMonAn, @DonViTinh, @DonGia, @Nhom)";
			}
			else
			{
				//Sửa
				commd.CommandText = "UPDATE MonAn" + 
									"SET TenMonAn = @TenMonAn, DonViTinh = @DonViTinh, DonGia = @DonGia, Nhom = @Nhom" + 
									"WHERE MaMonAn = @MaMonAn";
			}

			commd.Parameters.AddWithValue("@TenMonAn", name);
			commd.Parameters.AddWithValue("@DonViTinh", unit);
			commd.Parameters.AddWithValue("@DonGia", price);
			commd.Parameters.AddWithValue("@Nhom", category);
			commd.Parameters.AddWithValue("@MaMonAn", id);


			conn.Open();
			var numRow = commd.ExecuteNonQuery();
			if (numRow > 0)
			{
				MessageBox.Show("Thành công", "Thông báo");
				categoryFood = category;
				DialogResult = DialogResult.OK;
			}
			else
			{
				MessageBox.Show("Đã xảy ra lỗi", "Thông báo");
			}	
			conn.Close();
		}
		#endregion

	}
}
