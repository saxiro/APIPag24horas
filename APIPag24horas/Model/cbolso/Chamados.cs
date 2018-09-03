using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Chamados
    {
        public int IdChamado { get; set; }
        public string Assunto { get; set; }
        public int IdEmpresa { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataUltimaMod { get; set; }
        public sbyte Status { get; set; }
        public sbyte FgComment { get; set; }
        public int? FgNovaresposta { get; set; }
        public int? IdArea { get; set; }
        public int? Tipo { get; set; }
        public int? IdUsuarioCriador { get; set; }
        public int? FgNovarespostaCbolso { get; set; }
        public string Mensagem { get; set; }
    }
}
