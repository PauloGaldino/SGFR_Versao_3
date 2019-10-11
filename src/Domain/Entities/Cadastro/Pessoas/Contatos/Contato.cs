using Domain.Entities.Cadastro.Pessoas.Contatos.Emails;

namespace Domain.Entities.Cadastro.Pessoas.Contatos
{
    public class Contato
    {
        public Contato()
        {

        }
        public int ContatoId { get; set; }


        //Chave Estrangeira /Chave de navegação
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }

        public int EmailId { get; set; }
        public Email Email { get; set; }

        public int TelefoneId { get; set; }
        // public Telefone Telefone { get; set; }
    }

}
