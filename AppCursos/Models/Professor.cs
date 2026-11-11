using System.ComponentModel.DataAnnotations;

namespace AppCursos.Models
{
    public class Professor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório!")]
        [MinLength(3, ErrorMessage = "O Nome deve conter no mínimo 3 caracters")]
        [MaxLength(100, ErrorMessage = "O Nome deve ter no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O campo e-mail é obrigatório!")]
        [EmailAddress(ErrorMessage = "O formato do e-mail não é válido")]
        public string Email { get; set; }

        [Display(Name = "Salário Hora")]
        [Required(ErrorMessage = "O campo salário é obrigatório!")]
        [DataType(DataType.Currency)]
        public double Salario { get; set; }
    }
}
