using APIPag24horas.Data.cbolso.VO;
using APIPag24horas.Data.VO;
using System.Collections.Generic;

namespace APIPag24horas.Business.cbolso.Implementations
{
    public interface IApitesteBusiness
    {
        ApitesteVO Create(ApitesteVO item);
        ApitesteVO FindById(int id);
        List<ApitesteVO> FindAll();
        ApitesteVO Update(ApitesteVO item);
        void Delete(int id);
    }
}
