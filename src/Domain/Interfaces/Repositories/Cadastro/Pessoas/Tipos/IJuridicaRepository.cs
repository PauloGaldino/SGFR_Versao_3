using Domain.Entities.Cadastro.Pessoas.Tipos;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories.Cadastro.Pessoas.Tipos
{
    public interface IJuridicaRepository : IRepositoryBase<Juridica>
    {
        IEnumerable<Juridica> BuscarPelCnpj(string cnpj);
    }
}
