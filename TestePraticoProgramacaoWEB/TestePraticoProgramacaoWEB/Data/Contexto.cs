using Microsoft.EntityFrameworkCore;
using TestePraticoProgramacaoWEB.Models;

namespace TestePraticoProgramacaoWEB.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        { }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<CategoriaProduto> CategoriaProduto { get; set; }
    }
}
