using Domain.Entities.ControleEstoque;
using Domain.Interfaces.Repositories.ControleEstoque;
using Domain.Interfaces.Services.ControleEstoque;

namespace Domain.Services.ControleEstoque
{
    public class EstoqueService : ServiceBase<Estoque>, IEstoqueService
    {
        private readonly IEstoqueRepository _estoqueRepository;
        public EstoqueService(IEstoqueRepository estoqueRepository): base(estoqueRepository)
        {
            _estoqueRepository = estoqueRepository;
        }
    }
}
