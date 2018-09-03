using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class CamposValidacao
    {
        public string Tabela { get; set; }
        public string Campo { get; set; }
        public string Apelido { get; set; }
        public int? Tipo { get; set; }
        public int Id { get; set; }
        public int? Tamanho { get; set; }
        public string Pktabela { get; set; }
        public int? FgRequisitos { get; set; }
    }
}
