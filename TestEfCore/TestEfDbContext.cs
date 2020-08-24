using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TestEfCore.Model;

namespace TestEfCore
{
	public class TestEfDbContext:DbContext
	{
		public TestEfDbContext()
		{

		}
		public TestEfDbContext(DbContextOptions<TestEfDbContext> options):base(options)
		{

		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("data source=192.168.0.113;initial catalog=TestDbEfCore1;persist security info=True;user id=sa;password=123456;MultipleActiveResultSets=True;App=EntityFramework");
			}
		}
		public DbSet<Test> Tests { get; set; }
		public DbSet<Student> Students { get; set; }
	}
}
