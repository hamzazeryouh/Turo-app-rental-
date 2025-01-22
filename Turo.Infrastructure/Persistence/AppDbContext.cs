using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turo.Domain.Entities;
using Turo.Infrastructure.UnitOfWork;

namespace Turo.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Agency> Agencies { get; set; }
        public DbSet<AgencyLocation> Locations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AgencyLocation>()
                .HasOne(al => al.Agency)
                .WithMany(a => a.Locations)
                .HasForeignKey(al => al.AgencyId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<MaintenanceRecord>()
               .Property(m => m.Cost)
               .HasColumnType("decimal(18,2)");
            modelBuilder.Entity<DiscountOffer>()
                .Property(m => m.DiscountPercentage)
                .HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Review>()
    .HasOne(r => r.User)
    .WithMany()
    .HasForeignKey(r => r.UserId)
    .OnDelete(DeleteBehavior.Restrict);  // Or DeleteBehavior.SetNull

            base.OnModelCreating(modelBuilder);
        }
    }
}
