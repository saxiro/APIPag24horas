using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class AtividadesEconomicasPCopy
    {
        public int IdOpcao { get; set; }
        public string DescOpcao { get; set; }
        public string IdHtml { get; set; }
        public int? FgAtivo { get; set; }
        public int? DataGrupo { get; set; }
        public int? DataAtividade { get; set; }
        public int? DataAtividadePrimeiroFilho { get; set; }
    }
}
