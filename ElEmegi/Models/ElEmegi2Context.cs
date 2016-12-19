using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ElEmegi.Models.Mapping;

namespace ElEmegi.Models
{
    public partial class ElEmegi2Context : DbContext
    {
        static ElEmegi2Context()
        {
            Database.SetInitializer<ElEmegi2Context>(null);
        }

        public ElEmegi2Context()
            : base("Name=ElEmegi2Context")
        {
        }

        public DbSet<Manset> Mansets { get; set; }
        public DbSet<musteriler> musterilers { get; set; }
        public DbSet<Resimler> Resimlers { get; set; }
        public DbSet<Sepet> Sepets { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MansetMap());
            modelBuilder.Configurations.Add(new musterilerMap());
            modelBuilder.Configurations.Add(new ResimlerMap());
            modelBuilder.Configurations.Add(new SepetMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new UrunlerMap());
        }
    }
}
