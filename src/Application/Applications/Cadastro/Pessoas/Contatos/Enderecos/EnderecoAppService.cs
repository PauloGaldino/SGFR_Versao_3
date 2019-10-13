using Application.Interfaces.Cadastro.Pessoas.Contatos.Enderecos;
using Domain.Entities.Cadastro.Pessoas.Contatos.Enderecos;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos.Enderecos;
using Domain.Services;
using System.Collections.Generic;

namespace Application.Applications.Cadastro.Pessoas.Contatos.Enderecos
{
    public class EnderecoAppService : ServiceBase<Endereco>, IEnderecoAppService
    {
        private readonly IEnderecoRepository _enderecoRepository;
        public EnderecoAppService(IEnderecoRepository enderecoRepository): base(enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }
        public IEnumerable<Endereco> BuscarPeloCep(string cep)
        {
            return _enderecoRepository.BuscarPelóCep(cep);
        }
    }
}
