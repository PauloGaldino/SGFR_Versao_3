using System;

namespace Domain.Entities.Cadastro.Pessoas.Tipos
{

    public class Fisica
    {
        public Fisica()
        {

        }
        public int FisicaId { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
    
        //Chave estrangeria
        public int PessoaId { get; set; }

        //Propriedade de navegação
        public Pessoa Pessoa { get; set; }
    }
}
