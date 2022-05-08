using DiamondApi.Models;
using System.Data.Entity;

namespace DiamondApi.Data
{
    public class DiamondDbContext : DbContext
    {
        public DiamondDbContext() : base("name=DefaultConnection")
        {
                
        }
        public DbSet<Diamond> Diamond { get; set; }
        public DbSet<DiamondImage> DiamondImage { get; set; }
        public DbSet<Retailer> Retailer { get; set; }

    }
}
