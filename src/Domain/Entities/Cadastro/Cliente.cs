using Domain.Entities.Producao;
using System;
using System.Collections.Generic;

namespace Domain.Entities.Cadastro
{
   public class Cliente
    {
        public Cliente()
        {

        }
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public IEnumerable<Produto> Produtos { get; set; }

        //ativo e com 5 anos de cadastro
        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
        }
    }
}
