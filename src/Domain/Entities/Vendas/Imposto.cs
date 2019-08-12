using Domain.Entities.Producao;
using System.Collections.Generic;

namespace Domain.Entities.Vendas
{
   public class Imposto
    {
        public int ImpostoId { get; set; }
        public string Descricao { get; set; }
        public float Taxa { get; set; }

        public IEnumerable<Produto> Produto { get; set; }
    }
}
