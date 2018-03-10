using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ProspectManager.Models;

namespace ProspectManager.Data
{

    // EF context class
    public class Context : DbContext
    {
        public DbSet<Prospect> Prospects { get; set; }
        public DbSet<College> Colleges { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // remove the pluralizing table name convention, our table names will use our entity class singular names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
