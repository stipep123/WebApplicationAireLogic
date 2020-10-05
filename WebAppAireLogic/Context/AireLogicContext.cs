using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAireLogic.Entities;

namespace WebAppAireLogic.Context
{
    public class AireLogicContext : DbContext
    {
        public AireLogicContext(DbContextOptions<AireLogicContext> options) : base(options) { }
        
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().HasKey(ar => ar.Id);

            modelBuilder.Entity<Song>().HasKey(s => s.Id);

            modelBuilder.Entity<Album>().HasKey(al => al.Id);
        }
    }
}
