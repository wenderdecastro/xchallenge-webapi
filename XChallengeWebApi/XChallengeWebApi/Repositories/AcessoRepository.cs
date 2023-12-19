using Microsoft.EntityFrameworkCore;
using XChallengeWebApi.Domains;
using XChallengeWebApi.Interfaces;
using XChallengeWebApi.Contexts;
using XChallengeWebApi.Utils;

namespace XChallengeWebApi.Repositories
{
    public class AcessoRepository : IAcessoRepository
    {
        private readonly XChallengeContext _context;

        public AcessoRepository() 
        {
            _context = new XChallengeContext();
        }

        public Acesso GetById(int id)
        {
            try
            {
                Acesso acessoBuscado = _context.Acessos
                    .Select(u => new Acesso
                    {
                        IdAcesso = u.IdAcesso,
                        Nome = u.Nome,
                        Email = u.Email,
                        SenhaAcesso = u.SenhaAcesso
                    }).FirstOrDefault(u => u.IdAcesso == id)!;

                if (acessoBuscado != null)
                {
                    return acessoBuscado;

                }
                return null!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Acesso Login(string email, string senha)
        {
            throw new NotImplementedException();
        }

        List<Acesso> IAcessoRepository.Listar()
        {
            try
            {
                return _context.Acessos.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
