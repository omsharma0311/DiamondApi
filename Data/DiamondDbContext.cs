using DiamondApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiamondApi.Data
{
    public class DiamondDbContext : DbContext
    {
        public DiamondDbContext(DbContextOptions<DiamondDbContext> options) : base(options)
        {
                
        }
        public DbSet<Diamond> Diamond { get; set; }
        public DbSet<DiamondImage> DiamondImage { get; set; }
    }
}
