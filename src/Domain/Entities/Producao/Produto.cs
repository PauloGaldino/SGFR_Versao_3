using Domain.Entities.Cadastro;
using Domain.Entities.Vendas;
using System;
using System.Collections.Generic;

namespace Domain.Entities.Producao
{
    public class Produto
    {
        public Produto()
        {

        }

        public int ProdutoId { get; set; }

        public int CategoriaId { get; set; }
        public  Categoria Categoria { get; set; }
        public int ImpostoId { get; set; }
        public virtual Imposto Imposto { get; set; } 
        public int ClienteId { get; set; }
        public  Cliente Cliente { get; set; } //virtual para lazy loading do entity sobrescrever

        public string Descricao { get; set; }
        public decimal PrecoUnitario { get; set; }
        public string Lote { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public bool Disponivel { get; set; }

       
        //Relacionamento um para muitos
        public List<DetalheVenda> DetalhesVendas { get; set; }
        public List<DetalhePedido> DetalhesPedidos { get; set; }
    }
}
