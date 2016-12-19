using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ElEmegi.Models.Mapping
{
    public class UrunlerMap : EntityTypeConfiguration<Urunler>
    {
        public UrunlerMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Baslik)
                .HasMaxLength(50);

            this.Property(t => t.Aciklama)
                .HasMaxLength(200);

            this.Property(t => t.Fiyat)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Urunler");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Baslik).HasColumnName("Baslik");
            this.Property(t => t.Aciklama).HasColumnName("Aciklama");
            this.Property(t => t.ResimYol).HasColumnName("ResimYol");
            this.Property(t => t.Fiyat).HasColumnName("Fiyat");
            this.Property(t => t.Kategori).HasColumnName("Kategori");
        }
    }
}
