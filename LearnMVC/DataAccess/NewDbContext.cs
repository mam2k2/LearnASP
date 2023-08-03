using LearnMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnMVC.DataAccess
{
    public class NewDbContext : DbContext
    {
        public NewDbContext(DbContextOptions<NewDbContext> options) : base(options)
        {
        }
        public DbSet<Users> Users { get; set; }
    }
}
