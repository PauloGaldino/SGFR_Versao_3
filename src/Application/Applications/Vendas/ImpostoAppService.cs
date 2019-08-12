using Application.Interfaces.Vendas;
using Domain.Entities.Vendas;
using Domain.Interfaces.Services.Vendas;

namespace Application.Applications.Vendas
{
    public class ImpostoAppService : AppServiceBase<Imposto>, InterfaceImpostoAppService
    {
        private readonly InterfaceImpostoService _impostoService;

        public ImpostoAppService(InterfaceImpostoService impostoService)
                : base(impostoService)
        {
            _impostoService = impostoService;
        }
    }
}

