using System;
using System.Collections.Generic;

namespace ElEmegi.Models
{
    public partial class Urunler
    {
        public Urunler()
        {
            this.Resimlers = new List<Resimler>();
            this.Sepets = new List<Sepet>();
        }

        public int id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string ResimYol { get; set; }
        public string Fiyat { get; set; }
        public Nullable<int> Kategori { get; set; }
        public virtual ICollection<Resimler> Resimlers { get; set; }
        public virtual ICollection<Sepet> Sepets { get; set; }
    }
}
