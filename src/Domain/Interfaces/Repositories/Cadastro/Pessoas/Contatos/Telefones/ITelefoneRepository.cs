using Domain.Entities.Cadastro.Pessoas.Contatos.Telefones;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos.Telefones
{
    public interface ITelefoneRepository : IRepositoryBase<Telefone>
    {
        IEnumerable<Telefone> BuscarPorNumeroTelefone(string numeroTelefone);
    }
}
