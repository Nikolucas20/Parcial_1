using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.Models;

public partial class VeterinariaContext : DbContext
{
    public VeterinariaContext()
    {
    }

    public VeterinariaContext(DbContextOptions<VeterinariaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comidum> Comida { get; set; }

    public virtual DbSet<Dueño> Dueños { get; set; }

    public virtual DbSet<Mascota> Mascotas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-FSFFO4R\\SQLEXPRESS; Database=Veterinaria; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comidum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Comida_1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Precio).HasColumnName("precio");
            entity.Property(e => e.TipoComida)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("tipoComida");
            entity.Property(e => e.TipoMascota)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("tipoMascota");
        });

        modelBuilder.Entity<Dueño>(entity =>
        {
            entity.ToTable("Dueño");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Edad).HasColumnName("edad");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.TipoMascota)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tipoMascota");
        });

        modelBuilder.Entity<Mascota>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EdadMascota)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("edadMascota");
            entity.Property(e => e.NombreMascota)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombreMascota");
            entity.Property(e => e.Raza)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("raza");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
