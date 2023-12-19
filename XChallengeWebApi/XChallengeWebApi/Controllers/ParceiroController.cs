using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XChallengeWebApi.Domains;
using XChallengeWebApi.Interfaces;
using XChallengeWebApi.Repositories;
using XChallengeWebApi.ViewModels;

namespace XChallengeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ParceiroController : ControllerBase
    {
        ParceiroRepository parceiro = new ParceiroRepository();

        private readonly IParceiroRepository _parceiroRepository;

        public ParceiroController()
        {
            _parceiroRepository = new ParceiroRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_parceiroRepository.Listar());
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
                return Ok(parceiro.GetById(id));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
