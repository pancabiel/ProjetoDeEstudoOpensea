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
                    .HasData(
                    new Arte
                    {
                    id = 1,
                    nome = "Ape"
                },
                new Arte
                {
                    id = 2,
                    nome = "Cripto Punk",
                    preco = 3500
                },
                new Arte
                {
                    id = 3,
                    nome = "Teste"
                }
                );

            base.OnModelCreating(builder);
        }

        public DbSet<Arte> Artes { get; set; }
        public DbSet<Colecao> Colecoes { get; set; }
        public DbSet<Venda> Vendas { get; set; }
    }
}
