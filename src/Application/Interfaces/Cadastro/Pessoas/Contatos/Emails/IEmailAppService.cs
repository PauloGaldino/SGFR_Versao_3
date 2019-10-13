using Domain.Entities.Cadastro.Pessoas.Contatos.Emails;
using System.Collections.Generic;

namespace Application.Interfaces.Cadastro.Pessoas.Contatos.Emails
{
    public interface IEmailAppService : IAppServiceBase<Email>
    {
        IEnumerable<Email> BuscarPeloEmail(string enderecoEmail);
    }
}
