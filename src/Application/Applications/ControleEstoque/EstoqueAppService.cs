using Application.Interfaces.ControleEstoque;
using Domain.Entities.ControleEstoque;
using Domain.Interfaces.Repositories.ControleEstoque;
using Domain.Services;

namespace Application.Applications.ControleEstoque
{
    public class EstoqueAppService : ServiceBase<Estoque>, IEstoqueAppService
    {
        private readonly IEstoqueRepository _estoqueRepository;
        public EstoqueAppService(IEstoqueRepository estoqueRepository): base(estoqueRepository)
        {
            _estoqueRepository = estoqueRepository;
        }
    }
}
