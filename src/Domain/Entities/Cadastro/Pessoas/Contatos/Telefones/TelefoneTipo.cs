namespace Domain.Entities.Cadastro.Pessoas.Contatos.Telefones
{
    public class TelefoneTipo
    {
        public TelefoneTipo()
        {

        }
        public int TelefoneTipoId { get; set; }
        public string Descricao { get; set; }

        public Telefone Telefone { get; set; }

    }
}
