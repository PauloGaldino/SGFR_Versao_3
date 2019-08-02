using Application.Interfaces.Cadastro;
using Domain.Entities.Cadastro;
using Domain.Interfaces.Services.Cadastro;
using System.Collections.Generic;

namespace Application.Applications.Cadastro
{
    public class ClienteAppService : AppServiceBase<Cliente>, InterfaceClienteAppService
    {
        private readonly InterfaceClienteService _clienteService;

        public ClienteAppService(InterfaceClienteService clienteService)
                : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais()
        {
            return _clienteService.ObterClientesEspeciais(_clienteService.GetAll());
        }
    }
}
