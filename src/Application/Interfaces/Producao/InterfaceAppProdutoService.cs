using Domain.Entities.Producao;
using System.Collections.Generic;

namespace Application.Interfaces.Producao
{
    public interface InterfaceAppProdutoService : InterfaceAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
