using Domain.Entities.Cadastro.Pessoas.Clientes;
using System;
using System.Collections.Generic;

namespace Domain.Entities.Vendas
{
    public class Venda
    {
        public int VendaId { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        public DateTime Data { get; set; }
        public string Observacao { get; set; }

        public ICollection<DetalheVenda> DetalhesVendas { get; set; }
    }
}
