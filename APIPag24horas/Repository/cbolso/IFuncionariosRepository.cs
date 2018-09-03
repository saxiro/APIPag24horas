using APIPag24horas.Model.cbolso;
using System.Collections.Generic;

namespace APIPag24horas.Repository.cbolso
{
	public interface IFuncionariosRepository
    {
        Funcionarios Create(Funcionarios item);
        Funcionarios FindById(int id);
        List<Funcionarios> FindAll();
        Funcionarios Update(Funcionarios item);
        void Delete(int id);

        bool Exists(int? id);
    }
}
