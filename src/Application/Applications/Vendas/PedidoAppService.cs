using Application.Interfaces.Vendas;
using Domain.Entities.Vendas;
using Domain.Interfaces.Repositories.Vendas;
using Domain.Services;

namespace Application.Applications.Vendas
{
    public class PedidoAppService: ServiceBase<Pedido>, IPedidoAppService
    {
        private readonly IPedidoRepository _pedidoRepository;
        public PedidoAppService(IPedidoRepository pedidoRepository):base(pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
    }
}
