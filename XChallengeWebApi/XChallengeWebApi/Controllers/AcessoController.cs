using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XChallengeWebApi.Domains;
using XChallengeWebApi.Interfaces;
using XChallengeWebApi.Repositories;
using XChallengeWebApi.ViewModels;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

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


        [HttpPost]
        public IActionResult Login(LoginViewModel usuario)
        {
            try
            {
                Acesso tentativaAcesso = _acessoRepository.Login(usuario.Email, usuario.Senha);
                if (tentativaAcesso == null)
                {
                    return Ok(null);
                }
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Jti, tentativaAcesso.IdAcesso.ToString()),
                    new Claim(JwtRegisteredClaimNames.Name, tentativaAcesso.Nome.ToString())
                };

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("xchallenge-chavedeautenticacao-worldskills"));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken
                (
                    issuer: "XChallengeWebApi",

                    audience: "XChallengeWebApi",

                    //dados definidos nas claims(informalções)
                    claims: claims,

                    //tempo de expiração do token
                    expires: DateTime.Now.AddMinutes(50),

                    //credenciais do token
                    signingCredentials: creds
                );

                //5º - retornar o token criado
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }


            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

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
