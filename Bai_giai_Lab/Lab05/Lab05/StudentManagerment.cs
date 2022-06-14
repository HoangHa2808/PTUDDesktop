using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab05
{
	public class StudentManagerment
	{
		public List<Student> list = new List<Student>();

		public Student this[int index]
		{
			get { return list[index] as Student; }
			set { list[index] = value; }
		}

		public void AddStudent(Student student)
		{
			list.Add(student);
		}

		public void DeleteStudent(Student student)
		{
			for (int i = 0; i < list.Count; i++)
				if (list[i].ID.CompareTo(student.ID) == 0)
					list.RemoveAt(i);
		}

		public void EditStudent(string studentID, Student newStudent)
		{
			//foreach (Student student in list)
			//	if (student.ID.CompareTo(studentID) == 0)
			//	{
			//		DeleteStudent(student);
			//		AddStudent(newStudent);
			//		return true;
			//	}
			//return false;
			if (SearchStudent(studentID) != null)
				for (int i = 0; i < this.list.Count; i++)
					if (list[i].ID.CompareTo(studentID) == 0)
					{
						this.list[i] = newStudent;
						break;
					}
		}

		public Student SearchStudent(string studentID)
		{
			Student student = null;
			student = list.Find(std => std.ID.CompareTo(studentID) == 0);
			return student;
		}

		public List<Student> SearchStudents(string studentID)
		{
			List<Student> students = new List<Student>();
			students = list.FindAll(stds => stds.ID.CompareTo(studentID) == 0);
			return students;
		}

		// Đọc từ file
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
				student.LastName = s[1];
				student.FirstName = s[2];
				student.Gender = s[3].CompareTo("1") == 0 ? true : false;
				student.Birthday = DateTime.Parse(s[4]);
				student.Class = s[5];
				student.CMND = s[6];
				student.PhoneNumber = s[7];
				student.Address = s[8];
				string[] faculty = s[9].Split(',');
				List<string> f = new List<string>();
				foreach (string fl in faculty)
					f.Add(fl);
				student.Faculty = f;
				AddStudent(student);

			}
			sr.Close();
		}

		// Lưu thông tin sinh viên
		public void SaveStudentFile()
		{
			StreamWriter sw = new StreamWriter(new FileStream("student.txt", FileMode.Truncate));
			foreach (Student student in list)
			{
				string line = "";
				line += student.ID + "*";
				line += student.LastName + "*";
				line += student.FirstName + "*";
				if (student.Gender)
					line += "1" + "*";
				else line += "0" + "*";
				line += student.Birthday.ToShortDateString() + "*";
				line += student.Class + "*";
				line += student.CMND + "*";
				line += student.PhoneNumber + "*";
				line += student.Address + "*";
				if (student.Faculty != null)
				{
					foreach (string fl in student.Faculty)
						line += fl + ",";
				}
				sw.WriteLine(line);
			}
			sw.Close();
		}
	}
}
