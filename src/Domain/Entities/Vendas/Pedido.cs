using Domain.Entities.Cadastro.Pessoas.Clientes;
using System;
using System.Collections.Generic;

namespace Domain.Entities.Vendas
{
    public class Pedido
    {
        public int PedidoId { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public DateTime Data { get; set; }
        public string Observacao { get; set; }

        public ICollection<Venda> Vendas { get; set; }
        public ICollection<DetalhePedido> DetalhesPedidos { get; set; }
    }
}
