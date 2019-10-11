using Domain.Entities.Producao;
using System.Collections.Generic;

namespace Domain.Interfaces.Services.Producao
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
