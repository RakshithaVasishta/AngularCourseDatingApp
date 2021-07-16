using DatingAppFromCourse.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingAppFromCourse.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; }

    }
}