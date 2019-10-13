using Application.Interfaces.Cadastro.Pessoas.Contatos.Enderecos;
using Domain.Entities.Cadastro.Pessoas.Contatos.Enderecos;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos.Enderecos;
using Domain.Services;

namespace Application.Applications.Cadastro.Pessoas.Contatos.Enderecos
{
    public class EnderecoPessoaAppService : ServiceBase<EnderecoPessoa>, IEnderecoPessoaAppService
    {
        private readonly IEnderecoPessoaRepository _enredecoPessoaRepository;
        public EnderecoPessoaAppService(IEnderecoPessoaRepository enredecoPessoaRepository) : base(enredecoPessoaRepository)
        {
            _enredecoPessoaRepository = enredecoPessoaRepository;
        }
    }
}
