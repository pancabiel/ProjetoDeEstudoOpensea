using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoDeEstudoOpensea.DAO;

namespace ProjetoDeEstudoOpensea.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ColecaoController : ControllerBase
    {
        private ColecaoDAO _ColecaoDAO;

        public ColecaoController(ColecaoDAO ColecaoDAO)
        {
            _ColecaoDAO = ColecaoDAO;
        }

        [HttpGet(Name = "GetColecoes")]
        public IActionResult GetColecoes()
        {
            try
            {
                return Ok(_ColecaoDAO.buscar());
            }
            catch (Exception ex)
            {
                return Problem(title: "Ocorreu um erro ao buscar as coleções", detail: ex.Message);
            }
        }
    }
}
