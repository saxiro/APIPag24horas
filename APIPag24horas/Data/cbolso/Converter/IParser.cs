using System.Collections.Generic;

namespace APIPag24horas.Data.cbolso.Converter
{
	public interface IParser<O, D>
    {
        D Parse(O origin);
        List<D> ParseList(List<O> origin);
    }
}
