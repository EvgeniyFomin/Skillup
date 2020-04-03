using Microsoft.EntityFrameworkCore;
using RealWorldAPI.Models;

namespace RealWorldAPI.DataAccess
{
    public class RealWorldDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public RealWorldDbContext(DbContextOptions<RealWorldDbContext> options)
            : base(options)
        {

        }
    }
}
