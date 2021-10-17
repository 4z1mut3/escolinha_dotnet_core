using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using projetoTeste.Models;

namespace projetoTeste.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>{
            new Aluno(){
                Id = 1,
                Nome = "Marta",
                Sobrenome = "Kent",
                Telefone = "2349889729"
            },

            new Aluno(){
                Id = 2,
                Nome = "Pedro",
                Sobrenome = "Kteste",
                Telefone = "2349889729"
            },
            new Aluno(){
                Id = 3,
                Nome = "Maria",
                Sobrenome = "Kkkk",
                Telefone = "2349889729"
            },
        };
        public AlunoController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        [HttpGet("ById/{id:int}")]
        public IActionResult GetById(int id){
            var aluno = Alunos.FirstOrDefault(a =>a.Id == id);
            if (aluno == null) return BadRequest("Aluno não encontrado");

            return Ok(aluno);
        }

        [HttpGet("{ByName}")]
        public IActionResult GetByName(string nome, string sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(
                a => a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome)
            );
            if (aluno == null) return BadRequest("Aluno não encontrado");

            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

    }
}