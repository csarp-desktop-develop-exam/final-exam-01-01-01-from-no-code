using KretaProject.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.IO;


namespace KretaProject.Context
{
    internal class KretaContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<SchoolClass> SchoolClasses { get; set; }

        public KretaContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // az orders.db fájlt át kell másolni a bin/Debug mappa megfelelő mappájába 
            string dbPath = Path.Combine(Environment.CurrentDirectory, "kreta.db");
            using (var connection = new SqliteConnection($"Data Source={dbPath}"))
                optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Tábla nevének explicit megadása
            modelBuilder.Entity<Student>().ToTable("student");
            modelBuilder.Entity<SchoolClass>().ToTable("schoolclass");
        }
    }
}
