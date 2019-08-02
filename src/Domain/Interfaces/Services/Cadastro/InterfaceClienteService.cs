using Domain.Entities.Cadastro;
using System.Collections.Generic;

namespace Domain.Interfaces.Services.Cadastro
{
    public interface InterfaceClienteService : InterfaceServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}
