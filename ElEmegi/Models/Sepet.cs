using System;
using System.Collections.Generic;

namespace ElEmegi.Models
{
    public partial class Sepet
    {
        public int id { get; set; }
        public int musteri_id { get; set; }
        public int Urunid { get; set; }
        public virtual musteriler musteriler { get; set; }
        public virtual Urunler Urunler { get; set; }
    }
}
