using Hiper.Avaliacao.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Hiper.Avaliacao.Data.Context
{
    public class HiperContext : DbContext
    {
        public HiperContext( ) : base ("HiperContext")
        {

        }

        public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
