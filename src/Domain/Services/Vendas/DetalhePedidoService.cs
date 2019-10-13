using Domain.Entities.Vendas;
using Domain.Interfaces.Repositories.Vendas;
using Domain.Interfaces.Services.Vendas;

namespace Domain.Services.Vendas
{
    public class DetalhePedidoService : ServiceBase<DetalhePedido>, IDetalhePedidoService
    {
        private readonly IDetalhePedidoRepository _detalhePedidoRepository;
        public DetalhePedidoService(IDetalhePedidoRepository detalhePedidoRepository) :base(detalhePedidoRepository)
        {
            _detalhePedidoRepository = detalhePedidoRepository;
        }
    }
}
