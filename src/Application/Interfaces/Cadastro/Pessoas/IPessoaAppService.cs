using Domain.Entities.Cadastro.Pessoas;
using System.Collections.Generic;

namespace Application.Interfaces.Cadastro.Pessoas
{
    public interface IPessoaAppService : IAppServiceBase<Pessoa>
    {
        IEnumerable<Pessoa> BuscarPorNome(string nome);
    }
}
