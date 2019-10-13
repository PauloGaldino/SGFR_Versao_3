using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Cadastro.Pessoas.Tipos;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Tipos;

namespace InfraData.Repositories.Cadastro.Pessoas.Tipo
{
    public class JuridicaRepository : RepositoryBase<Juridica>, IJuridicaRepository
    {
        public IEnumerable<Juridica> BuscarPelCnpj(string cnpj)
        {
            return Db.Juridicas.Where(j => j.Cnpj == cnpj);
        }
    }
}
