using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Tickets
    {
        public int Id { get; set; }
        public string Motivo { get; set; }
        public string Modulo { get; set; }
        public DateTime? Data { get; set; }
        public int? IdRequisitado { get; set; }
        public int? FgAtivo { get; set; }
    }
}
