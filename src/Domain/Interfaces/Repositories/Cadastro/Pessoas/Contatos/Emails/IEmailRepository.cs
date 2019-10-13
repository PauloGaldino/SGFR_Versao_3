using Domain.Entities.Cadastro.Pessoas.Contatos.Emails;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos.Emails
{
    public interface IEmailRepository : IRepositoryBase<Email>
    {
        IEnumerable<Email> BuscarPeloEmail(string email);
    }
}
