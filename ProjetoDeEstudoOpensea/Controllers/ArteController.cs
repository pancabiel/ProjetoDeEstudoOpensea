using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoDeEstudoOpensea.DAO;

namespace ProjetoDeEstudoOpensea.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ArteController : ControllerBase
    {
        private ArteDAO _arteDAO;

        public ArteController(ArteDAO arteDAO)
        {
            _arteDAO = arteDAO;
        }

        [HttpGet(Name = "GetArtes")]
        public IActionResult GetArtes()
        {
            try
            {
                return Ok(_arteDAO.buscar());
            }
            catch (Exception ex)
            {
                return Problem(title: "Ocorreu um erro ao buscar as artes", detail: ex.Message);
            }
        }
    }
}
