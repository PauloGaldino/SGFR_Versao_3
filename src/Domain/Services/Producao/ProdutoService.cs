using Domain.Entities.Producao;
using Domain.Interfaces.Repositories.Producao;
using Domain.Interfaces.Services.Producao;
using System.Collections.Generic;

namespace Domain.Services.Producao
{
     public class ProdutoService : ServiceBase<Produto>, InterfaceProdutoService
    {
        private readonly InterfaceProdutoRepository _produtoRepository;

        public ProdutoService(InterfaceProdutoRepository produtoRepository)
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