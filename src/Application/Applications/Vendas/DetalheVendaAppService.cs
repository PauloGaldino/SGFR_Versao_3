using Application.Interfaces.Vendas;
using Domain.Entities.Vendas;
using Domain.Interfaces.Repositories.Vendas;
using Domain.Services;

namespace Application.Applications.Vendas
{
    public class DetalheVendaAppService : ServiceBase<DetalheVenda>, IDetalheVendaAppService
    {
        private readonly IDetalheVendaRepository _detalheVendaRepository;
        public DetalheVendaAppService(IDetalheVendaRepository detalheVendaRepository) : base(detalheVendaRepository)
        {
            _detalheVendaRepository = detalheVendaRepository;
        }
    }
}
