using System;
using System.Collections.Generic;

#nullable disable

namespace kutuphane24.Models
{
    public partial class TblUye
    {
        public TblUye()
        {
            TblCezalars = new HashSet<TblCezalar>();
            TblHarekets = new HashSet<TblHareket>();
        }

        public int UyeId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Mail { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Fotograf { get; set; }
        public string Telefon { get; set; }
        public string Okul { get; set; }

        public virtual ICollection<TblCezalar> TblCezalars { get; set; }
        public virtual ICollection<TblHareket> TblHarekets { get; set; }
    }
}
