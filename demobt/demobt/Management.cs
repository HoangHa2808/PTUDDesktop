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
	public partial class Management : Form
	{
		public string connectionString = ConfigurationManager.ConnectionStrings["QLMonAn"].ConnectionString;
		public Management()
		{
			InitializeComponent();
		}


		#region Function
		private void ShowFood()
		{
			var conn = new SqlConnection(connectionString);
			var comd = conn.CreateCommand();
			comd.CommandText = "SELECT *" +
								"FROM NhomMonAn";

			var adapter = new SqlDataAdapter(comd);
			var table = new DataTable("NhomMonAn");

			conn.Open();
			adapter.Fill(table);
			conn.Close();

			cboCategoryFood.DisplayMember = "TenNhom";
			cboCategoryFood.ValueMember = "MaNhom";
			cboCategoryFood.DataSource = table;
		}

		private void ShowFoodListToID(int idCategory)
		{

			var conn = new SqlConnection(connectionString);
			var comd = conn.CreateCommand();
			comd.CommandText = "SELECT m.MaMonAn, TenMonAn, DonViTinh, DonGia, TenNhom " +
								"FROM MonAn m, NhomMonAn nma " +
								"WHERE m.Nhom = nma.MaNhom and " +
								"m.Nhom = " + idCategory;

			var adapted = new SqlDataAdapter(comd);
			var table = new DataTable("MonAn");

			conn.Open();
			adapted.Fill(table);
			conn.Close();

			dgvListFood.DataSource = table;
		}

		#endregion

		#region Events
		private void Management_Load(object sender, EventArgs e)
		{
			ShowFood();
		}

		private void cboCategoryFood_SelectedIndexChanged(object sender, EventArgs e)
		{
			var id = Convert.ToInt32(cboCategoryFood.SelectedValue);
			ShowFoodListToID(id);
		}

		private void txtSearchFood_TextChanged(object sender, EventArgs e)
		{
			var search = txtSearchFood.Text;
			var conn = new SqlConnection(connectionString);
			var comd = conn.CreateCommand();
			comd.CommandText = "SELECT m.MaMonAn, TenMonAn, DonViTinh, DonGia, TenNhom " +
								"FROM MonAn m, NhomMonAn nma " +
								"WHERE m.Nhom = nma.MaNhom and " +
								"m.Nhom = " + cboCategoryFood.SelectedValue + " and " +
								"m.TenMonAn like N'%" + search + "%'";
		
			var adapted = new SqlDataAdapter(comd);
			var table = new DataTable("MonAn");
			conn.Open();
			adapted.Fill(table);
			conn.Close();

			dgvListFood.DataSource = table;
		}

		private void btnAddFood_Click(object sender, EventArgs e)
		{
			var form = new Form1();
			if (form.ShowDialog() == DialogResult.OK)
			{
				var category = form.categoryFood;
				ShowFoodListToID(category);
			}
		}
		private void dgvListFood_DoubleClick(object sender, EventArgs e)
		{
			if (dgvListFood.SelectedRows.Count > 0)
			{
				var idFood = Convert.ToInt32(dgvListFood.SelectedRows[0].Cells[0].Value);
				var form = new Form1(idFood);
				if (form.ShowDialog() == DialogResult.OK)
				{
					var category = form.categoryFood;
					ShowFoodListToID(category);
				}
			}
		}

		#endregion

	}
}
