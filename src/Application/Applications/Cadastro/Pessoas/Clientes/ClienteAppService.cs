using Application.Interfaces.Cadastro;
using Domain.Entities.Cadastro.Pessoas.Clientes;
using Domain.Interfaces.Services.Cadastro.Pessoas;
using System.Collections.Generic;

namespace Application.Applications.Cadastro.Pessoas.Clientes
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
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
