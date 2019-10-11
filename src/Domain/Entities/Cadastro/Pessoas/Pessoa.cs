using Domain.Entities.Cadastro.Pessoas.Contatos.Enderecos;
using Domain.Entities.Cadastro.Pessoas.Contatos;
using System.Collections.Generic;
using System;
using Domain.Entities.Cadastro.Pessoas.Contatos.Emails;
using Domain.Entities.Cadastro.Pessoas.Clientes;

namespace Domain.Entities.Cadastro.Pessoas
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public int PessoaId { get; set; }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }


        ////Chave estrangeira
        public int PessoaTipoId { get; set; }
        public PessoaTipo PessoaTipo { get; set; }

        public ICollection<Contato> Contatos { get; set; }

        public ICollection<Cliente> Clientes { get; set; }

        public ICollection<EnderecoPessoa> EnderecosPessoas { get; set; }

        public ICollection<Email> Emails { get; set; }

        //public ICollection<ProfissaoPessoa> ProfissaoPessoa { get; set; }
    }
}
