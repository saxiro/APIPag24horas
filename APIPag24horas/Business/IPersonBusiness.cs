using APIPag24horas.Data.VO;
using System.Collections.Generic;

namespace APIPag24horas.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(long id);
        List<PersonVO> FindAll();
        List<PersonVO> FindByName(string firstName, string lastName);
        PersonVO Update(PersonVO person);
        void Delete(long id);
    }
}
