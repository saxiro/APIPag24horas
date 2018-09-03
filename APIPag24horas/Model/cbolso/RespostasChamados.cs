using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class RespostasChamados
    {
        public int IdResposta { get; set; }
        public int IdChamado { get; set; }
        public string Resposta { get; set; }
        public DateTime DataResposta { get; set; }
        public sbyte? OrdenRespost { get; set; }
        public sbyte? Tipo { get; set; }
        public int IdUsuario { get; set; }
        public int? FgAceita { get; set; }
    }
}
