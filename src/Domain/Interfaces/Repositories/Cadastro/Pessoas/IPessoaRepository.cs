using Domain.Entities.Cadastro.Pessoas;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories.Cadastro.Pessoas
{
    public interface IPessoaRepository : IRepositoryBase<Pessoa>
    {
        IEnumerable<Pessoa> BuscarPorNome(string nome);
    }
}
