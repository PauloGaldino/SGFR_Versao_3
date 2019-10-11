using Domain.Entities.Producao;
using System.Collections.Generic;

namespace Application.Interfaces.Producao
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
