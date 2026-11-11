using System.ComponentModel.DataAnnotations;

namespace AppCursos.Models
{
    public class Turma
    {
        public int Id { get; set; } // Chave primária (Primary Key)

        public string Nome { get; set; }

        [Display(Name = "Curso")]
        public int CursoId { get; set; } // Chave estrangeira (Foreign Key)
        public Curso? Curso { get; set; } // Propriedade de navegação

        // Incluir o relacionamento com Professor

        [Display(Name = "Professor")]
        public int ProfessorId { get; set; } // Chave estrangeira (Foreign Key)
        public Professor? Professor { get; set; } // Propriedade de navegação


    }
}
