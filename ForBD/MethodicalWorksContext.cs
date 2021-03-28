using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForBD
{
    public class MethodicalWorksContext : DbContext
    {
        public MethodicalWorksContext()
        {
        }

        public MethodicalWorksContext(DbContextOptions<MethodicalWorksContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=(localdb)\\MSSQLLocalDB;Database=MethodicalWorks;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Typography>().HasOne<Accounting>(t => t.Accounting).WithOne(a => a.Typography)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<MaterialDiscipline>().HasKey(md => new {md.DisciplineId, md.MaterialId});
            modelBuilder.Entity<Recommendation>().HasOne<Plan>(r => r.Plan).WithMany(p => p.Recommendations)
                .OnDelete(DeleteBehavior.NoAction);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Accounting> Accountings { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<MaterialDiscipline> MaterialDisciplines { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Recommendation> Recommendations { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Typography> Typographies { get; set; }
    }
}