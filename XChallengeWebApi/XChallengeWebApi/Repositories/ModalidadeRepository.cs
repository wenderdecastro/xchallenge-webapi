using Microsoft.EntityFrameworkCore;
using XChallengeWebApi.Domains;
using XChallengeWebApi.Interfaces;
using XChallengeWebApi.Contexts;
using XChallengeWebApi.Utils;

namespace XChallengeWebApi.Repositories
{
    public class ModalidadeRepository : IModalidadeRepository
    {
        private readonly XChallengeContext _context;

        public ModalidadeRepository()
        {
            _context = new XChallengeContext();
        }

        public Modalidade GetById(string id)
        {
            try
            {
                Modalidade modalidadeBuscada = _context.Modalidades
                    .Select(u => new Modalidade
                    {
                        IdModalidade = u.IdModalidade,
                        NomeModalidade = u.NomeModalidade,
                        DescModalidade = u.DescModalidade
                    }).FirstOrDefault(u => u.IdModalidade == id)!;

                if (modalidadeBuscada != null)
                {
                    return modalidadeBuscada;

                }
                return null!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Modalidade> Listar()
        {
            try
            {
                return _context.Modalidades.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
