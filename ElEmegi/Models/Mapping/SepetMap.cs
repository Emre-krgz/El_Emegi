using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ElEmegi.Models.Mapping
{
    public class SepetMap : EntityTypeConfiguration<Sepet>
    {
        public SepetMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Sepet");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.musteri_id).HasColumnName("musteri_id");
            this.Property(t => t.Urunid).HasColumnName("Urunid");

            // Relationships
            this.HasRequired(t => t.musteriler)
                .WithMany(t => t.Sepets)
                .HasForeignKey(d => d.musteri_id);
            this.HasRequired(t => t.Urunler)
                .WithMany(t => t.Sepets)
                .HasForeignKey(d => d.Urunid);

        }
    }
}
