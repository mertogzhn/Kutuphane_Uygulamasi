using System;
using System.Collections.Generic;

#nullable disable

namespace kutuphane24.Models
{
    public partial class TblCezalar
    {
        public int CezaId { get; set; }
        public int? Uye { get; set; }
        public DateTime? Başlangıç { get; set; }
        public DateTime? Bitiş { get; set; }
        public decimal? Para { get; set; }
        public int? Hareket { get; set; }

        public virtual TblHareket HareketNavigation { get; set; }
        public virtual TblUye UyeNavigation { get; set; }
    }
}
