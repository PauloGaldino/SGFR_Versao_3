using Domain.Entities.Producao;
using Domain.Interfaces.Repositories.Producao;
using Domain.Interfaces.Services.Producao;
using System.Collections.Generic;

namespace Domain.Services.Producao
{
     public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
                : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepository.BuscarPorNome(nome);
        }
    }
}