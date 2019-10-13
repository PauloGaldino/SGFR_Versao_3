using Domain.Entities.Cadastro.Pessoas.Contatos.Telefones;
using System.Collections.Generic;

namespace Application.Interfaces.Cadastro.Pessoas.Contatos.Telefones
{
    public interface ITelefoneAppService : IAppServiceBase<Telefone>
    {
        IEnumerable<Telefone> BuscarPeloTelefone(string numeroTelefone);
    }
}
