using System.Collections.Generic;
namespace projetoTeste.Models
{
    public class Disciplina
    {
        public Disciplina() { }
        public Disciplina(int id, int nome, int professorId)
        {
            this.Id = id;
            this.Nome = nome;
            this.ProfessorId = professorId;
        }
        public int Id { get; set; }
        public int Nome { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }

    }
}