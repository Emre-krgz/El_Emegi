using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ElEmegi.Models.Mapping
{
    public class MansetMap : EntityTypeConfiguration<Manset>
    {
        public MansetMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Mbaslik)
                .HasMaxLength(50);

            this.Property(t => t.Maciklama)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Manset");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Mbaslik).HasColumnName("Mbaslik");
            this.Property(t => t.Maciklama).HasColumnName("Maciklama");
            this.Property(t => t.MresimYol).HasColumnName("MresimYol");
        }
    }
}
