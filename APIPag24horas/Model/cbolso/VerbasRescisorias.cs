using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class VerbasRescisorias
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string TipoVerba { get; set; }
        public float? Valor { get; set; }
        public string Unidade { get; set; }
        public sbyte? ValorUnidade { get; set; }
        public sbyte? Sinal { get; set; }
        public sbyte? Obrigatorio { get; set; }
        public string Comentario { get; set; }
    }
}
