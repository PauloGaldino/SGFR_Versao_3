using Domain.Entities.Cadastro.Pessoas.Contatos.Telefones;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos.Telefones;
using Domain.Interfaces.Services.Cadastro.Pessoas.Contatos.Telefones;
using System.Collections.Generic;

namespace Domain.Services.Cadastro.Pessoas.Contatos.Telefones
{
    public class TelefoneTipoService : ServiceBase<TelefoneTipo>, ITelefoneTipoService
    {
        private readonly ITelefoneTipoRepository _telefoneTipoRepository;
        public TelefoneTipoService(ITelefoneTipoRepository telefoneTipoRepository) :base(telefoneTipoRepository)
        {
            _telefoneTipoRepository = telefoneTipoRepository;
        }
        public IEnumerable<TelefoneTipo> ObterTelefone(string descricao)
        {
            return _telefoneTipoRepository.BuscarPorDescricao(descricao);
        }
    }
}
