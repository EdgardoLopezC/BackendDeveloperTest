using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BackendDeveloperTest.Models.TiendaC
{
    public partial class tiendaCContext : DbContext
    {
        public tiendaCContext()
        {
        }

        public tiendaCContext(DbContextOptions<tiendaCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Carro> Carros { get; set; } = null!;
        public virtual DbSet<Marca> Marcas { get; set; } = null!;
        public virtual DbSet<Modelo> Modelos { get; set; } = null!;
        public virtual DbSet<Repuesto> Repuestos { get; set; } = null!;
        public virtual DbSet<TipoRepuesto> TipoRepuestos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-V812RAH\\SQLSERVER;Database=tiendaC;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Carro");

                entity.Property(e => e.Anho)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("anho")
                    .IsFixedLength();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdModelo).HasColumnName("id_modelo");
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Marca");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Modelo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Modelo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdMarca).HasColumnName("id_marca");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Repuesto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Repuesto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCarro).HasColumnName("id_carro");

                entity.Property(e => e.IdMarca).HasColumnName("id_marca");

                entity.Property(e => e.IdTipoRepuesto).HasColumnName("id_tipo_repuesto");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("precio");
            });

            modelBuilder.Entity<TipoRepuesto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tipo_Repuesto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
