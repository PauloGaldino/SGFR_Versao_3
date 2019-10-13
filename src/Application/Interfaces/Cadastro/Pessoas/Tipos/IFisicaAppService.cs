using Domain.Entities.Cadastro.Pessoas.Tipos;
using System.Collections.Generic;

namespace Application.Interfaces.Cadastro.Pessoas.Tipos
{
    public interface IFisicaAppService : IAppServiceBase<Fisica>
    {
        IEnumerable<Fisica> BuscarPeloCpf(string cpf);
    }
}
