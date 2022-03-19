using System;
using System.Collections.Generic;

#nullable disable

namespace kutuphane24.Models
{
    public partial class VwKitap
    {
        public int KitapId { get; set; }
        public string Ad { get; set; }
        public string KategoriAd { get; set; }
        public string YazarAdi { get; set; }
        public string BasimYil { get; set; }
        public string YayinEvi { get; set; }
        public string Sayfa { get; set; }
        public string Durum { get; set; }
    }
}
