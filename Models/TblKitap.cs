using System;
using System.Collections.Generic;

#nullable disable

namespace kutuphane24.Models
{
    public partial class TblKitap
    {
        public TblKitap()
        {
            TblHarekets = new HashSet<TblHareket>();
        }

        public int KitapId { get; set; }
        public string Ad { get; set; }
        public int? Kategori { get; set; }
        public int? Yazar { get; set; }
        public string BasimYil { get; set; }
        public string YayinEvi { get; set; }
        public string Sayfa { get; set; }
        public bool? Durum { get; set; }

        public virtual TblKategori KategoriNavigation { get; set; }
        public virtual TblYazar YazarNavigation { get; set; }
        public virtual ICollection<TblHareket> TblHarekets { get; set; }
    }
}
