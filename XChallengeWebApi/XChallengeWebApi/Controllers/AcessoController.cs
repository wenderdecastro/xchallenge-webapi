using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XChallengeWebApi.Domains;
using XChallengeWebApi.Interfaces;
using XChallengeWebApi.Repositories;
using XChallengeWebApi.ViewModels;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.JsonWebTokens;

namespace XChallengeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]

    public class AcessoController : ControllerBase
    {
        AcessoRepository acesso = new AcessoRepository();

        private readonly IAcessoRepository _acessoRepository;

        public AcessoController()
        {
            _acessoRepository = new AcessoRepository();
        }


        //[HttpPost]
        //public IActionResult Login(LoginViewModel usuario)
        //{
        //    try
        //    {
        //        Acesso tentativaAcesso = _acessoRepository.Login(usuario.Email, usuario.Senha);
        //        if (tentativaAcesso == null)
        //        {
        //            return Ok(null);
        //        }
        //        var claims = new[]
        //        {
        //            //new Claim(JwtRegisteredClaimNames.Jti, tentativaAcesso.IdAcesso.ToString()),
        //            //new Claim(jwtRegisteredClaimNames)
        //        }

        //        return Ok();

        //    }
        //    catch (Exception error) {
        //        return BadRequest(error); ;
        //    }
        //}

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_acessoRepository.Listar());
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
               return Ok(acesso.GetById(id));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
