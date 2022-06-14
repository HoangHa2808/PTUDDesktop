using System;

namespace _2011401_TranBaoLam_Lab04
{
    public class Student
    {
        public string ID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public string Class { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageLink { get; set; }
        public Student() { }
        public Student(string id, string fullName, string email, string address, DateTime dateOfBirth, bool gender, string @class, string phoneNumber, string imageLink)
        {
            ID = id;
            FullName = fullName;
            Email = email;
            Address = address;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Class = @class;
            PhoneNumber = phoneNumber;
            ImageLink = imageLink;
        }
    }
}
