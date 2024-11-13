using Microsoft.EntityFrameworkCore;
using task4.Model;

namespace task4
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=task4.db");
        }

        public void Init()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
    }

}
