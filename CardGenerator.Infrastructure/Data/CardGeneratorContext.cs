using System;
using CardGenerator.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CardGenerator.Infrastructure.Data
{
    public partial class CardGeneratorContext : DbContext
    {
        public CardGeneratorContext()
        {
        }

        public CardGeneratorContext(DbContextOptions<CardGeneratorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Card> Cards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Card>(entity =>
            {
                entity.HasKey(e => new { e.CardNumber, e.Email });

                entity.ToTable("Card");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

        }
    }
}
