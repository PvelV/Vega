using Microsoft.EntityFrameworkCore;

namespace vega.Database
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options) : base(options)
        {

        }
    }
}