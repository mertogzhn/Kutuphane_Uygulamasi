using System;
using System.Collections.Generic;

#nullable disable

namespace kutuphane24.Models
{
    public partial class TblKategori
    {
        public TblKategori()
        {
            TblKitaps = new HashSet<TblKitap>();
        }

        public int KategoriId { get; set; }
        public string KategoriAd { get; set; }

        public virtual ICollection<TblKitap> TblKitaps { get; set; }
    }
}
