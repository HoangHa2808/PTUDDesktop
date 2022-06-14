using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _2011401_TranBaoLam_De3
{
    public partial class ManagementForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

        public ManagementForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ListView
        /// </summary>
        /// ===========================
        // Tải danh sách mặt hàng lên lv
        //private void LoadProducts()
        //{
        //    this.lvProducts.Items.Clear();
        //    SqlConnection conn = new SqlConnection(connectionString);
        //    SqlCommand cmd = conn.CreateCommand();
        //    cmd.CommandText = "SELECT MaMatHang, TenMatHang, TenLoai, SoLuongTon, DonGia " +
        //                      "FROM LoaiMatHang, MatHang " +
        //                      "WHERE MaLoai = LoaiMatHang";
        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    DataTable table = new DataTable();
        //    conn.Open();
        //    adapter.Fill(table);
        //    conn.Close();
        //    conn.Dispose();
        //    foreach (DataRow product in table.Rows)
        //    {
        //        ListViewItem item = new ListViewItem(product["MaMatHang"].ToString());
        //        item.SubItems.Add(product["TenMatHang"].ToString());
        //        item.SubItems.Add(product["TenLoai"].ToString());
        //        item.SubItems.Add(product["SoLuongTon"].ToString());
        //        item.SubItems.Add(product["DonGia"].ToString());
        //        this.lvProducts.Items.Add(item);
        //    }
        //} ===========================

        // Tải danh sách mặt hàng lên dgv
        private void LoadProducts()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT MaMatHang, TenMatHang, TenLoai, SoLuongTon, DonGia " +
                              "FROM LoaiMatHang, MatHang " +
                              "WHERE MaLoai = LoaiMatHang";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            conn.Open();
            adapter.Fill(table);
            conn.Close();
            conn.Dispose();
            this.dgvProducts.DataSource = table;
        }

        // Tải danh sách loại mặt hàng lên ComboBox
        private void LoadCategories()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM LoaiMatHang";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            conn.Open();
            adapter.Fill(table);
            conn.Close();
            conn.Dispose();
            this.cbbCategory.DisplayMember = "TenLoai";
            this.cbbCategory.ValueMember = "MaLoai";
            this.cbbCategory.DataSource = table;
        }

        private void ManagementForm_Load(object sender, System.EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        /// <summary>
        /// ListView
        /// </summary>
        /// ===========================
        // Hiển thị thông tin khi chọn vào 1 mặt hàng
        //private void lvProducts_SelectedIndexChanged(object sender, System.EventArgs e)
        //{
        //    if (this.lvProducts.SelectedItems.Count > 0)
        //    {
        //        this.txtID.Text = this.lvProducts.SelectedItems[0].SubItems[0].Text;
        //        this.txtName.Text = this.lvProducts.SelectedItems[0].SubItems[1].Text;
        //        this.cbbCategory.Text = this.lvProducts.SelectedItems[0].SubItems[2].Text;
        //        this.nudQuantity.Text = this.lvProducts.SelectedItems[0].SubItems[3].Text;
        //        this.nudPrice.Text = this.lvProducts.SelectedItems[0].SubItems[4].Text;
        //    }
        //} ===========================

        // Thêm
        private void btnAddProduct_Click(object sender, System.EventArgs e)
        {
            if (this.txtID.Text == "" && this.txtName.Text != "" && this.cbbCategory.SelectedIndex > -1 &&
                this.nudPrice.Value > 0)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO MatHang VALUES(N'" + this.txtName.Text + "', " +
                                  this.cbbCategory.SelectedValue + ", " + this.nudQuantity.Value + ", " +
                                  this.nudPrice.Value + ")";
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();
            }
            else
                MessageBox.Show("Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Cập nhật
        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            if (this.txtID.Text != "" && this.txtName.Text != "" && this.cbbCategory.SelectedIndex > -1 &&
                this.nudPrice.Value > 0)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE MatHang " +
                                  "SET TenMatHang = N'" + this.txtName.Text + "', " +
                                  "LoaiMatHang = " + this.cbbCategory.SelectedValue + ", " +
                                  "SoLuongTon = " + this.nudQuantity.Value + ", " +
                                  "DonGia = " + this.nudPrice.Value + " " +
                                  "WHERE MaMatHang = " + this.txtID.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();
            }
            else
                MessageBox.Show("Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Hiển thị thông tin khi chọn vào 1 mặt hàng
        private void dgvProducts_SelectionChanged(object sender, System.EventArgs e)
        {
            if (this.dgvProducts.SelectedRows.Count > 0)
            {
                this.txtID.Text = this.dgvProducts.SelectedRows[0].Cells[0].Value.ToString();
                this.txtName.Text = this.dgvProducts.SelectedRows[0].Cells[1].Value.ToString();
                this.cbbCategory.Text = this.dgvProducts.SelectedRows[0].Cells[2].Value.ToString();
                this.nudQuantity.Text = this.dgvProducts.SelectedRows[0].Cells[3].Value.ToString();
                this.nudPrice.Text = this.dgvProducts.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
    }
}
