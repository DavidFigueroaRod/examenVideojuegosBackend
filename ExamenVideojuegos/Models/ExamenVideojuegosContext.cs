using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ExamenVideojuegos.Models;

public partial class ExamenVideojuegosContext : DbContext
{
    public ExamenVideojuegosContext()
    {
    }

    public ExamenVideojuegosContext(DbContextOptions<ExamenVideojuegosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Videojuego> Videojuegos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DAVID-H\\SQLEXPRESS; Initial Catalog=examen_videojuegos; user id=sa; password=root;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Videojuego>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__videojue__3213E83F991ADD66");

            entity.ToTable("videojuego");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Categoria)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("categoria");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Imagen)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("imagen");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Precio).HasColumnName("precio");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
