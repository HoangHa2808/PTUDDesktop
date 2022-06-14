using System;
using System.Collections.Generic;

namespace Lab03_Demo
{
    public class Student
    {
        public string ID { get; set; }
        public string FullName { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Class { get; set; }
        public string Address { get; set; }
        public List<string> Faculty { get; set; }
        public string Image { get; set; }
        public Student() { }
        public Student(string id, string fullName, bool gender, DateTime dateOfBirth, string @class, string address, List<string> faculty, string image)
        {
            ID = id;
            FullName = fullName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Class = @class;
            Address = address;
            Faculty = faculty;
            Image = image;
        }
    }
}
