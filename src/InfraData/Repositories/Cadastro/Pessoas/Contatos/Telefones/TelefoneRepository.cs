using Domain.Entities.Cadastro.Pessoas.Contatos.Telefones;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos.Telefones;
using System.Collections.Generic;
using System.Linq;

namespace InfraData.Repositories.Cadastro.Pessoas.Contatos.Telefones
{
    public class TelefoneRepository : RepositoryBase<Telefone>, ITelefoneRepository
    {
        public IEnumerable<Telefone> BuscarPorNumeroTelefone(string numeroTelefone)
        {
            return Db.Telefones.Where(t => t.Numero == numeroTelefone);
        }
    }
}
