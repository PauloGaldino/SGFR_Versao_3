using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Cadastro.Pessoas;
using Domain.Interfaces.Repositories.Cadastro.Pessoas;
using Domain.Interfaces.Services.Cadastro.Pessoas;

namespace Domain.Services.Cadastro.Pessoas
{
    public class PessoaService : ServiceBase<Pessoa>, IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;
        public PessoaService(IPessoaRepository pessoaRepository): base(pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public IEnumerable<Pessoa> BuscarPorNome(string nome)
        {
            return _pessoaRepository.BuscarPorNome(nome);
        }
    }
}
