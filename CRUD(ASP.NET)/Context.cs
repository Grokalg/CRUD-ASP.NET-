using CRUD_ASP.NET_.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_ASP.NET_
{
	public class Context:DbContext
	{
		public Context() 
		{
			Database.EnsureCreated();
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql(@"host=localhost;port=5432;database=asp_test_db;username=postgres;password=postgres");
		}

		public DbSet<User> Users { get; set; }
	}
}
