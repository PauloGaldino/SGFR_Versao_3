using Domain.Entities.Cadastro.Pessoas;
using Domain.Interfaces.Repositories.Cadastro.Pessoas;
using System.Collections.Generic;
using System.Linq;

namespace InfraData.Repositories.Cadastro.Pessoas
{
    public class PessoaRepository : RepositoryBase<Pessoa>, IPessoaRepository
    {
        public IEnumerable<Pessoa> BuscarPorNome(string nomeProduto)
        {
            return Db.Pessoas.Where(p => p.Nome == nomeProduto);
        }
    }
}
