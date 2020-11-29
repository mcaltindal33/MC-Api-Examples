using System;
using System.Collections.Generic;
using System.Text;

namespace MC.Core.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public string Tanim { get; set; }
        public int KategoriId { get; set; }
        public int Stok { get; set; }
        public bool Durum { get; set; }
        public bool IsDeleted { get; set; }
        public string InnerBarcode { get; set; }
        public virtual Kategori Kategori { get; set; }
    }
}
