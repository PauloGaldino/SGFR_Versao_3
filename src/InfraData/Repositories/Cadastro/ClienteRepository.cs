using Domain.Entities.Cadastro.Pessoas.Clientes;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Clientes;

namespace InfraData.Repositories.Cadastro
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
    }
}
