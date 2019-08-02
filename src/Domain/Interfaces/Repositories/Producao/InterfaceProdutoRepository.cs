using Domain.Entities.Producao;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories.Producao
{
   public interface InterfaceProdutoRepository : InterfaceRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
