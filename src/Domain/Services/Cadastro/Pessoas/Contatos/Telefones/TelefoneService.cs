using System.Collections.Generic;
using Domain.Entities.Cadastro.Pessoas.Contatos.Telefones;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos.Telefones;
using Domain.Interfaces.Services.Cadastro.Pessoas.Contatos.Telefones;

namespace Domain.Services.Cadastro.Pessoas.Contatos.Telefones
{
    public class TelefoneService : ServiceBase<Telefone>, ITelefoneService
    {
        private readonly ITelefoneRepository _telefoneRepository;
        public TelefoneService(ITelefoneRepository telefoneRepository) : base(telefoneRepository)
        {
            _telefoneRepository = telefoneRepository;
        }
        public IEnumerable<Telefone> ObterTelefone(string numeroTelefone)
        {
            return _telefoneRepository.BuscarPorNumeroTelefone(numeroTelefone);
        }
    }
}
