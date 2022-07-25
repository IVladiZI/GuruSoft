using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Configuration
{
    public class HistoryConfiguration : IEntityTypeConfiguration<HistoryEntity>
    {
        public void Configure(EntityTypeBuilder<HistoryEntity> builder)
        {
            builder.ToTable("History", "gs");

            builder.Property(e => e.DateRequest).HasColumnType("datetime");

            builder.Property(e => e.DateResponse).HasColumnType("datetime");

            builder.Property(e => e.Request).IsUnicode(false);

            builder.Property(e => e.Response).IsUnicode(false);

            builder.Property(e => e.User)
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
