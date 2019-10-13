using Application.Interfaces.Vendas;
using Domain.Entities.Vendas;
using Domain.Interfaces.Repositories.Vendas;
using Domain.Services;

namespace Application.Applications.Vendas
{
    public class VendaAppService : ServiceBase<Venda>, IVendaAppService
    {
        private readonly IVendaRepository _vendaRepository;
        public VendaAppService(IVendaRepository vendaRepository) : base(vendaRepository)
        {
            _vendaRepository = vendaRepository;
        }
    }
}
