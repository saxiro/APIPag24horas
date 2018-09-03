using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Duvidas
    {
        public sbyte? Opcao { get; set; }
        public sbyte? Fase { get; set; }
        public string Pergunta { get; set; }
        public string Resposta { get; set; }
        public int IdDuvida { get; set; }
    }
}
