using Domain.Entities.Vendas;
using Domain.Interfaces.Repositories.Vendas;
using Domain.Interfaces.Services.Vendas;

namespace Domain.Services.Vendas
{
    public class VendaService : ServiceBase<Venda>, IVendaService
    {
        private readonly IVendaRepository _vendaRepository;
        public VendaService(IVendaRepository vendaRepository): base(vendaRepository)
        {
            _vendaRepository = vendaRepository; 
        }
    }
}
;