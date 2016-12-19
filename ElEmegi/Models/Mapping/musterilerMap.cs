using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ElEmegi.Models.Mapping
{
    public class musterilerMap : EntityTypeConfiguration<musteriler>
    {
        public musterilerMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.kullanici_adi)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.sifre)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.musteri_adi)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.musteri_soyadi)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.eposta)
                .HasMaxLength(50);

            this.Property(t => t.telefon)
                .IsFixedLength()
                .HasMaxLength(11);

            // Table & Column Mappings
            this.ToTable("musteriler");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.kullanici_adi).HasColumnName("kullanici_adi");
            this.Property(t => t.sifre).HasColumnName("sifre");
            this.Property(t => t.musteri_adi).HasColumnName("musteri_adi");
            this.Property(t => t.musteri_soyadi).HasColumnName("musteri_soyadi");
            this.Property(t => t.eposta).HasColumnName("eposta");
            this.Property(t => t.adres).HasColumnName("adres");
            this.Property(t => t.telefon).HasColumnName("telefon");
            this.Property(t => t.tarih).HasColumnName("tarih");
        }
    }
}
