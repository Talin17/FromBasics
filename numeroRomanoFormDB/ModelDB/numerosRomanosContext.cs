using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace numeroRomanoFormDB.ModelDB
{
    public partial class numerosRomanosContext : DbContext
    {
        public numerosRomanosContext()
        {
        }

        public numerosRomanosContext(DbContextOptions<numerosRomanosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Centena> Centenas { get; set; } = null!;
        public virtual DbSet<Decena> Decenas { get; set; } = null!;
        public virtual DbSet<Unidad> Unidads { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=numerosRomanos;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Centena>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Centena");

                entity.Property(e => e.Centenas)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Decena>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Decena");

                entity.Property(e => e.Decenas)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Unidad>(entity =>
            {
                entity.ToTable("Unidad");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unidades)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
