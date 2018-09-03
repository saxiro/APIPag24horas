using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class FuncionarioMaternidade
    {
        public int Id { get; set; }
        public int? IdEmpresa { get; set; }
        public int? IdFuncionario { get; set; }
        public DateTime? DataIni { get; set; }
        public DateTime? DataFin { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}
