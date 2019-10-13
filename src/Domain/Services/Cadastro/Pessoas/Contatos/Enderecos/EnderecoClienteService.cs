using Domain.Entities.Cadastro.Pessoas.Contatos.Enderecos;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos.Enderecos;
using Domain.Interfaces.Services.Cadastro.Pessoas.Contatos.Enderecos;

namespace Domain.Services.Cadastro.Pessoas.Contatos.Enderecos
{
    public class EnderecoClienteService : ServiceBase<EnderecoCliente>, IEnderecoClienteService
    {
        private readonly IEnderecoClienteRepository _enderecoClienteRepository;
        public EnderecoClienteService(IEnderecoClienteRepository enderecoClienteRepository): base(enderecoClienteRepository)
        {
            _enderecoClienteRepository = enderecoClienteRepository;
        }
    }
}
