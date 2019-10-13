using Domain.Entities.Cadastro.Pessoas.Clientes;
using System.Collections.Generic;

namespace Application.Interfaces.Cadastro
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}
