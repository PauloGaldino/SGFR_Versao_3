using System.Collections.Generic;
using Domain.Entities.Cadastro.Pessoas.Contatos.Enderecos;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos.Enderecos;
using Domain.Interfaces.Services.Cadastro.Pessoas.Contatos.Enderecos;

namespace Domain.Services.Cadastro.Pessoas.Contatos.Enderecos
{
    public class EnderecoService : ServiceBase<Endereco>, IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;
        public EnderecoService(IEnderecoRepository enderecoRepository) : base(enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

        public IEnumerable<Endereco> ObterEndereco(string cep)
        {
            return _enderecoRepository.BuscarPelóCep(cep);
        }
    }
}
