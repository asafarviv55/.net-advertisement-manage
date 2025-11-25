using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Models;

namespace WinFormsApp2.Data
{
    internal class AppDbContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<AdCreative> AdCreatives { get; set; }
        public DbSet<TargetingCriteria> TargetingCriterias { get; set; }
        public DbSet<BudgetAllocation> BudgetAllocations { get; set; }
        public DbSet<AdPerformance> AdPerformances { get; set; }
        public DbSet<ABTest> ABTests { get; set; }
        public DbSet<AudienceSegment> AudienceSegments { get; set; }
        public DbSet<AdPlacement> AdPlacements { get; set; }
        public DbSet<PerformanceReport> PerformanceReports { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=your_server_name;Database=NewspaperAdvertising;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>()
                .HasKey(ur => new { ur.UserID, ur.RoleID });

            modelBuilder.Entity<RolePermission>()
                .HasKey(rp => new { rp.RoleID, rp.PermissionID });

            // Further configurations for relationships
        }



    }
}
