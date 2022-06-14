using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
	public partial class InformationForm : Form
	{
		public InformationForm()
		{
			InitializeComponent();
		}
		public StudentManagerment studentManagement = new StudentManagerment();
		public bool changed = false;

		#region Phương thức bổ sung
		//Lấy thông tin sinh viên
		public Student GetStudent()
		{
			Student student = new Student();
			student.ID = mtbID.Text;
			student.LastName = txtLastName.Text;
			student.FirstName = txtFirstName.Text;
			student.Birthday = dtpBirthday.Value;
			student.Class = cboClass.Text;
			if (rdMale.Checked == true)
				student.Gender = true;
			else student.Gender = false;
			student.CMND = mtbCMND.Text;
			student.PhoneNumber = mtbPhone.Text;
			student.Address = txtAdderss.Text;
			return student;
		}

		// Thêm sinh viên vào ListView
		public void AddStudent(Student student)
		{
			ListViewItem lvitem = new ListViewItem(student.ID);
			lvitem.SubItems.Add(student.LastName);
			lvitem.SubItems.Add(student.FirstName);
			string gender = "Nữ";
			if (student.Gender)
				gender = "Nam";
			lvitem.SubItems.Add(gender);
			lvitem.SubItems.Add(student.Birthday.ToShortDateString());
			lvitem.SubItems.Add(student.Class);
			lvitem.SubItems.Add(student.CMND);
			lvitem.SubItems.Add(student.PhoneNumber);
			lvitem.SubItems.Add(student.Address);
			if (student.Faculty != null)
			{
				string fl = "";
				foreach (string f in student.Faculty)
					fl += f + ",";
				lvitem.SubItems.Add(fl);
			}
			this.lvStudent.Items.Add(lvitem);
		}

		// Hiển thị thông tin sinh viên
		public void ShowStudentInformation(Student student)
		{
			this.mtbID.Text = student.ID;
			this.txtLastName.Text = student.LastName;
			this.txtFirstName.Text = student.FirstName;
			if (student.Gender)
				this.rdMale.Checked = true;
			else this.rdFemale.Checked = true;
			this.dtpBirthday.Value = student.Birthday;
			this.cboClass.Text = student.Class;
			this.mtbCMND.Text = student.CMND;
			this.mtbPhone.Text = student.PhoneNumber;
			this.txtAdderss.Text = student.Address;
			for (int i = 0; i < this.clbFaculty.Items.Count; i++)
			{
				this.clbFaculty.SetItemChecked(i, false);

			}
			if (student.Faculty != null)
			{
				foreach (var faculty in student.Faculty)
				{
					for (int i = 0; i < this.clbFaculty.Items.Count; i++)
					{
						if (faculty.CompareTo(this.clbFaculty.Items[i].ToString()) == 0)
						{
							this.clbFaculty.SetItemChecked(i, true);
						}
					}
				}
			}
		}

		// Lấy thông tin dc chọn ở ListView -> hiển thị ở các ô thông tin
		public Student GetStudentFromListView(ListViewItem lvitem)
		{
			Student student = new Student();
			if (lvitem != null)
			{
				student.ID = lvitem.SubItems[0].Text;
				student.LastName = lvitem.SubItems[1].Text;
				student.FirstName = lvitem.SubItems[2].Text;
				student.Gender = false;
				if (lvitem.SubItems[3].Text.CompareTo("Nam") == 0)
					student.Gender = true;
				student.Birthday = DateTime.Parse(lvitem.SubItems[4].Text);
				student.Class = lvitem.SubItems[5].Text;
				student.CMND = lvitem.SubItems[6].Text;
				student.PhoneNumber = lvitem.SubItems[7].Text;
				student.Address = lvitem.SubItems[8].Text;
				string[] f = lvitem.SubItems[9].Text.Split(',');
				List<string> fp = new List<string>();
				foreach (string item in f)
				{
					fp.Add(item);
				}
				student.Faculty = fp;
			}
			return student;
		}

		public void LoadListView(List<Student> listStudent)
		{
			this.lvStudent.Items.Clear();
			if (listStudent != null)
				foreach (Student student in listStudent)
					AddStudent(student);
		}
		#endregion


		#region Sự kiện
		private void InformationForm_Load(object sender, EventArgs e)
		{
			studentManagement.ReadFile("student.txt");
			LoadListView(studentManagement.list);
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			SearchForm searchform = new SearchForm();
			searchform.ShowDialog();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (this.mtbID.Text == "" || this.txtLastName.Text == "" || this.txtFirstName.Text == "" || this.dtpBirthday.Text == "" || this.cboClass.Text == "" || this.mtbPhone.Text == "" || this.txtAdderss.Text == "")
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			else
			{
				Student student = GetStudent();
				// kiểm tra xem MSSV có rỗng hay ko, nếu có thì thêm vô ds
				if (studentManagement.SearchStudent(student.ID) == null)
				{
					studentManagement.AddStudent(student);
					LoadListView(studentManagement.list);
					studentManagement.SaveStudentFile();
				}
				else
					MessageBox.Show("MSSV này đã tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				changed = true;
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (this.mtbID.Text == "" || this.txtLastName.Text == "" || this.txtFirstName.Text == "" || this.dtpBirthday.Text == "" || this.cboClass.Text == "" || this.mtbPhone.Text == "" || this.txtAdderss.Text == "")
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			else
			{
				Student student = GetStudent();
				this.studentManagement.EditStudent(student.ID, student);
				LoadListView(studentManagement.list);
				studentManagement.SaveStudentFile();
				changed = true;
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void lvStudent_SelectedIndexChanged(object sender, EventArgs e)
		{
			Student student = null;
			if (this.lvStudent.SelectedItems.Count > 0)
			{
				student = GetStudentFromListView(this.lvStudent.SelectedItems[0]);
				ShowStudentInformation(student);
			}
		}

		private void tsmiDelete_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem lvitem in lvStudent.SelectedItems)
			{
				studentManagement.DeleteStudent(GetStudentFromListView(lvitem));
			}
			LoadListView(studentManagement.list);
			changed = true;
		}

		private void tsmiDeleteRegistration_Click(object sender, EventArgs e)
		{

			changed = true;
		}

		private void tsmiAddRegistration_Click(object sender, EventArgs e)
		{

			changed = true;
		}

		private void InformationForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (changed == true)
			{
				DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
					studentManagement.SaveStudentFile();
				else
					e.Cancel = true;
			}
		}

		#endregion

	}
}
