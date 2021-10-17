using Microsoft.AspNetCore.Mvc;

namespace projetoTeste.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]        
    public class ProfessorController : ControllerBase
    {
         public ProfessorController(){}

         [HttpGet]
         public IActionResult Get(){
            return Ok("Funciona");
         }

    }
}