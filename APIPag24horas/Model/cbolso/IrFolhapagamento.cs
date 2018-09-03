using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class IrFolhapagamento
    {
        public int Id { get; set; }
        public decimal? ValorMin { get; set; }
        public decimal? ValorMax { get; set; }
        public decimal? Percentual { get; set; }
        public decimal? ParcelaDeduzir { get; set; }
    }
}
