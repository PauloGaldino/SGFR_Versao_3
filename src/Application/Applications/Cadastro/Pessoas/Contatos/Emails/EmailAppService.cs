using System.Collections.Generic;
using Application.Interfaces.Cadastro.Pessoas.Contatos.Emails;
using Domain.Entities.Cadastro.Pessoas.Contatos.Emails;
using Domain.Interfaces.Repositories.Cadastro.Pessoas.Contatos.Emails;
using Domain.Services;

namespace Application.Applications.Cadastro.Pessoas.Contatos.Emails
{
    public class EmailAppService : ServiceBase<Email>, IEmailAppService
    {
        private readonly IEmailRepository _emailRepository;
        public EmailAppService(IEmailRepository emailRepository) : base(emailRepository)
        {
            _emailRepository = emailRepository;
        }

        public IEnumerable<Email> BuscarPeloEmail(string enderecoEmail)
        {
            return _emailRepository.BuscarPeloEmail(enderecoEmail);
        }
    }
}
