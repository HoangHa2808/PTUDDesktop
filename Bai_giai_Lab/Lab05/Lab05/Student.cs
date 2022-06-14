using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
	public class Student
	{
		public string ID { get; set; }
		public string LastName { get; set; }
		public DateTime Birthday { get; set; }
		public string CMND { get; set; }
		public string Address { get; set; }
		public bool Gender { get; set; }
		public string FirstName { get; set; }
		public string Class { get; set; }
		public string PhoneNumber { get; set; }
		public List<string> Faculty { get; set; }
		public Student()
		{

		}
		public Student(string id, string lastname, DateTime birthday, string cmnd, string address, bool gender, string firstname, string @class, string phone, List<string> faculty)
		{
			ID = id;
			LastName = lastname;
			Birthday = birthday;
			CMND = cmnd;
			Address = address;
			Gender = gender;
			FirstName = firstname;
			Class = @class;
			PhoneNumber = phone;
			Faculty = faculty;
		}
	}
}
