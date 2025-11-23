using Microsoft.EntityFrameworkCore;

namespace MicroMarket
{
    public class ContextDB: DbContext
    {
        public DbSet<model.Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MicroMarketDB");
        }
    }
}
