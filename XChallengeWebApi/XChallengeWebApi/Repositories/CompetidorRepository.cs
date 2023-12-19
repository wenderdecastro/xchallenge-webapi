using Microsoft.EntityFrameworkCore;
using XChallengeWebApi.Domains;
using XChallengeWebApi.Interfaces;
using XChallengeWebApi.Contexts;
using XChallengeWebApi.Utils;

namespace XChallengeWebApi.Repositories
{
    public class CompetidorRepository : ICompetidorRepository
    {
        private readonly XChallengeContext _context;

        public CompetidorRepository()
        {
            _context = new XChallengeContext();
        }

        public Competidor GetById(int id)
        {
            try
            {
                Competidor competidorBuscado = _context.Competidors
                    .Select(u => new Competidor
                    {
                        IdCompetidor = u.IdCompetidor,
                        IdModalidade = u.IdModalidade,
                        Nome = u.Nome,
                        Estado = u.Estado,
                        DataNascimento = u.DataNascimento,
                        EstadoNavigation = u.EstadoNavigation,
                        IdModalidadeNavigation = u.IdModalidadeNavigation
                    }).FirstOrDefault(u => u.IdCompetidor == id)!;

                if (competidorBuscado != null)
                {
                    return competidorBuscado;

                }
                return null!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Competidor> Listar()
        {
            try
            {
                return _context.Competidors.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
