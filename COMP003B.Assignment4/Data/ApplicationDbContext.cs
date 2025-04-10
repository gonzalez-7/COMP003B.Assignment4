using Microsoft.EntityFrameworkCore;
using COMP003B.Assignment4.Models;

namespace COMP003B.Assignment4.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<Game> Games { get; set; }
		public DbSet<Player> Players { get; set; }
	}
}
