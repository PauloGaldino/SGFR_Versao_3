﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Cadastro.Pessoas.Tipos
{
    public class Juridica
    {
        public Juridica()
        {

        }
        public int JuridicaId { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }
        public DateTime DataFundacao { get; set; }

        //Chave estrangeira
        public int PessoaId { get; set; }
        //Propriedade de navegação
        public Pessoa Pessoa { get; set; }
    }
}
