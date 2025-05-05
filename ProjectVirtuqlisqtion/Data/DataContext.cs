using Microsoft.EntityFrameworkCore;
using ProjectVirtuqlisqtion.Models;

namespace ProjectVirtuqlisqtion.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
