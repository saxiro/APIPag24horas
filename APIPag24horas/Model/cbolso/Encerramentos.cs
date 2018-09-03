using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Encerramentos
    {
        public int IdEncerramento { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Ate { get; set; }
        public int FgAtivo { get; set; }
    }
}
