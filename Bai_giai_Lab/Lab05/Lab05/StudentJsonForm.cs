using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Xml;

namespace Lab05
{
	public partial class StudentJsonForm : Form
	{
		public StudentJsonForm()
		{
			InitializeComponent();
		}

		public List<StudentInfo> LoadJSON(string Path)
		{
			// Khai baso ds lưu trữ
			List<StudentInfo> List = new List<StudentInfo>();
			// Đối tượng đọc tập tin
			StreamReader r = new StreamReader(Path);
			string json = r.ReadToEnd(); // Đọc hết
			// Chuyển về thành mảng các đối tượng
			var array = (JObject)JsonConvert.DeserializeObject(json);
			// Lấy đói tượng sinhvien
			var students = array["sinhvien"].Children();
			foreach (var item in students)// Duyệt mảng
			{
				// Lấy các thành phần
				string mssv = item["MSSV"].Value<string>();
				string fullname = item["hoten"].Value<string>();
				int age = item["tuoi"].Value<int>();
				double mark = item["diem"].Value<double>();
				bool tongiao = item["tongiao"].Value<bool>();

				//Chuyển vào đối tượng StrudentInfo
				StudentInfo info = new StudentInfo(mssv, fullname, age, mark, tongiao);
				List.Add(info); // Thêm vào danh sách
			}
			return List;

		}

		private void btnJson_Click(object sender, EventArgs e)
		{
			string Str = "";
			string Path = "../../student.json";
			List<StudentInfo> list = LoadJSON(Path);
			for (int i = 0; i < list.Count; i++)
			{
				StudentInfo info = list[i];
				Str += string.Format("Sinh viên {0} có MSSV: {1},  họ tên: {2}, điểm TB: {3}\n", (i + 1), info.MSSV, info.FullName, info.Mark);
			}
			MessageBox.Show(Str, "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnXml_Click(object sender, EventArgs e)
		{
			var xmlDoc = new XmlDocument();
			xmlDoc.Load("../../books.xml");

			var nodeList = xmlDoc.DocumentElement.SelectNodes("/catalog/book");

			foreach (XmlNode node in nodeList)
			{
				var isbn = node.Attributes["ISBN"].Value;
				var title = node.SelectSingleNode("title").InnerText;
				var price = node.SelectSingleNode("price").InnerText;
				var firstName = node.SelectSingleNode("author/first-name").InnerText;
				var lastName = node.SelectSingleNode("author/last-name").InnerText;
				MessageBox.Show(String.Format("{0, -15}{1,-50}{2, -15}{3, -15}{4,6}",
					isbn, title, firstName, lastName, price));

			}
		}
	}
}
