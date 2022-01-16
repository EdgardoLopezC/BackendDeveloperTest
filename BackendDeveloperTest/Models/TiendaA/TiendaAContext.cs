using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BackendDeveloperTest.Models.TiendaA
{
    public partial class tiendaAContext : DbContext
    {
        public tiendaAContext()
        {
        }

        public tiendaAContext(DbContextOptions<tiendaAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Repuesto> Repuestos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-V812RAH\\SQLSERVER;Database=tiendaA;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Repuesto>(entity =>
            {
                entity.ToTable("Repuesto");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AnhoCarro)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("anho_carro")
                    .IsFixedLength();

                entity.Property(e => e.MarcaCarro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("marca_carro");

                entity.Property(e => e.MarcaRepuesto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("marca_repuesto");

                entity.Property(e => e.ModeloCarro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("modelo_carro");

                entity.Property(e => e.NombreRepuesto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_repuesto");

                entity.Property(e => e.PrecioRepuesto)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("precio_repuesto");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
