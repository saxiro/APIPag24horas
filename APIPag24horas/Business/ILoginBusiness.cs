using APIPag24horas.Data.VO;
using APIPag24horas.Model;

namespace APIPag24horas.Business
{
    public interface ILoginBusiness
    {
        object FindByLogin(UserVO user);
    }
}
