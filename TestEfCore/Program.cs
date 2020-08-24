using System;
using System.Linq;
using TestEfCore.Model;

namespace TestEfCore
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var dbcontext = new TestEfDbContext())
			{
				//for (int i = 0; i < 10; i++)
				//{
				//	var test1 = new Test
				//	{
				//		TestName =i
				//	};
				//	var student = new Student
				//	{
				//		StudentAge = i,
				//		StudentPhone = $"{i + 10}",
				//		StudnetName = $"线上测试数据 {i}"
				//	};
				//	dbcontext.Add(test1);
				//	dbcontext.Add(student);
				//}
				//dbcontext.SaveChanges();
				var students = dbcontext.Students.ToList();
				foreach (var item in students)
				{
					Console.WriteLine(item.StudentName);
				}
			}
			Console.WriteLine("Hello World!");
		}
	}
}
