namespace Domain.Entities.Cadastro.Pessoas.Contatos.Emails
{
    public class Email
    {
        public Email()
        {

        }
        public int EmailId { get; set; }

        public string EnderecoEmail { get; set; }

        public int PessoaId { get; set; }

        public Pessoa Pessoa { get; set; }
    }
}
