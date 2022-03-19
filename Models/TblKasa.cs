using System;
using System.Collections.Generic;

#nullable disable

namespace kutuphane24.Models
{
    public partial class TblKasa
    {
        public int KasaId { get; set; }
        public string Ay { get; set; }
        public decimal? Tutar { get; set; }
    }
}
