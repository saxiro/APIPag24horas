using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Ferias
    {
        public int IdEmpresa { get; set; }
        public int IdFuncionario { get; set; }
        public DateTime InicFerias { get; set; }
        public DateTime FimFerias { get; set; }
    }
}
