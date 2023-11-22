using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DbFirstEF.Models
{
    public partial class TestDbContext : DbContext
    {
        public TestDbContext()
        {
        }

        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<One> Ones { get; set; } = null!;
        public virtual DbSet<Parent> Parents { get; set; } = null!;
        public virtual DbSet<ToMany1> ToMany1s { get; set; } = null!;
        public virtual DbSet<ToOne> ToOnes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TestDb;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<One>(entity =>
            {
                entity.HasIndex(e => e.ToMany1Id, "IX_Ones_ToMany1Id");

                entity.HasOne(d => d.ToMany1)
                    .WithMany(p => p.Ones)
                    .HasForeignKey(d => d.ToMany1Id);
            });

            modelBuilder.Entity<Parent>(entity =>
            {
                entity.HasKey(e => e.ParentKey);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ToOne>(entity =>
            {
                entity.HasIndex(e => e.RelatedToOneId, "IX_ToOnes_RelatedToOneId");

                entity.HasOne(d => d.RelatedToOne)
                    .WithMany(p => p.ToOnes)
                    .HasForeignKey(d => d.RelatedToOneId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
