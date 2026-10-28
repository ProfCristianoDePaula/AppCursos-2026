using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace AppCursos.Models
{
    public class Aluno
    {
        public int Id { get; set; } // Chave primária (Primary Key)

        public string Nome { get; set; }

        public string CPF { get; set; }

        [Display(Name = "E-mail")]

        public string Email { get; set; }
        public string Celular { get; set; }

        [Display(Name = "Data de Nascimento")]
        public DateOnly DataNascimento { get; set; }
    }
}
