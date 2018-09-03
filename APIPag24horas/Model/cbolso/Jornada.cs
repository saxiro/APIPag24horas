using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Jornada
    {
        public int IdJornada { get; set; }
        public int IdFuncionario { get; set; }
        public string Dia { get; set; }
        public string Desde { get; set; }
        public string Descanso { get; set; }
        public string Ate { get; set; }
        public int FgAtivo { get; set; }
    }
}
