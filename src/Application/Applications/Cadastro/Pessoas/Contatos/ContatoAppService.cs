using Application.Interfaces.Cadastro.Pessoas.Contatos;
using Domain.Entities.Cadastro.Pessoas.Contatos;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos;
using Domain.Services;

namespace Application.Applications.Cadastro.Pessoas.Contatos
{
    public class ContatoAppService : ServiceBase<Contato>, IContatoAppService
    {
        private readonly IContatoRepository _contatoRepository;
        public ContatoAppService(IContatoRepository contatoRepository):base(contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }
    }
}
