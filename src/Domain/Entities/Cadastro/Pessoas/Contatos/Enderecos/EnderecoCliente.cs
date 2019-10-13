using Domain.Entities.Cadastro.Pessoas.Clientes;

namespace Domain.Entities.Cadastro.Pessoas.Contatos.Enderecos
{
    public class EnderecoCliente
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }
        public int EnderecoId { get; set; }

        public Cliente Cliente { get; set; }
        public Endereco Endereco { get; set; }
    }
}