using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ElEmegi.Models.Mapping
{
    public class ResimlerMap : EntityTypeConfiguration<Resimler>
    {
        public ResimlerMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.ResimYolu)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Resimler");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.ResimYolu).HasColumnName("ResimYolu");
            this.Property(t => t.ResimUrunid).HasColumnName("ResimUrunid");

            // Relationships
            this.HasRequired(t => t.Urunler)
                .WithMany(t => t.Resimlers)
                .HasForeignKey(d => d.ResimUrunid);

        }
    }
}
