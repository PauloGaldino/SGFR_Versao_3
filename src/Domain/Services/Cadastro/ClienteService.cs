using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Cadastro;
using Domain.Interfaces.Repositories.Cadastro;
using Domain.Interfaces.Services.Cadastro;

namespace Domain.Services.Cadastro
{
    public class ClienteService : ServiceBase<Cliente>, InterfaceClienteService
    {
        private readonly InterfaceClienteRepository _clienteRepository;
        public ClienteService(InterfaceClienteRepository clienteRepository):base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}
