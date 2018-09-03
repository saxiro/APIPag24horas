using APIPag24horas.Data.cbolso.VO;
using APIPag24horas.Data.VO;
using System.Collections.Generic;

namespace APIPag24horas.Business.cbolso.Implementations
{
    public interface IFuncionariosBusiness
    {
        FuncionariosVO Create(FuncionariosVO item);
        FuncionariosVO FindById(int id);
        List<FuncionariosVO> FindAll();
        FuncionariosVO Update(FuncionariosVO item);
        void Delete(int id);
    }
}
