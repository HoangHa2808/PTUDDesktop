using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_Basic_Command
{
	public partial class frmFood : Form
	{
		public frmFood()
		{
			InitializeComponent();
		}
		public void LoadFood(int categoryID)
		{
			// Tạo đối tượng kết nối
			string connectionString = "server= SUMMER\\SUMMER ; database= RestaurantManagement; Integrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			// Tạo đối tượng thực thi
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandText = "SELECT Name FROM Category WHERE ID = " + categoryID;
			sqlConnection.Open();
			string catName = sqlCommand.ExecuteScalar().ToString();
			this.Text = "Danh sách các món ăn thuộc nhóm: " + catName;
			sqlCommand.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = " + categoryID;

			// Tạo đối tượng DatAdapter
			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

			// Tạo DataTable để chứa dữ liệu
			DataTable dt = new DataTable("Food");
			da.Fill(dt);

			dgvFood.DataSource = dt;

			// Đóng kết nối và giải phóng bộ nhớ
			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}


        #region Sự kiện
        private void tmsiAddFood_Click(object sender, EventArgs e)
        {

        }

        private void tmsiDeleteFood_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
