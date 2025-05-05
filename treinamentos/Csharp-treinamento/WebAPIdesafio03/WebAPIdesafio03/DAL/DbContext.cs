using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebAPIdesafio03.Domain.Entity;

#nullable disable

namespace WebAPIdesafio03.DAL
{
    public partial class WebAPIdesafio03_BDContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public WebAPIdesafio03_BDContext()
        {
        }

        public WebAPIdesafio03_BDContext(DbContextOptions<WebAPIdesafio03_BDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Responsavel> Responsavels { get; set; }
        public virtual DbSet<Video> Videos { get; set; }
        public virtual DbSet<VideoCategoria> VideoCategoria { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=WebAPIdesafio03_BD;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

            modelBuilder.Entity<Responsavel>(entity =>
            {
                entity.ToTable("Responsavel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

            modelBuilder.Entity<Video>(entity =>
            {
                entity.ToTable("Video");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdResponsavel).HasColumnName("id_responsavel");

                entity.Property(e => e.IdadeMinima).HasColumnName("idade_minima");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("titulo");

                entity.Property(e => e.UrlVideo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("url_video");
            });

            modelBuilder.Entity<VideoCategoria>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.Property(e => e.IdVideo).HasColumnName("id_video");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
