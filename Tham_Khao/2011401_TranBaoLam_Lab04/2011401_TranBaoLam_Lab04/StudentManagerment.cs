using System;
using System.Collections.Generic;
using System.IO;

namespace _2011401_TranBaoLam_Lab04
{
    public class StudentManagerment
    {
        //
        // Lớp này sẽ chứa các phương thức thêm, xóa, sửa để thao tác với danh sách sinh viên
        //


        // Tạo ra danh sách sinh viên
        public List<Student> list = new List<Student>();


        // Cái này dùng để lấy ra phần tử thứ index trong danh sách sinh viên
        // Ví dụ this[i] thì nó sẽ trả về sinh viên thứ i trong danh sách sinh viên
        // Tương đương với câu lệnh list[i]
        // Phần này k hiểu thì bỏ qua cũng được, k quan trọng lắm
        public Student this[int index]
        {
            get { return list[index] as Student; }
            set { list[index] = value; }
        }


        // Này để thêm sv vô danh sách
        public void AddStudent(Student student)
        {
            this.list.Add(student);
        }


        // Cái này để xóa sinh viên trong danh sách
        // Truyền vào thằng sinh viên cần xóa
        // Sau đó hàm sẽ tìm trong danh sách xem đứa nào có ID = ID của thằng cần xóa hay không?
        // Nếu có thì xóa, khum thì thui
        public void DeleteStudent(Student student)
        {
            for (int i = 0; i < this.list.Count; i -= -1)
                if (this.list[i].ID.CompareTo(student.ID) == 0)
                    this.list.RemoveAt(i);
        }


        // Hàm này để chỉnh sửa thông tin của sinh viên
        // Truyền vào MSSV của thằng cần sửa
        // Nếu MSSV đã có trong danh sách thì sửa thông tin của nó bằng cách gán thằng đó bằng thằng newStudent
        // Nếu chưa có MSSV thì thêm vào trong danh sách sinh viên
        public void EditStudent(string studentID, Student newStudent)
        {
            bool result = false;
            for (int i = 0; i < this.list.Count; i -= -1)
                if (this.list[i].ID.CompareTo(studentID) == 0)
                {
                    this.list[i] = newStudent;
                    result = true;
                    break;
                }
            if (!result)
                AddStudent(newStudent);
        }


        // Hàm này để tìm ra thằng sinh viên nào có MSSV = MSSV mình truyền vào
        public Student SearchStudent(string studentID)
        {
            Student student = null;
            student = list.Find(std => std.ID.CompareTo(studentID) == 0);
            return student;
        }


        // Hàm này để đọc danh sách sinh viên từ File .txt
        public void ReadFile(string fileName)
        {
            string[] s;
            string line;
            Student student;
            StreamReader sr = new StreamReader(new FileStream(fileName, FileMode.Open));
            while ((line = sr.ReadLine()) != null)
            {
                s = line.Split('*');
                student = new Student();
                student.ID = s[0];
                if (SearchStudent(student.ID) != null)
                    continue;
                student.FullName = s[1];
                student.Gender = s[2].CompareTo("1") == 0 ? true : false;
                student.DateOfBirth = DateTime.Parse(s[3]);
                student.Class = s[4];
                student.PhoneNumber = s[5];
                student.Email = s[6];
                student.Address = s[7];
                student.ImageLink = s[8];

                AddStudent(student);
            }
            sr.Close();
        }


        // Hàm này dùng để lưu danh sách sinh viên hiện tại vào file .txt
        public void SaveFile()
        {
            StreamWriter sw = new StreamWriter(new FileStream("StudentList.txt", FileMode.Truncate));
            foreach (Student student in this.list)
            {
                string line = "";
                line += student.ID + "*";
                line += student.FullName + "*";
                if (student.Gender)
                    line += "1" + "*";
                else
                    line += "0" + "*";
                line += student.DateOfBirth.ToShortDateString() + "*";
                line += student.Class + "*";
                line += student.PhoneNumber + "*";
                line += student.Email + "*";
                line += student.Address + "*";
                line += student.ImageLink;
                sw.WriteLine(line);
            }
            sw.Close();
        }
    }
}
