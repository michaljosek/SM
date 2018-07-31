using Microsoft.EntityFrameworkCore;
using SM.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace SM.Infrastructure.EF
{
    public class SMContext : DbContext
    {
        public DbSet<Branza> Branzas { get; set; }
        public DbSet<Osoba> Osobas { get; set; }
        public DbSet<AdrAdm> AdrAdms { get; set; }
        public DbSet<AdrUli> AdrUlis { get; set; }
        public DbSet<AdrOsi> AdrOsis { get; set; }
        public DbSet<AdrBud> AdrBuds { get; set; }
        public DbSet<AdrKla> AdrKlas { get; set; }
        public DbSet<AdrLok> AdrLoks { get; set; }
        public DbSet<B07_zglo> B07_zglos { get; set; }
        public DbSet<B07_zlec> B07_zlecs { get; set; }

        public SMContext(DbContextOptions<SMContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\MSSQLLocalDb;Database=SM;Trusted_Connection=true;MultipleActiveResultSets=true;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
