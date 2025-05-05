using Microsoft.EntityFrameworkCore;
using WebDespensaAPI.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDespensaAPI.DAL
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options)
	   : base(options)
		{
		}
		public virtual DbSet<Usuario> Usuarios { get; set; }

		public virtual DbSet<Produto> Produtos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(x => x.nome).IsUnicode(false);
                entity.Property(x => x.senha).IsUnicode(false);
                entity.Property(x => x.email).IsUnicode(false);
                entity.Property(x => x.numCartao).IsUnicode(false);
            });


            modelBuilder.Entity<Produto>(entity =>
            {
                entity.Property(x => x.nome).IsUnicode(false);
                entity.HasOne(x => x.Usuario) // entidade virtual que indica relação
                .WithMany(y => y.Produtos) 
                .HasForeignKey(x => x.idUsuario) 
                .OnDelete(DeleteBehavior.Restrict); 
            });


        }
    }
}
