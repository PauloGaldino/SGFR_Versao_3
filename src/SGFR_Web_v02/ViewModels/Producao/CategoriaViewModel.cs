using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SGFR_Web_v02.ViewModels
{
    public class CategoriaViewModel 
    {
        [Key]
        [DisplayName("Indetificação")]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Preencha o campo da descrição")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
    }
}
