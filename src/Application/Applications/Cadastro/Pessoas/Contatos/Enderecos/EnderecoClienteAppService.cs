using Application.Interfaces.Cadastro.Pessoas.Contatos.Enderecos;
using Domain.Entities.Cadastro.Pessoas.Contatos.Enderecos;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos.Enderecos;
using Domain.Services;

namespace Application.Applications.Cadastro.Pessoas.Contatos.Enderecos
{
    public class EnderecoClienteAppService : ServiceBase<EnderecoCliente>, IEnderecoClienteAppService
    {
        private readonly IEnderecoClienteRepository _enderecoClienteRepository;
        public EnderecoClienteAppService(IEnderecoClienteRepository enderecoClienteRepository): base(enderecoClienteRepository)
        {
            _enderecoClienteRepository = enderecoClienteRepository;
        }
    }
}
