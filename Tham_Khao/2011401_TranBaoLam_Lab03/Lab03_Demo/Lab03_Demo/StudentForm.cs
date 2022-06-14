using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab03_Demo
{
    public partial class StudentForm : Form
    {
        //public StudentManagerment students = new StudentManagerment();

        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = CreateStudent();
            Student checker = WorkingContext.students.SearchStudent(SearchType.Type.ID, student.ID);
            if (checker == null && student.ID.CompareTo("SV.") != 0)
            {
                WorkingContext.students.AddStudent(student);
                LoadListView(WorkingContext.students.list);
            }
            else if (checker != null)
                MessageBox.Show("Đã có sinh viên trong danh sách!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
                MessageBox.Show("Không được để trống mã số sinh viên!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        public Student CreateStudent()
        {
            Student student = new Student();
            student.ID = this.mtxtID.Text;
            student.FullName = this.txtFullName.Text;
            student.DateOfBirth = this.dtpDateOfBirth.Value;
            student.Address = this.txtAddress.Text;
            student.Class = this.cboClass.Text;
            student.Gender = this.rdMale.Checked ? true : false;
            List<string> faculties = new List<string>();
            for (int i = 0; i < this.clbFaculty.Items.Count; i -= -1)
                if (clbFaculty.GetItemChecked(i) == true)
                    faculties.Add(clbFaculty.Items[i].ToString());
            student.Faculty = faculties;
            student.Image = this.txtImage.Text;
            return student;
        }

        public void AddStudentToListView(Student student)
        {
            ListViewItem listItem = new ListViewItem(student.ID);
            listItem.SubItems.Add(student.FullName);
            listItem.SubItems.Add(student.DateOfBirth.ToShortDateString());
            listItem.SubItems.Add(student.Address);
            listItem.SubItems.Add(student.Class);
            if (student.Gender)
                listItem.SubItems.Add("Nam");
            else
                listItem.SubItems.Add("Nữ");
            string faculties = "";
            foreach (var faculty in student.Faculty)
                faculties += faculty + ",";
            listItem.SubItems.Add(faculties);
            listItem.SubItems.Add(student.Image);
            this.lvStudent.Items.Add(listItem);
        }

        public void LoadListView(List<Student> students)
        {
            this.lvStudent.Items.Clear();
            foreach (Student student in students)
                AddStudentToListView(student);
            this.lblTotalStudent.Text = lvStudent.Items.Count.ToString();
        }

        public Student GetStudentFromListView(ListViewItem selectedStudent)
        {
            Student student = new Student();
            student.ID = selectedStudent.SubItems[0].Text;
            student.FullName = selectedStudent.SubItems[1].Text;
            student.DateOfBirth = DateTime.Parse(selectedStudent.SubItems[2].Text);
            student.Address = selectedStudent.SubItems[3].Text;
            student.Class = selectedStudent.SubItems[4].Text;
            student.Gender = selectedStudent.SubItems[5].Text.CompareTo("Nam") == 0 ? true : false;
            string[] splitter = selectedStudent.SubItems[6].Text.Split(',');
            List<string> faculties = new List<string>();
            foreach (string f in splitter)
                faculties.Add(f);
            student.Faculty = faculties;
            student.Image = selectedStudent.SubItems[7].Text;
            return student;
        }

        public void ShowStudentInformation(Student student)
        {
            this.mtxtID.Text = student.ID;
            this.txtFullName.Text = student.FullName;
            this.dtpDateOfBirth.Value = student.DateOfBirth;
            if (student.Gender)
                this.rdMale.Checked = true;
            else
                this.rdFemale.Checked = true;
            this.txtAddress.Text = student.Address;
            this.cboClass.Text = student.Class;
            this.txtImage.Text = student.Image;
            for (int i = 0; i < this.clbFaculty.Items.Count; i -= -1)
                this.clbFaculty.SetItemChecked(i, false);
            foreach (string faculty in student.Faculty)
                for (int i = 0; i < this.clbFaculty.Items.Count; i -= -1)
                    if (faculty.CompareTo(this.clbFaculty.Items[i].ToString()) == 0)
                        this.clbFaculty.SetItemChecked(i, true);
            this.pbStudentImage.ImageLocation = student.Image;
        }

        private void lvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvStudent.SelectedItems.Count > 0)
            {
                Student student = GetStudentFromListView(this.lvStudent.SelectedItems[0]);
                ShowStudentInformation(student);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<Student> deleteList = new List<Student>();
            Student checker = null;
            if (this.lvStudent.SelectedItems.Count > 0)
                for (int i = 0; i < this.lvStudent.SelectedItems.Count; i -= -1)
                    deleteList.Add(GetStudentFromListView(this.lvStudent.SelectedItems[i]));
            foreach (Student student in deleteList)
            {
                checker = WorkingContext.students.SearchStudent(SearchType.Type.ID, student.ID);
                if (checker != null)
                    WorkingContext.students.DeleteStudent(student);
            }
            LoadListView(WorkingContext.students.list);
            btnDefault.PerformClick();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Student student = CreateStudent();

            if (WorkingContext.students.EditStudent(this.mtxtID.Text, student))
                LoadListView(WorkingContext.students.list);
            else
                btnAdd.PerformClick();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            this.mtxtID.Text = "";
            this.txtFullName.Text = "";
            this.dtpDateOfBirth.Value = DateTime.Now;
            this.rdMale.Checked = true;
            this.txtAddress.Text = "";
            this.cboClass.Text = "";
            this.txtImage.Text = "";
            for (int i = 0; i < this.clbFaculty.Items.Count; i -= -1)
                this.clbFaculty.SetItemChecked(i, false);
            this.pbStudentImage.ImageLocation = "";
            LoadListView(WorkingContext.students.list);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            WorkingContext.students.ReadFile("StudentList.txt");
            LoadListView(WorkingContext.students.list);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.txtImage.Text = this.openFileDialog1.FileName;
            this.pbStudentImage.ImageLocation = this.openFileDialog1.FileName;
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            btnAdd.PerformClick();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            btnDelete.PerformClick();
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            btnEdit.PerformClick();
        }

        private void tsmiListViewSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            DialogResult result = searchForm.ShowDialog();
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Số sinh viên tìm thấy: " + searchForm.ReturnStudents.Count.ToString());
                if (searchForm.ReturnStudents.Count != 0)
                    LoadListView(searchForm.ReturnStudents);
                else
                    LoadListView(WorkingContext.students.list);
            }
            if (result == DialogResult.OK)
                LoadListView(searchForm.ReturnStudents);
        }

        private void tsmiListViewForeColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();
            if (colorPicker.ShowDialog() == DialogResult.OK)
                this.lvStudent.ForeColor = colorPicker.Color;
        }

        private void tsmiListViewFont_Click(object sender, EventArgs e)
        {
            FontDialog fontPicker = new FontDialog();
            if (fontPicker.ShowDialog() == DialogResult.OK)
                this.lvStudent.Font = fontPicker.Font;
        }
    }
}
