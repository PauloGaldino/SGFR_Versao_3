using Domain.Entities.Cadastro.Pessoas.Contatos.Enderecos;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos.Enderecos;
using Domain.Interfaces.Services.Cadastro.Pessoas.Contatos.Enderecos;

namespace Domain.Services.Cadastro.Pessoas.Contatos.Enderecos
{
    public class EnderecoPessoaService : ServiceBase<EnderecoPessoa>, IEnderecoPessoaService
    {
        private readonly IEnderecoPessoaRepository _enredecoPessoaRepository;
        public EnderecoPessoaService(IEnderecoPessoaRepository enredecoPessoaRepository) : base(enredecoPessoaRepository)
        {
            _enredecoPessoaRepository = enredecoPessoaRepository;
        }
    }
}
