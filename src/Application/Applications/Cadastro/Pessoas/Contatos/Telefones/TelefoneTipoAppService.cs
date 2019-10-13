using Application.Interfaces.Cadastro.Pessoas.Contatos.Telefones;
using Domain.Entities.Cadastro.Pessoas.Contatos.Telefones;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos.Telefones;
using Domain.Interfaces.Services.Cadastro.Pessoas.Contatos.Telefones;
using Domain.Services;

namespace Application.Applications.Cadastro.Pessoas.Contatos.Telefones
{
    public class TelefoneTipoAppService : ServiceBase<TelefoneTipo>, ITelefoneTipoAppService
    {
        private readonly ITelefoneTipoRepository _telefoneTipoRepository;
        public TelefoneTipoAppService(ITelefoneTipoRepository telefoneTipoRepository) : base(telefoneTipoRepository)
        {
            _telefoneTipoRepository = telefoneTipoRepository;
        }
    }
}
