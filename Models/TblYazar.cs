using System;
using System.Collections.Generic;

#nullable disable

namespace kutuphane24.Models
{
    public partial class TblYazar
    {
        public TblYazar()
        {
            TblKitaps = new HashSet<TblKitap>();
        }

        public int YazarId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Detay { get; set; }

        public virtual ICollection<TblKitap> TblKitaps { get; set; }
    }
}
