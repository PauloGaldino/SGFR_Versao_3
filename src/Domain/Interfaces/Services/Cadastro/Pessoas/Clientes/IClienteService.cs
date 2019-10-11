using Domain.Entities.Cadastro.Pessoas.Clientes;
using System.Collections.Generic;

namespace Domain.Interfaces.Services.Cadastro.Pessoas
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}
