using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DL;

public partial class LibrosContext : DbContext
{
    public LibrosContext()
    {
    }

    public LibrosContext(DbContextOptions<LibrosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Autor> Autors { get; set; }

    public virtual DbSet<Editorial> Editorials { get; set; }

    public virtual DbSet<Libro> Libros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ALIEN28; Database= Libros; Trusted_Connection=True;TrustServerCertificate=True; User ID=sa; Password=pass@word1;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autor>(entity =>
        {
            entity.HasKey(e => e.IdAutor).HasName("PK__Autor__DD33B031666758A1");

            entity.ToTable("Autor");

            entity.Property(e => e.ApellidoMaterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApellidoPaterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Editorial>(entity =>
        {
            entity.HasKey(e => e.IdEditorial).HasName("PK__Editoria__EF83867155898A92");

            entity.ToTable("Editorial");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Libro>(entity =>
        {
            entity.HasKey(e => e.IdLibro).HasName("PK__Libros__3E0B49AD8F6A075B");

            entity.Property(e => e.AñoPublicacion)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Titulo)
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.HasOne(d => d.AutorNavigation).WithMany(p => p.Libros)
                .HasForeignKey(d => d.Autor)
                .HasConstraintName("FK__Libros__Autor__173876EA");

            entity.HasOne(d => d.EditorialNavigation).WithMany(p => p.Libros)
                .HasForeignKey(d => d.Editorial)
                .HasConstraintName("FK__Libros__Editoria__182C9B23");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
