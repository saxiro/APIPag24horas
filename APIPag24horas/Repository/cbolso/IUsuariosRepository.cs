using APIPag24horas.Model.cbolso;
using System.Collections.Generic;

namespace APIPag24horas.Repository.cbolso
{
	public interface IUsuariosRepository
    {
        Usuarios Create(Usuarios item);
        Usuarios FindById(int id);
        List<Usuarios> FindAll();
        Usuarios Update(Usuarios item);
        void Delete(int id);

        bool Exists(int? id);
    }
}
