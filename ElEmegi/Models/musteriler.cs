using System;
using System.Collections.Generic;

namespace ElEmegi.Models
{
    public partial class musteriler
    {
        public musteriler()
        {
            this.Sepets = new List<Sepet>();
        }

        public int id { get; set; }
        public string kullanici_adi { get; set; }
        public string sifre { get; set; }
        public string musteri_adi { get; set; }
        public string musteri_soyadi { get; set; }
        public string eposta { get; set; }
        public string adres { get; set; }
        public string telefon { get; set; }
        public Nullable<System.DateTime> tarih { get; set; }
        public virtual ICollection<Sepet> Sepets { get; set; }
    }
}
