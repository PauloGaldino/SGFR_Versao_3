using Domain.Entities.Producao;
using System.Collections.Generic;

namespace Domain.Interfaces.Services.Producao
{
    public interface InterfaceProdutoService : InterfaceServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
