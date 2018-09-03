using APIPag24horas.Data.cbolso.VO;
using APIPag24horas.Data.VO;
using System.Collections.Generic;

namespace APIPag24horas.Business.cbolso.Implementations
{
    public interface IUsuariosBusiness
    {
        UsuariosVO Create(UsuariosVO item);
        UsuariosVO FindById(int id);
        List<UsuariosVO> FindAll();
        UsuariosVO Update(UsuariosVO item);
        void Delete(int id);
    }
}
