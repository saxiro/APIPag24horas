using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class FranquiasUsuarios
    {
        public int Id { get; set; }
        public int? IdFranquia { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
    }
}
