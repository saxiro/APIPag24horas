using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class AlteracoesParaBancoProducao
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public DateTime Data { get; set; }
        public int FgAprovado { get; set; }
        public int FgFeito { get; set; }
        public string Descricao { get; set; }
    }
}
