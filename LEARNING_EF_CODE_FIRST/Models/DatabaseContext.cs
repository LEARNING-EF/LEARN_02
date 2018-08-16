namespace Models
{
	//public class Baghali : System.Data.Entity.DbContext

	public class DatabaseContext : System.Data.Entity.DbContext
	{
		static DatabaseContext()
		{
		}

		public DatabaseContext() : base()
		{
		}

		public System.Data.Entity.DbSet<Person> People { get; set; }
	}
}
