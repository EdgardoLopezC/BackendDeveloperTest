using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BackendDeveloperTest.Models.CentralDeRepuesto
{
    public partial class CentralDeRepuestoContext : DbContext
    {
        public CentralDeRepuestoContext()
        {
        }

        public CentralDeRepuestoContext(DbContextOptions<CentralDeRepuestoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tiendum> Tienda { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-V812RAH\\SQLSERVER;Database=CentralDeRepuesto;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tiendum>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("id")
                    .IsFixedLength();

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Rating)
                    .HasColumnType("decimal(2, 1)")
                    .HasColumnName("rating");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
