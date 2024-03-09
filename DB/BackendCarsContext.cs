using Microsoft.EntityFrameworkCore;
namespace DB
{
    public class BackendCarsContext(DbContextOptions<BackendCarsContext> options) : DbContext(options)
    {
        public DbSet<Cars> Cars {  get; set; }
    }
}
