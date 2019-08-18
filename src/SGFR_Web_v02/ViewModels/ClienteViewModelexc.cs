using Domain.Entities.Producao;
using Domain.Entities.Vendas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SGFR_Web_v02.ViewModels
{
    public class ClienteViewModelexc
    {
        [Key]
        [DisplayName("Indetificação")]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo e-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um e-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Display(Name = "Data")]
        [Required(ErrorMessage = "The field {0} is required")]
        //[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [ScaffoldColumn(false)] //nao quero esse campo criado no scafolding
        [DisplayName("Data do cadastro")]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public IEnumerable<Produto> Produtos { get; set; }

        //Um para muitos
        public List<Venda> Vendas { get; set; }
        public List<Pedido> Pedidos { get; set; }

    }
}