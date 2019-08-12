
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SGFR_Web.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]

        public int ProdutoId { get; set; }

        public int CategoriaId { get; set; }
        public int Categoria { get; set; }

        public int ImpostoId { get; set; }
        public int Imposto { get; set; }

        public int ClienteId { get; set; }
        public ClienteViewModel Cliente { get; set; } //virtual para lazy loading do entity sobrescrever   

        [Required(ErrorMessage = "Preencha o campo da descrição")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        [DisplayName("Preço Unitário")]
        public decimal PrecoUnitario { get; set; }

        [Required(ErrorMessage = "Preencha o campo do lote")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Lote { get; set; }

        [Required(ErrorMessage = "O campo da {0} é obrigatório")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Data de fabricação")]
        public DateTime DataFabricacao { get; set; }

        [Required(ErrorMessage = "O campo da {0} é obrigatório")]
        //[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Data de Validade")]
        public DateTime DataValidade { get; set; }

        [ScaffoldColumn(false)] //nao quero esse campo criado no scafolding
        public DateTime DataCadastro { get; set; }

        [DisplayName("Disponível?")]
        public bool Disponivel { get; set; }

        public bool Ativo { get; set; }

            
    }
}