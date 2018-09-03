using System;
using System.Collections.Generic;
using Tapioca.HATEOAS;

namespace APIPag24horas.Data.cbolso.VO
{
    public partial class ApitesteVO : ISupportsHyperMedia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
