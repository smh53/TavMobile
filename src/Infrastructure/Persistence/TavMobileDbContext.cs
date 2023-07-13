using Domain.SectionAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class TavMobileDbContext : DbContext
    {
        public TavMobileDbContext(DbContextOptions<TavMobileDbContext> options) : base(options)
        {
        }

        public DbSet<Section> Sections { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .ApplyConfigurationsFromAssembly(typeof(TavMobileDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}