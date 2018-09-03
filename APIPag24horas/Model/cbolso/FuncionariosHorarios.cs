using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class FuncionariosHorarios
    {
        public int Id { get; set; }
        public int? IdFuncionario { get; set; }
        public int? DiaSemana { get; set; }
        public TimeSpan? Entrada { get; set; }
        public TimeSpan? AlmocoIni { get; set; }
        public TimeSpan? AlmocoFin { get; set; }
        public TimeSpan? Saida { get; set; }
    }
}
