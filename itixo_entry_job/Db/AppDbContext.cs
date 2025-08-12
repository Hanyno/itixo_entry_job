using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itixo_entry_job.Db
{
    public class AppDbContext : DbContext
    {
        public DbSet<Wario> Warios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=wario.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Wario>(wario =>
            {
                wario.OwnsOne(w => w.Variable);
                wario.HasMany(w => w.Sensors)
                     .WithOne(s => s.Wario)
                     .HasForeignKey(s => s.WarioId);
            });
            modelBuilder.Entity<SensorData>().HasKey(s => s.Id);
        }
    }
}
