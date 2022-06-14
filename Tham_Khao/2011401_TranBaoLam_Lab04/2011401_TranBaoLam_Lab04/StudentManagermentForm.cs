using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2011401_TranBaoLam_Lab04
{
    public partial class StudentManagermentForm : Form
    {
        // Biến này để kiểm tra xem có chỉnh sửa thông tin gì không để hiện thông báo lưu file
        // Bài tập 1 c) á
        public bool hasChanged = false;


        public StudentManagermentForm()
        {
            InitializeComponent();
        }



        // Hàm này để tạo ra 1 sinh viên từ thông tin mình nhập vô các ô textbox, combobox,...
        public Student CreateStudent()
        {
            Student student = new Student();
            student.ID = this.mtxtID.Text;
            student.FullName = this.txtFullName.Text;
            student.Email = this.txtEmail.Text;
            student.Address = this.txtAddress.Text;
            student.DateOfBirth = this.dtpDateOfBirth.Value;
            student.Gender = true;
            if (this.rdFemale.Checked)
                student.Gender = false;
            student.Class = this.cboClass.Text;
            student.PhoneNumber = this.mtxtPhoneNumber.Text;
            student.ImageLink = this.txtImage.Text;
            return student;
        }



        // Hàm này để thêm sinh viên vào danh sách sinh viên trên ListView
        // Truyền vào 1 sinh viên
        // Sau đó lấy thông tin của sinh viên đó tạo thành 1 hàng (ListViewItem)
        // Rồi thêm hàng (ListViewItem) đó vào trong ListView
        public void AddStudentToListView(Student student)
        {
            ListViewItem lvItem = new ListViewItem(student.ID);
            lvItem.SubItems.Add(student.FullName);
            if (student.Gender)
                lvItem.SubItems.Add("Nam");
            else
                lvItem.SubItems.Add("Nữ");
            lvItem.SubItems.Add(student.DateOfBirth.ToShortDateString());
            lvItem.SubItems.Add(student.Class);
            lvItem.SubItems.Add(student.PhoneNumber);
            lvItem.SubItems.Add(student.Email);
            lvItem.SubItems.Add(student.Address);
            lvItem.SubItems.Add(student.ImageLink);
            lvStudent.Items.Add(lvItem);
        }


        // Hàm này để load danh sách sinh viên lên ListView
        // Truyền danh sách sinh viên cần load vào
        public void LoadListView(List<Student> list)
        {
            // Dòng này để xóa ListView trước khi load, nếu không sẽ bị trùng dữ liệu
            // Nhớ lưu ý phải có .Items chứ khum là bị giống cu Vũ á
            this.lvStudent.Items.Clear();
            if (list != null)
                foreach (Student student in list)
                    AddStudentToListView(student);
        }


        // Hàm này để lấy thông tin sinh viên được chọn ở ListView
        // Rồi dùng thông tin đó hiển thị lên trên các ô thông tin ở trên
        public Student GetStudentFromListView(ListViewItem selectedStudent)
        {
            Student student = new Student();
            student.ID = selectedStudent.SubItems[0].Text;
            student.FullName = selectedStudent.SubItems[1].Text;
            student.Gender = false;
            if (selectedStudent.SubItems[2].Text.CompareTo("Nam") == 0)
                student.Gender = true;
            student.DateOfBirth = DateTime.Parse(selectedStudent.SubItems[3].Text);
            student.Class = selectedStudent.SubItems[4].Text;
            student.PhoneNumber = selectedStudent.SubItems[5].Text;
            student.Email = selectedStudent.SubItems[6].Text;
            student.Address = selectedStudent.SubItems[7].Text;
            student.ImageLink = selectedStudent.SubItems[8].Text;
            return student;
        }


        // Hàm này để hiển thị thông tin của 1 sinh viên lên các ô thông tin nè
        // Lấy thông tin từ hàm ở trên
        public void ShowStudentInformation(Student student)
        {
            this.mtxtID.Text = student.ID;
            this.txtFullName.Text = student.FullName; ;
            this.txtEmail.Text = student.Email; ;
            this.txtAddress.Text = student.Address; ;
            this.dtpDateOfBirth.Value = student.DateOfBirth;
            if (student.Gender)
                this.rdMale.Checked = true;
            else
                this.rdFemale.Checked = true;
            this.cboClass.Text = student.Class;
            this.mtxtPhoneNumber.Text = student.PhoneNumber;
            this.txtImage.Text = student.ImageLink;
            this.pbStudentImage.ImageLocation = student.ImageLink;
        }


        // Cái sự kiện này để mở cái cửa sổ chọn hình ảnh
        private void btnSelectImage_Click(object sender, System.EventArgs e)
        {
            DialogResult result = ofdImage.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.txtImage.Text = ofdImage.FileName;
                this.pbStudentImage.ImageLocation = ofdImage.FileName;
            }
        }


        // Sự kiện này chắc khum cần giải thích he
        private void btnDefault_Click(object sender, System.EventArgs e)
        {
            this.mtxtID.Text = "";
            this.txtFullName.Text = "";
            this.txtEmail.Text = "";
            this.txtAddress.Text = "";
            this.dtpDateOfBirth.Value = DateTime.Now;
            this.rdMale.Checked = true;
            this.cboClass.Text = "";
            this.mtxtPhoneNumber.Text = "";
            this.pbStudentImage.ImageLocation = "";
            this.txtImage.Text = "";
        }


        // Như trên :)
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        // Hàm này để lưu thông tin sinh viên sau khi chỉnh sửa
        // Hoặc thêm sinh viên vào nếu chưa có trong danh sách

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Tạo ra 1 thằng sinh viên từ mấy cái ô thông tin mình nhập nè
            Student student = CreateStudent();
            // Rồi kiểm tra xem MSSV có khác rỗng hay không
            // Nếu khác rỗng thì thêm vào cái danh sách sinh viên dùng chung
            if (student.ID.CompareTo("") != 0)
            {
                WorkingContext.students.EditStudent(student.ID, student);
                LoadListView(WorkingContext.students.list);
            }
            // Nếu MSSV bằng rỗng thì cảnh báo cho người dùng là khum được để trống MSSV
            else
                MessageBox.Show("Không được để trống MSSV!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            hasChanged = true;
        }


        // Sự kiện này để lấy thông tin của dòng được chọn bên ListView
        // Nhấp vô hàng nào thì sự kiện này nó sẽ lấy được thông tin của hàng đó rồi chuyển nó thành sinh viên
        // Sau đó hiển thị thông tin của thằng sinh viên đó lên các ô thông tin
        private void lvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student student = null;
            if (this.lvStudent.SelectedItems.Count > 0)
            {
                student = GetStudentFromListView(this.lvStudent.SelectedItems[0]);
                ShowStudentInformation(student);
            }
        }


        // Sự kiện này để click phải vào sinh viên trên ListView xong nhấn "Xóa" để xóa
        // Phải gắn cái control ContextMenuStrip vô form mới được
        // Hàm này hơi rắc rối, nếu khó hiểu thì để mai tui chỉ cho
        private void tsmiDeleteStudent_Click(object sender, EventArgs e)
        {
            List<Student> deleteList = new List<Student>();
            Student student;
            if (this.lvStudent.SelectedItems.Count > 0)
            {
                for (int i = 0; i < this.lvStudent.SelectedItems.Count; i -= -1)
                {
                    student = GetStudentFromListView(this.lvStudent.SelectedItems[i]);
                    deleteList.Add(student);
                }
            }
            foreach (Student s in deleteList)
            {
                student = WorkingContext.students.SearchStudent(s.ID);
                if (student != null)
                    WorkingContext.students.DeleteStudent(student);
            }
            LoadListView(WorkingContext.students.list);
            btnDefault.PerformClick();
            hasChanged = true;
        }


        // Hàm này để tải danh sách sinh viên từ file khi chạy form lần đầu
        private void StudentManagermentForm_Load(object sender, EventArgs e)
        {
            WorkingContext.students.ReadFile("StudentList.txt");
            LoadListView(WorkingContext.students.list);
        }


        // Hàm này để tải lại ds sinh viên khi click chuột phải rồi chọn "Tải lại dssv"
        // Bài tập 1 b) á
        private void tsmiReload_Click(object sender, EventArgs e)
        {
            WorkingContext.students.ReadFile("StudentList.txt");
            LoadListView(WorkingContext.students.list);
        }


        // Sự kiện này để hỏi xem người dùng có muốn lưu file khi tắt app hay không?
        // Nếu bấm Yes thì lưu file
        // Bấm Cancel thì khum làm gì
        // Bấm No thì thoát app nhưng khum lưu
        private void StudentManagermentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hasChanged)
            {
                DialogResult result = MessageBox.Show("Lưu chưa mà thoát? Có muốn lưu khum?", "Cảnh báo cực mạnh!!!",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                    WorkingContext.students.SaveFile();
                if (result == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }
    }
}
