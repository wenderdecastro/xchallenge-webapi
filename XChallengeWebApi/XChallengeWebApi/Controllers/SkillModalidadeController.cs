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
    public class SkillModalidadeController : ControllerBase
    {
        SkillModalidadeRepository skillModalidade = new SkillModalidadeRepository();

        private readonly ISkillModalidadeRepository _skillModalidadeRepository;

        public SkillModalidadeController()
        {
            _skillModalidadeRepository = new SkillModalidadeRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_skillModalidadeRepository.Listar());
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
                return Ok(_skillModalidadeRepository.GetById(id));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
