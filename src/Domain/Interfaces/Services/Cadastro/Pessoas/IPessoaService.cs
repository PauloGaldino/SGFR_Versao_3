using Domain.Entities.Cadastro.Pessoas;
using System.Collections.Generic;

namespace Domain.Interfaces.Services.Cadastro.Pessoas
{
    public interface IPessoaService : IServiceBase<Pessoa>
    {
        IEnumerable<Pessoa> ObterPessoa(IEnumerable<Pessoa> pessoas);
    }
}
