using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XChallengeWebApi.Domains;
using XChallengeWebApi.Interfaces;
using XChallengeWebApi.Repositories;

namespace XChallengeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class CompetidorController : ControllerBase
    {
        CompetidorRepository competidor = new CompetidorRepository();

        private readonly ICompetidorRepository _competidorRepository;

        public CompetidorController()
        {
            _competidorRepository = new CompetidorRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_competidorRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(competidor.GetById(id));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
