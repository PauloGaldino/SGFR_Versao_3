using Domain.Entities.Cadastro.Pessoas.Contatos.Telefones;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos.Telefones;
using System.Collections.Generic;
using System.Linq;

namespace InfraData.Repositories.Cadastro.Pessoas.Contatos.Telefones
{
    public class TelefoneTipoRepository : RepositoryBase<TelefoneTipo>, ITelefoneTipoRepository
    {
        public IEnumerable<TelefoneTipo> BuscarPorDescricao(string descricao)
        {
            return Db.TelefoneTipos.Where(tt => tt.Descricao == descricao);
        }
    }
}
