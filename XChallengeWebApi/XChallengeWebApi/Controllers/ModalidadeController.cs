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
    public class ModalidadeController : ControllerBase
    {
        ModalidadeRepository modalidade = new ModalidadeRepository();

        private readonly IModalidadeRepository _modalidadeRepository;

        public ModalidadeController()
        {
           _modalidadeRepository = new ModalidadeRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_modalidadeRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("GetById")]
        public IActionResult GetById(string id)
        {
            try
            {
                return Ok(modalidade.GetById(id));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
