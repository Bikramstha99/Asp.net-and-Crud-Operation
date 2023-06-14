using ASPNETMVC.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASPNETMVC.Data
{
    public class MvcDemoDbContext : DbContext
    {
        public MvcDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Empolyees { get; set; }
    }
}
