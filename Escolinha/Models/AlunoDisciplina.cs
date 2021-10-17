namespace projetoTeste.Models
{
    public class AlunoDisciplina
    {

        public AlunoDisciplina() { }
        public AlunoDisciplina(Aluno alunoId, Disciplina disciplinaId)
        {
            this.AlunoId = alunoId;
            this.DisciplinaId = disciplinaId;            
        }
        public Aluno AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public Disciplina DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}