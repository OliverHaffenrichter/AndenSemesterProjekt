using AndenSemesterProjekt.Models;
using Microsoft.EntityFrameworkCore;

namespace AndenSemesterProjekt.EFDbContext
{
    public class MwDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MentallWellness; Integrated Security=True; Connect Timeout=30; Encrypt=False");
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
