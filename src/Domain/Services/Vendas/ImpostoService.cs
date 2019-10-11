using Domain.Entities.Vendas;
using Domain.Interfaces.Repositories.Vendas;
using Domain.Interfaces.Services.Vendas;

namespace Domain.Services.Vendas
{
    public class ImpostoService : ServiceBase<Imposto>, IImpostoService
    {
        private readonly IImpostoRepository _impostoRepository;
        public ImpostoService(IImpostoRepository impostoRepository) : base(impostoRepository)
        {
            _impostoRepository = impostoRepository;
        }
    }
}
