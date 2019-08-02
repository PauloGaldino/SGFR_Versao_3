using Domain.Entities.Cadastro;
using System.Collections.Generic;

namespace Application.Interfaces.Cadastro
{
    public interface InterfaceClienteAppService : InterfaceAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}
