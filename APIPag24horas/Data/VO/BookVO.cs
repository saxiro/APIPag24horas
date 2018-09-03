using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Tapioca.HATEOAS;

namespace APIPag24horas.Data.VO
{
    [DataContract]
    public class BookVO : ISupportsHyperMedia
    {
        [DataMember (Order = 1, Name = "codigo")]
        public long? Id { get; set; }
        [DataMember (Order = 2, Name = "Título")]
        public string Title { get; set; }
        [DataMember (Order = 3, Name = "Autor")]
        public string Author { get; set; }
        [DataMember (Order = 5, Name = "Preço")]
        public decimal Price { get; set; }
        [DataMember (Order = 4, Name = "Edição")]
        public DateTime LaunchDate { get; set; }
        [DataMember (Order = 6, Name = "Links")]
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
