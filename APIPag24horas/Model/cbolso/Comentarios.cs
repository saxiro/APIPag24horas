using System;
using System.Collections.Generic;

namespace APIPag24horas.Model.cbolso
{
    public partial class Comentarios
    {
        public int IdComentario { get; set; }
        public int? IdRequisitado { get; set; }
        public int? IdUsuariocb { get; set; }
        public DateTime? DataComentario { get; set; }
        public string Comentario { get; set; }
        public int? Modulo { get; set; }
        public int? Tipo { get; set; }
    }
}
