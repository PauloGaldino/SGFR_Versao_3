using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SGFR_Web.ViewModels.Vendas
{
    public class ImpostoVIewModel
    {
        [Key]
        [DisplayName("Indetificação")]
        public int ImpostoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo da descrição")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        public float Taxa { get; set; }
    }
}
