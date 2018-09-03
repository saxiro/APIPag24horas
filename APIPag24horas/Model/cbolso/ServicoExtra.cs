using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class ServicoExtra
    {
        public int Id { get; set; }
        public string Servico { get; set; }
        public string Descricao { get; set; }
        public float? Valor { get; set; }
        public string Prazo { get; set; }
    }
}
