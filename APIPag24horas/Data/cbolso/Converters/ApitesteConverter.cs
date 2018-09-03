using APIPag24horas.Data.cbolso.VO;
using APIPag24horas.Data.Converter;
using APIPag24horas.Model.cbolso;
using System.Collections.Generic;
using System.Linq;

namespace APIPag24horas.Data.cbolso.Converters
{
    public class ApitesteConverter : IParser<ApitesteVO, Apiteste>, IParser<Apiteste, ApitesteVO>
    {
        public Apiteste Parse(ApitesteVO origin)
        {
            if (origin == null) return new Apiteste();
            return new Apiteste
            {
                Id = origin.Id,
                Nome = origin.Nome,
                Descricao = origin.Descricao
            };
        }

        public ApitesteVO Parse(Apiteste origin)
        {
            if (origin == null) return new ApitesteVO();
            return new ApitesteVO
            {
                Id = origin.Id,
                Nome = origin.Nome,
                Descricao = origin.Descricao
            };
        }

        public List<Apiteste> ParseList(List<ApitesteVO> origin)
        {
            if (origin == null) return new List<Apiteste>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<ApitesteVO> ParseList(List<Apiteste> origin)
        {
            if (origin == null) return new List<ApitesteVO>();
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
