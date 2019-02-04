using Microsoft.EntityFrameworkCore;
using vega.Models;

namespace vega.Database
{
    public class VegaDbContext : DbContext
    {
        public DbSet<Make> Make { get; set; }
//        public DbSet<Model> Model { get; set; }

        public VegaDbContext(DbContextOptions<VegaDbContext> options) : base(options)        { }

    }
}