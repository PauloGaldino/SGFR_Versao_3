using Domain.Entities.Cadastro.Pessoas.Clientes;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Clientes;
using Domain.Interfaces.Services.Cadastro.Pessoas;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Services.Cadastro.Pessoas.Clientes
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository):base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}
