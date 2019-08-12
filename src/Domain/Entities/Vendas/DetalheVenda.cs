using Domain.Entities.Producao;

namespace Domain.Entities.Vendas
{
    public  class DetalheVenda
    {
        public int DetalheVendaId { get; set; }
        //========chaves estrangeiras======================  
        public int VendaId { get; set; }
        public Venda Venda { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        //=======Atributos=================================
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public decimal AliquotaFiscal { get; set; }
        public int Quantidade { get; set; }
    }
}
