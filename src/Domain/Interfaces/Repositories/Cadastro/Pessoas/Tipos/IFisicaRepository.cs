using Domain.Entities.Cadastro.Pessoas.Tipos;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories.Cadastro.Pessoas.Tipos
{
    public interface IFisicaRepository : IRepositoryBase<Fisica>
    {
        IEnumerable<Fisica> BuscarPeloCpf(string cpf);
    }
}
