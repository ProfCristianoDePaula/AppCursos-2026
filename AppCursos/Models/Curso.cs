using System.ComponentModel.DataAnnotations;

namespace AppCursos.Models
{
    public class Curso
    {
        public int Id { get; set; } // Chave primária (Primary Key)

        [Display(Name = "Nome do Curso")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres.")]
        [MinLength(3, ErrorMessage = "O campo Nome deve ter no mínimo 3 caracteres.")]
        public string Nome { get; set; }

        [Display(Name = "Carga Horária")]
        [Required(ErrorMessage = "O campo Carga Horária é obrigatório.")]
        [Range(1, 3000, ErrorMessage = "A carga horária deve ser um número positivo.")]
        public int Duracao { get; set; }
    }
}
