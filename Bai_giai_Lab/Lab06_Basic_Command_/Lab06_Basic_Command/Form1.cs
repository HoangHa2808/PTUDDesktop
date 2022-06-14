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

namespace Lab06_Basic_Command
{
	public partial class Form1 : Form
	{
		public string connectionString = ConfigurationManager.ConnectionStrings["RestaurantManagement"].ConnectionString;
		public Form1()
		{
			InitializeComponent();
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			string query = "SELECT ID, Name, Type FROM Category";
			sqlCommand.CommandText = query;
			sqlConnection.Open();
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			this.DisplayCategory(sqlDataReader);
			sqlConnection.Close();
		}

		private void DisplayCategory(SqlDataReader reder)
		{
			lvCategory.Items.Clear();
			while (reder.Read())
			{
				// Tạo một dòng mới trong ListView
				ListViewItem item = new ListViewItem(reder["ID"].ToString());

				//Bổ sung các thông tin khác cho ListViewItem
				item.SubItems.Add(reder["Name"].ToString());
				item.SubItems.Add(reder["Type"].ToString());

				//Thêm dòng mới vào ListView
				lvCategory.Items.Add(item);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandText = "INSERT INTO Category(Name, [Type])" + "VALUES (N'" + txtName.Text + "', " + txtType.Text + ")";
			sqlConnection.Open();
			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
			if (numOfRowsEffected == 1)
			{
				MessageBox.Show("Thêm món ăn thành công.");
				btnLoad.PerformClick();
			}
			else
				MessageBox.Show("Đã xảy ra lỗi. Vui lòng nhập lại!");
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			
				// Tạo đối tượng kết nối
				SqlConnection sqlConnection = new SqlConnection(connectionString);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
			if (sqlCommand != null)
			{
				sqlCommand.CommandText = "UPDATE Category SET Name = N'" + txtName.Text + "', [Type] = " + txtType.Text + " WHERE ID = " + txtID.Text;
				sqlConnection.Open();
				int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();

				if (numOfRowsEffected == 1)
				{
					// Cập nhật lại dữ liệu trên ListView
					ListViewItem item = lvCategory.SelectedItems[0];
					item.SubItems[1].Text = txtName.Text;
					item.SubItems[2].Text = txtType.Text;

					// Xóa các ô nhập
					txtID.Text = "";
					txtName.Text = "";
					txtType.Text = "";

					//Disable các nút xóa và cập nhật
					btnUpdate.Enabled = false;
					btnDetele.Enabled = false;

					MessageBox.Show("Cập nhật nhóm món ăn thành công.");
				}
				else
					MessageBox.Show("Đã xảy ra lỗi. Vui lòng thử lại!");
			}
		}

		private void btnDetele_Click(object sender, EventArgs e)
		{
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandText = "DELETE FROM Category " + "WHERE ID = " + txtID.Text;

			sqlConnection.Open();
			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();

			if (numOfRowsEffected == 1)
			{
				ListViewItem item = lvCategory.SelectedItems[0];
				lvCategory.Items.Remove(item);

				// Xóa các ô nhập
				txtID.Text = "";
				txtName.Text = "";
				txtType.Text = "";

				// Disable các nút cập nhật và xóa
				btnUpdate.Enabled = false;
				btnDetele.Enabled = false;

				MessageBox.Show("Xóa nhóm món ăn thành công.");
			}
			else
				MessageBox.Show("Đã xảy ra lỗi. Vui lòng thử lại!");
		}

	    private void tsmiDelete_Click(object sender, EventArgs e)
		{
			if (lvCategory.SelectedItems.Count > 0)
				btnDetele.PerformClick();
		}

		private void tsmiViewFood_Click(object sender, EventArgs e)
		{
			if (txtID.Text != "")
			{
			frmFood foodForm = new frmFood();
			foodForm.Show(this);
				foodForm.LoadFood(Convert.ToInt32(txtID.Text));
			}
		}

		private void lvCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Lấy dòng đuc chọn trong ListView
			ListViewItem item = lvCategory.SelectedItems[0];

			// Hiển thị dữ liệu trên TextBox
			txtID.Text = item.Text;
			txtName.Text = item.SubItems[1].Text;
			txtType.Text = item.SubItems[2].Text == "Đồ ăn" ? "1" : "0";

			// Hiển thị nút cập nhật và xóa
			btnUpdate.Enabled = true;
			btnDetele.Enabled = true;
		}
	}
}
