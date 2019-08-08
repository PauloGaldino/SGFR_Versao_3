using Application.Interfaces.Producao;
using Domain.Entities.Producao;
using Domain.Interfaces.Services.Producao;
using System.Collections.Generic;

namespace Application.Applications.Producao
{
    public class ProdutoAppService : AppServiceBase<Produto>, InterfaceProdutoAppService
    {
        private readonly InterfaceProdutoService _produtoService;

        public ProdutoAppService(InterfaceProdutoService produtoService)
            : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoService.BuscarPorNome(nome);
        }
    }
}