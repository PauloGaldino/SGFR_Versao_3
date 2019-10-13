using Domain.Entities.Cadastro.Pessoas.Contatos.Telefones;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos.Telefones
{
    public interface ITelefoneTipoRepository :IRepositoryBase<TelefoneTipo>
    {
        IEnumerable<TelefoneTipo> BuscarPorDescricao(string descricao);
    }
}
