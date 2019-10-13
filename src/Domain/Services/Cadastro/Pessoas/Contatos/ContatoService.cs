using Domain.Entities.Cadastro.Pessoas.Contatos;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos;
using Domain.Interfaces.Services.Cadastro.Pessoas.Contatos;

namespace Domain.Services.Cadastro.Pessoas.Contatos
{
    public class ContatoService : ServiceBase<Contato>, IContatoService
    {
        private readonly IContatoRepository _contatoRepository;
        public ContatoService(IContatoRepository contatoRepository):base(contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }
    }
}
