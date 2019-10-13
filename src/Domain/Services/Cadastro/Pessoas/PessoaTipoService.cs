using Domain.Entities.Cadastro.Pessoas;
using Domain.Interfaces.Repositories.Cadastro.Pessoas;
using Domain.Interfaces.Services.Cadastro.Pessoas;

namespace Domain.Services.Cadastro.Pessoas
{
    public class PessoaTipoService : ServiceBase<PessoaTipo>, IPessoaTipoService
    {
        private readonly IPessoaTipoRepository _pessoaTipoRepository;
        public PessoaTipoService(IPessoaTipoRepository pessoaTipoRepository) :base(pessoaTipoRepository)
        {
            _pessoaTipoRepository = pessoaTipoRepository;
        }
    }
}
