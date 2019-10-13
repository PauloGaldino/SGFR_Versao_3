using System.Collections.Generic;
using Domain.Entities.Cadastro.Pessoas.Contatos.Emails;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos.Emails;
using Domain.Interfaces.Services.Cadastro.Pessoas.Contatos.Emails;

namespace Domain.Services.Cadastro.Pessoas.Contatos.Emails
{
    public class EmailService : ServiceBase<Email>, IEmailService
    {
        private readonly IEmailRepository _emailRepository;
        public EmailService(IEmailRepository emailRepository): base(emailRepository)
        {
            _emailRepository = emailRepository;
        }

        public IEnumerable<Email> ObterPorEmail(string enderecoEmail)
        {
            return _emailRepository.BuscarPeloEmail(enderecoEmail);
        }
    }
}
