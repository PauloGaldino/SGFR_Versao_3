using Domain.Entities.Vendas;
using Domain.Interfaces.Repositories.Vendas;
using Domain.Interfaces.Services.Vendas;

namespace Domain.Services.Vendas
{
     public class PedidoService : ServiceBase<Pedido>, IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepsitory;
        public PedidoService(IPedidoRepository pedidoRepsitory):base(pedidoRepsitory)
        {
            _pedidoRepsitory = pedidoRepsitory;
        }
    }
}
