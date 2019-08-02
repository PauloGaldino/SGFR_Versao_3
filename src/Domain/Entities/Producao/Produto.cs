using Domain.Entities.Cadastro;
using System;

namespace Domain.Entities.Producao
{
    public class Produto
    {
        public Produto()
        {

        }
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoUnitario { get; set; }
        public string Lote { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public bool Disponivel { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; } //virtual para lazy loading do entity sobrescrever
    }
}
