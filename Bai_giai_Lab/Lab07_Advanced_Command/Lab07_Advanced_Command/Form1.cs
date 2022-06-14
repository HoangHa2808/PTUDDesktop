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

namespace Lab07_Advanced_Command
{
	public partial class Form1 : Form
	{
		string connectionString = ConfigurationManager.ConnectionStrings["RestaurantManagement"].ConnectionString;
		private DataTable foodTable;
		public Form1()
		{
			InitializeComponent();
		}

		#region Hàm
		private void LoadCategory()
		{
		SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandText = "SELECT ID, Name FROM Category";
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();

			sqlDataAdapter.Fill(dataTable);
			sqlConnection.Close();
			sqlConnection.Dispose();

			//Đưa dữ liệu vào ComboBox
			cboCategory.DataSource = dataTable;

			// Hiển thị tên nhóm sản phẩm
			cboCategory.DisplayMember = "Name";

			//Khi lấy giá trị thì lấy ID của nhóm
			cboCategory.ValueMember = "ID";
		}
		#endregion


		#region Sự kiện
		private void Form1_Load(object sender, EventArgs e)
		{
			 this.LoadCategory();
		}

		private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboCategory.SelectedIndex == -1) return;
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = @categoryId";

			sqlCommand.Parameters.Add("@categoryId", SqlDbType.Int);

			if (cboCategory.SelectedValue is DataRowView)
			{
				DataRowView rowView = cboCategory.SelectedValue as DataRowView;
				sqlCommand.Parameters["@categoryId"].Value = rowView["ID"];
			}
			else
				sqlCommand.Parameters["@categoryId"].Value = cboCategory.SelectedValue;

			// Tạo bộ điều phiến dữ liệu
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			foodTable = new DataTable();

			sqlConnection.Open();
			sqlDataAdapter.Fill(foodTable);
			sqlConnection.Close();
			sqlConnection.Dispose();

			// Đưa dữ liệu vào DataGridView
			dgvFoodList.DataSource = foodTable;

			// Tính số lượng mẫu tin
			lbQuantity.Text = foodTable.Rows.Count.ToString();
			lbCatName.Text = cboCategory.Text;
		}
		private void tmsiCalculateQuality_Click(object sender, EventArgs e)
		{
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandText = "SELECT @numSaleFood = sum(Quantity) FROM BillDetails WHERE FoodID = @foodId";

			// Lấy thông tin sản phẩm
			if (dgvFoodList.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
				DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

				// Truyền tham số
				sqlCommand.Parameters.Add("@foodId", SqlDbType.Int);
				sqlCommand.Parameters["@foodId"].Value = rowView["ID"];

				sqlCommand.Parameters.Add("@numSaleFood", SqlDbType.Int);
				sqlCommand.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;

				sqlConnection.Open();
				// Thực thi truy vấn và lấy dữ liệu từ tham số
				sqlCommand.ExecuteNonQuery();
				string result = sqlCommand.Parameters["@numSaleFood"].Value.ToString();
				MessageBox.Show("Tổng số lượng món: " + rowView["Name"] + " đã bán là: " + result + " " + rowView["Unit"]);
				sqlConnection.Close();
			}
			sqlConnection.Dispose();
		}

		private void tmsiAddFood_Click(object sender, EventArgs e)
		{

		}

		private void tmsiUpdateFood_Click(object sender, EventArgs e)
		{

		}
		#endregion

	}
}
