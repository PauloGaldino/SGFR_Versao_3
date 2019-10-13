using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Cadastro.Pessoas.Contatos.Emails;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos.Emails;

namespace InfraData.Repositories.Cadastro.Pessoas.Contatos.Emails
{
    public class EmailRepository : RepositoryBase<Email>, IEmailRepository
    {
        public IEnumerable<Email> BuscarPeloEmail(string email)
        {
            return Db.Emails.Where(em => em.EnderecoEmail == email);
        }
    }
}
