using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
	public class StudentInfo
	{
		public string MSSV { get; set; }
		public string FullName { get; set; }
		public int Age { get; set; }
		public double Mark { get; set; }
		public bool TonGiao { get; set; }

		// Phương thức tạo lập
		public StudentInfo(string mssv, string fullname, int age, double mark, bool tongiao)
		{
			this.MSSV = mssv;
			this.FullName = fullname;
			this.Age = age;
			this.Mark = mark;
			this.TonGiao = tongiao;
		}
	}
}
