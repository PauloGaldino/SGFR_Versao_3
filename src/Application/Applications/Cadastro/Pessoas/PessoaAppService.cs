using Application.Interfaces.Cadastro.Pessoas;
using Domain.Entities.Cadastro.Pessoas;
using Domain.Interfaces.Repositories.Cadastro.Pessoas;
using Domain.Services;
using System.Collections.Generic;

namespace Application.Applications.Cadastro.Pessoas
{
    public class PessoaAppService : ServiceBase<Pessoa>, IPessoaAppService
    {
        private readonly IPessoaRepository _pessoaRepository;
        public PessoaAppService(IPessoaRepository pessoaRepository): base(pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public IEnumerable<Pessoa> BuscarPorNome(string nome)
        {
            return _pessoaRepository.BuscarPorNome(nome);
        }
    }
}
