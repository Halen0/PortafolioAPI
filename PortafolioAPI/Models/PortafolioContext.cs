using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PortafolioAPI.Models;

public partial class PortafolioContext : DbContext
{
    public PortafolioContext()
    {
    }

    public PortafolioContext(DbContextOptions<PortafolioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contacto> Contactos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contacto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__contacto__3213E83F4D67F3ED");

            entity.ToTable("contacto");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Asunto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("asunto");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Mensaje)
                .IsUnicode(false)
                .HasColumnName("mensaje");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
