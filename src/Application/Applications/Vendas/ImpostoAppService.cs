using Application.Interfaces.Vendas;
using Domain.Entities.Vendas;
using Domain.Interfaces.Services.Vendas;

namespace Application.Applications.Vendas
{
    public class ImpostoAppService : AppServiceBase<Imposto>, IImpostoAppService
    {
        private readonly IImpostoService _impostoService;

        public ImpostoAppService(IImpostoService impostoService)
                : base(impostoService)
        {
            _impostoService = impostoService;
        }
    }
}

