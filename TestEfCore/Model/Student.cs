using System;
using System.Collections.Generic;
using System.Text;

namespace TestEfCore.Model
{
	public class Student
	{
		public int Id { get; set; }
		public string StudentName { get; set; }
		public int StudentAge { get; set; }
		public string TestStudent { get; set; }
		public string AddStudentProp { get; set; }
		//public string TelePhone { get; set; }
        public string Email { get; set; }
        public int? TestId { get; set; }
        public Test Test { get; set; }
	}
}
