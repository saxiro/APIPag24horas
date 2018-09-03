using APIPag24horas.Business;
using APIPag24horas.Model;
using APIPag24horas.Model.Context;
using System;
using System.Linq;

namespace APIPag24horas.Repository.Implementattions
{
    public class UserRepositoryImpl: IUserRepository
    {
        private readonly MySQLContext _context;

        public UserRepositoryImpl(MySQLContext context)
        {
            _context = context;
        }

        public User FindByLogin(string login)
        {
            return _context.Users.SingleOrDefault(u => u.Login.Equals(login));
        }
    }
}
