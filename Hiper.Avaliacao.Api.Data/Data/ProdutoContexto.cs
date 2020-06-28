
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using Hiper.Produto.Api.Models;

namespace Hiper.Produto.Api.Data
{
    public class ProdutoContexto : DbContext
    {
        public ProdutoContexto() : base ("HiperContext")
        {

        }
        public DbSet<ProdutoModel> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
