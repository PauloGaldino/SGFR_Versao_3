using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Cadastro.Pessoas.Tipos;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Tipos;

namespace InfraData.Repositories.Cadastro.Pessoas.Tipo
{
    public class FisicaRepository : RepositoryBase<Fisica>, IFisicaRepository
    {
        public IEnumerable<Fisica> BuscarPeloCpf(string cpf)
        {
            return Db.Fisicas.Where(f => f.Cpf == cpf);
        }
    }
}
