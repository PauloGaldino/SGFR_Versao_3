using Domain.Entities.Producao;

namespace Domain.Entities.Vendas
{
    public class DetalhePedido
    {
        public int DetalhePedidoId { get; set; }

        //========chaves estrangeiras=================  
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        //========Atributos=========================
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public decimal AliquotaFiscal { get; set; }
        public int Quantidade { get; set; }
    }
}
