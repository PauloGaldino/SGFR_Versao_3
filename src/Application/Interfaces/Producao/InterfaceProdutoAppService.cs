using Domain.Entities.Producao;
using System.Collections.Generic;

namespace Application.Interfaces.Producao
{
    public interface InterfaceProdutoAppService : InterfaceAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
