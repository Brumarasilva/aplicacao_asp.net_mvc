using System;
using System.ComponentModel.DataAnnotations;

namespace aplicacao_asp.net_mvc.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(2, ErrorMessage = "O nome deve ter pelo menos 2 caracteres")]
        [MaxLength(100, ErrorMessage = "O nome pode ter no máximo 100 caracteres")]
        public string Nome { get; set; } = null!;

        [Required(ErrorMessage = "A descrição é obrigatória")]
        [MinLength(2, ErrorMessage = "A descrição deve ter pelo menos 2 caracteres")]
        [MaxLength(500, ErrorMessage = "A descrição pode ter no máximo 500 caracteres")]
        public string Descricao { get; set; } = null!;

        [Required(ErrorMessage = "A data de criação é obrigatória")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Criação")]
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        [Display(Name = "Data de Conclusão")]
        public DateTime? DataConclusao { get; set; }

        // Relacionamento opcional com Tipo
        [Display(Name = "Tipo")]
        public int TipoId { get; set; }
        public Tipo? Tipo { get; set; }
    }
}
