using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjetoDeEstudoOpensea.Model;

namespace ProjetoDeEstudoOpensea.Database
{
    public class AppContextDb : IdentityDbContext<Usuario>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=TesteOpensea;Integrated Security=True;Trust Server Certificate=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Arte>()
                .HasOne(a => a.Colecao)
                .WithMany(c => c.Artes)
                .HasForeignKey(a => a.ColecaoId);

            builder.Entity<Arte>()
                .HasOne(a => a.Proprietario)
                .WithMany(u => u.Artes)
                .HasForeignKey(a => a.ProprietarioId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Colecao>()
                .HasOne(c => c.Autor)
                .WithMany(u => u.Colecoes)
                .HasForeignKey(c => c.AutorId)
                .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(builder);
        }

        public DbSet<Arte> Artes { get; set; }
        public DbSet<Colecao> Colecoes { get; set; }
        public DbSet<Venda> Vendas { get; set; }
    }
}
