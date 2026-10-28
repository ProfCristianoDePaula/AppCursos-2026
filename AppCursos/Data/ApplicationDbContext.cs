using AppCursos.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppCursos.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {

        // Incluir DbSet para cada entidade do modelo
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<AlunoTurma> AlunoTurmas { get; set; }
        public DbSet<Professor> Professores { get; set; }

    }
}
