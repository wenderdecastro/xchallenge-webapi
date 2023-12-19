using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XChallengeWebApi.Interfaces;
using XChallengeWebApi.Repositories;

namespace XChallengeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class NoticiumController : ControllerBase
    {
        NoticiumRepository noticium = new NoticiumRepository();

        private readonly NoticiumRepository _noticiumRepository;

        public NoticiumController()
        {
            _noticiumRepository = new NoticiumRepository();
        }

        [HttpGet]
        public IActionResult GetNoticias()
        {
            try
            {
                return Ok(_noticiumRepository.Listar());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}