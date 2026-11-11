using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace AppCursos.Models
{
    public class Aluno
    {
        public int Id { get; set; } // Chave primária (Primary Key)
        [Display(Name = "Nome do Aluno")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres.")]
        [MinLength(3, ErrorMessage = "O campo Nome deve ter no mínimo 3 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        [MaxLength(14, ErrorMessage = "O campo CPF deve ter 11 Números.")]
        [MinLength(14, ErrorMessage = "O campo CPF deve ter 11 Números.")]
        public string CPF { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O campo E-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "O campo E-mail deve ser um endereço de e-mail válido.")]
        [MaxLength(200, ErrorMessage = "O campo E-mail deve ter no máximo 200 caracteres.")]
        public string Email { get; set; }
        [Display(Name = "Celular")]
        [Required(ErrorMessage = "O campo Celular é obrigatório.")]
        [Phone(ErrorMessage = "O campo Celular deve ser um número de telefone válido.")]
        [MaxLength(15, ErrorMessage = "O Celular deve ter 11 digitos numericos (ddd + número).")]
        [MinLength(15, ErrorMessage = "O Celular deve ter 11 digitos numericos (ddd + número).")]
        [DataType(DataType.PhoneNumber)]
        public string Celular { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório.")]
        [DataType(DataType.Date, ErrorMessage = "O campo Data de Nascimento deve ser uma data válida.")]
        public DateOnly DataNascimento { get; set; }
    }
}
