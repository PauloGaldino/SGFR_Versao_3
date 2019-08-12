using Domain.Entities.Vendas;
using Domain.Interfaces.Repositories.Vendas;
using Domain.Interfaces.Services.Vendas;

namespace Domain.Services.Vendas
{
    public class ImpostoService : ServiceBase<Imposto>, InterfaceImpostoService
    {
        private readonly InterfaceImpostoRepository _impostoRepository;
        public ImpostoService(InterfaceImpostoRepository impostoRepository) : base(impostoRepository)
        {
            _impostoRepository = impostoRepository;
        }
    }
}
