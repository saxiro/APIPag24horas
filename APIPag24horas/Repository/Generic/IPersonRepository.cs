using APIPag24horas.Model;
using System.Collections.Generic;

namespace APIPag24horas.Repository.Generic
{
    public interface IPersonRepository : IRepository<Person>
    {
        List<Person> FindByName(string firstName, string lastName);
    }
}
