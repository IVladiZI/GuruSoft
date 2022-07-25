using System;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Repository.Data.Configuration;

#nullable disable

namespace Repository.Data
{
    public partial class GuruSoftContext : DbContext
    {
        public GuruSoftContext()
        {
        }

        public GuruSoftContext(DbContextOptions<GuruSoftContext> options)
            : base(options)
        {
        }
        public virtual DbSet<HistoryEntity> History { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new HistoryConfiguration());
        }
    }
}
