using System;
using System.Collections.Generic;
using System.IO;

namespace Lab03_Demo
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

        public bool EditStudent(string studentID, Student newStudent)
        {
            foreach (Student student in list)
                if (student.ID.CompareTo(studentID) == 0)
                {
                    DeleteStudent(student);
                    AddStudent(newStudent);
                    return true;
                }
            return false;
        }

        public Student SearchStudent(object searchType, string s)
        {
            Student student = new Student();
            switch (searchType)
            {
                case SearchType.Type.ID:
                    student = list.Find(std => std.ID.CompareTo(s) == 0);
                    break;
                case SearchType.Type.FullName:
                    student = list.Find(std => std.FullName.Contains(s));
                    break;
                case SearchType.Type.DateOfBirth:
                    student = list.Find(std => std.DateOfBirth == DateTime.Parse(s));
                    break;
            }
            return student;
        }

        public List<Student> SearchStudents(object searchType, string s)
        {
            List<Student> students = new List<Student>();
            switch (searchType)
            {
                case SearchType.Type.ID:
                    foreach (Student student in list)
                        if (student.ID.CompareTo(s) == 0)
                            students.Add(student);
                    break;
                case SearchType.Type.FullName:
                    foreach (Student student in list)
                        if (student.FullName.Contains(s))
                            students.Add(student);
                    break;
                case SearchType.Type.DateOfBirth:
                    foreach (Student student in list)
                        if (student.DateOfBirth == DateTime.Parse(s))
                            students.Add(student);
                    break;
            }
            return students;
        }

        public void ReadFile(string fileName)
        {
            string line;
            string[] s;
            Student student;
            StreamReader sr = new StreamReader(new FileStream(fileName, FileMode.Open));
            while ((line = sr.ReadLine()) != null)
            {
                s = line.Split('*');
                student = new Student();
                student.ID = s[0];
                student.FullName = s[1];
                student.DateOfBirth = DateTime.Parse(s[2]);
                student.Address = s[3];
                student.Class = s[4];
                student.Image = s[5];
                student.Gender = false;
                if (s[6].CompareTo("1") == 0)
                    student.Gender = true;
                string[] f = s[7].Split(',');
                List<String> faculties = new List<string>();
                foreach (string faculty in f)
                    faculties.Add(faculty);
                student.Faculty = faculties;
                AddStudent(student);
            }
        }
    }
}
