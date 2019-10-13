using Domain.Entities.Cadastro.Pessoas.Tipos;
using System.Collections.Generic;

namespace Application.Interfaces.Cadastro.Pessoas.Tipos
{
    public interface IJuridicaAppService : IAppServiceBase<Juridica>
    {
        IEnumerable<Juridica> BuscarPeloCnpj(string cnpj);
    }
}
