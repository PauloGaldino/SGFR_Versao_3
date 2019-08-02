using Domain.Entities.Producao;
using Domain.Interfaces.Repositories.Producao;
using System.Collections.Generic;
using System.Linq;

namespace InfraData.Repositories.Producao
{
    public class ProdutoRepository : RepositoryBase<Produto>, InterfaceProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Descricao == nome);
        }
    }
}