using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab03_Demo
{
    public partial class SearchForm : Form
    {
        public List<Student> ReturnStudents { get; set; }
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (this.rdID.Checked)
                ReturnStudents = WorkingContext.students.list.OrderBy(x => x.ID).ToList();
            if (this.rdFullName.Checked)
                ReturnStudents = WorkingContext.students.list.OrderBy(x => x.FullName).ToList();
            if (this.rdDateOfBirth.Checked)
                ReturnStudents = WorkingContext.students.list.OrderBy(x => x.DateOfBirth).ToList();
            DialogResult = DialogResult.OK;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtInformation.Text) || !String.IsNullOrWhiteSpace(this.txtInformation.Text))
            {
                if (this.rdID.Checked)
                    ReturnStudents =
                        WorkingContext.students.SearchStudents(SearchType.Type.ID, this.txtInformation.Text);
                if (this.rdFullName.Checked)
                    ReturnStudents =
                        WorkingContext.students.SearchStudents(SearchType.Type.FullName, this.txtInformation.Text);
                if (this.rdDateOfBirth.Checked)
                    ReturnStudents =
                        WorkingContext.students.SearchStudents(SearchType.Type.DateOfBirth, this.txtInformation.Text);
                DialogResult = DialogResult.Yes;
            }
            else
                MessageBox.Show("Nhập thông tin cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
