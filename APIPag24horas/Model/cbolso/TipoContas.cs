using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class TipoContas
    {
        public int IdTipo { get; set; }
        public string Nome { get; set; }
        public string Conta { get; set; }
        public int? IdConta { get; set; }
    }
}
