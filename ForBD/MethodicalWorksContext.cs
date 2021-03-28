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
