using System;
using System.Collections.Generic;

#nullable disable

namespace kutuphane24.Models
{
    public partial class TblHareket
    {
        public TblHareket()
        {
            TblCezalars = new HashSet<TblCezalar>();
        }

        public int HareketId { get; set; }
        public int? Kitap { get; set; }
        public int? Uye { get; set; }
        public int? Personel { get; set; }
        public DateTime? AlısTarih { get; set; }
        public DateTime? İadeTarih { get; set; }

        public virtual TblKitap KitapNavigation { get; set; }
        public virtual TblUye UyeNavigation { get; set; }
        public virtual ICollection<TblCezalar> TblCezalars { get; set; }
    }
}
