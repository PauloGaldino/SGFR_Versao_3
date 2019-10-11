namespace Domain.Entities.Cadastro.Pessoas.Contatos.Enderecos
{
    public class EnderecoPessoa
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }

        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
    }
}
