using System.ComponentModel.DataAnnotations;

namespace aplicacao_asp.net_mvc.Models
{
    
    public class Tipo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(2, ErrorMessage = "O nome deve ter pelo menos 2 caracteres")]
        [MaxLength(100, ErrorMessage = "O nome pode ter no máximo 100 caracteres")]
        public string Nome { get; set; } = null!;

        [Required(ErrorMessage = "A descrição é obrigatória")]
        [MinLength(2, ErrorMessage = "A descrição deve ter pelo menos 2 caracteres")]
        [MaxLength(200, ErrorMessage = "A descrição pode ter no máximo 200 caracteres")]
        public string Descricao { get; set; } = null!;
    }
}
