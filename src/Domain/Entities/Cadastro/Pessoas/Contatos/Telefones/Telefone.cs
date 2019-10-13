namespace Domain.Entities.Cadastro.Pessoas.Contatos.Telefones
{
    public class Telefone
    {
        public Telefone()
        {

        }
        public int TelefoneId { get; set; }
        public string Numero { get; set; }

        public int TelefoneTipoId { get; set; }
        public TelefoneTipo TelefoneTipo { get; set; }

    }
}
