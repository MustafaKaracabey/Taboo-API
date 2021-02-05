using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Taboo.Core.Models;

namespace Taboo.Data
{
    public class EfDataContext:DbContext
    {
        public EfDataContext(DbContextOptions<EfDataContext> options) : base(options)
        {

        }

        public DbSet<Word> Words { get; set; }
        public DbSet<Tabu> Tabus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Word>()
            .HasMany<Tabu>(g => g.Tabus)
            .WithOne(s => s.Word)
            .HasForeignKey(s => s.WordId)
            .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
