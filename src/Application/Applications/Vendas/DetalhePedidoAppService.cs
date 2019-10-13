using Application.Interfaces.Vendas;
using Domain.Entities.Vendas;
using Domain.Interfaces.Repositories.Vendas;
using Domain.Services;

namespace Application.Applications.Vendas
{
    public class DetalhePedidoAppService : ServiceBase<DetalhePedido>, IDetalhePedidoAppService
    {
        private readonly IDetalhePedidoRepository _detalheedidoRepository;
        public DetalhePedidoAppService(IDetalhePedidoRepository detalhePedidoRepository) :base(detalhePedidoRepository)
        {
            _detalheedidoRepository = detalhePedidoRepository;
        }
    }
}
