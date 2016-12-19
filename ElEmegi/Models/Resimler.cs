using System;
using System.Collections.Generic;

namespace ElEmegi.Models
{
    public partial class Resimler
    {
        public int id { get; set; }
        public string ResimYolu { get; set; }
        public int ResimUrunid { get; set; }
        public virtual Urunler Urunler { get; set; }
    }
}
