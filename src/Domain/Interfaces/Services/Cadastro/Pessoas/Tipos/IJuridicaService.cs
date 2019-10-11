using Domain.Entities.Cadastro.Pessoas.Tipos;
using System.Collections.Generic;

namespace Domain.Interfaces.Services.Cadastro.Pessoas.Tipos
{
    public interface IJuridicaService : IServiceBase<Juridica>
    {
        IEnumerable<Juridica> ObterJuridica(IEnumerable<Juridica> juridicas);
    }
}
