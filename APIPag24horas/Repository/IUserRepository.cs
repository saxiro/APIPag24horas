using APIPag24horas.Model;
using System.Collections.Generic;

namespace APIPag24horas.Business
{
    public interface IUserRepository
    {
        User FindByLogin(string login);
    }
}