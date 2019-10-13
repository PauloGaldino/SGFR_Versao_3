using Domain.Entities.Vendas;
using Domain.Interfaces.Repositories.Vendas;
using Domain.Interfaces.Services.Vendas;

namespace Domain.Services.Vendas
{
    public class DetalheVendaService : ServiceBase<DetalheVenda>, IDetalheVendaService
    {
        private readonly IDetalheVendaRepository _detalheVendaRepository;
        public DetalheVendaService(IDetalheVendaRepository detalheVendaRepository): base(detalheVendaRepository)
        {
            _detalheVendaRepository = detalheVendaRepository;
        }
    }
}
