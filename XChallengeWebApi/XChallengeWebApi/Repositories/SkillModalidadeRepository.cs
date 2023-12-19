using Microsoft.EntityFrameworkCore;
using XChallengeWebApi.Domains;
using XChallengeWebApi.Interfaces;
using XChallengeWebApi.Contexts;
using XChallengeWebApi.Utils;

namespace XChallengeWebApi.Repositories
{
    public class SkillModalidadeRepository : ISkillModalidadeRepository
    {
        private readonly XChallengeContext _context;

        public SkillModalidadeRepository()
        {
            _context = new XChallengeContext();
        }

        public SkillModalidade GetById(int id)
        {
            try
            {
                SkillModalidade skillModalidadeBuscada = _context.SkillModalidades
                    .Select(u => new SkillModalidade
                    {
                        Id = u.Id,
                        Idskill = u.Idskill,
                        Idmodalidade = u.Idmodalidade
                    }).FirstOrDefault(u => u.Id == id)!;

                if (skillModalidadeBuscada != null)
                {
                    return skillModalidadeBuscada;

                }
                return null!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<SkillModalidade> Listar()
        {
            try
            {
                return _context.SkillModalidades.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
