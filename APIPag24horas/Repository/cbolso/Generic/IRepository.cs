using APIPag24horas.Model.cbolso.Base;
using System.Collections.Generic;

namespace APIPag24horas.Repository.cbolso.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T FindById(int id);
        List<T> FindAll();
        T Update(T item);
        void Delete(int id);

        bool Exists(int? id);
    }
}
