using System.Collections.Generic;

namespace Domain.Entities.Cadastro.Pessoas
{
    public class PessoaTipo
    {
        public PessoaTipo()
        {

        }
        public int PessoaTipoId { get; set; }
        public string Descricao { get; set; }

        public ICollection<Pessoa> Pessoas { get; set; }




    }
}
