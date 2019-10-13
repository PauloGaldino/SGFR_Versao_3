using Application.Interfaces.Cadastro.Pessoas.Contatos.Telefones;
using Domain.Entities.Cadastro.Pessoas.Contatos.Telefones;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos.Telefones;
using Domain.Services;
using System.Collections.Generic;

namespace Application.Applications.Cadastro.Pessoas.Contatos.Telefones
{
    public class TelefoneAppService : ServiceBase<Telefone>, ITelefoneAppService
    {
        private readonly ITelefoneRepository _telefoneRepository;
        public TelefoneAppService(ITelefoneRepository telefoneRepository) : base(telefoneRepository)
        {
            _telefoneRepository = telefoneRepository;
        }

        public IEnumerable<Telefone> BuscarPeloTelefone(string numeroTelefone)
        {
            return _telefoneRepository.BuscarPorNumeroTelefone(numeroTelefone);
        }
    }
}
