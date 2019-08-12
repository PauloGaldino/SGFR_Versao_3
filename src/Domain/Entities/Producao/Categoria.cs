using System.Collections.Generic;

namespace Domain.Entities.Producao
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Descricao { get; set; }

        //Relacao um para muitos
        public ICollection<Produto> Produtos { get; set; }
    }
}
