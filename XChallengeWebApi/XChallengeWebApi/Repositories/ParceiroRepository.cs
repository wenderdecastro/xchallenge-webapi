using Microsoft.EntityFrameworkCore;
using XChallengeWebApi.Domains;
using XChallengeWebApi.Interfaces;
using XChallengeWebApi.Contexts;
using XChallengeWebApi.Utils;

namespace XChallengeWebApi.Repositories
{
    public class ParceiroRepository : IParceiroRepository
    {
        private readonly XChallengeContext _context;

        public ParceiroRepository()
        {
            _context = new XChallengeContext();
        }

        public Parceiro GetById(int id)
        {
            try
            {
                Parceiro parceiroBuscado = _context.Parceiros
                    .Select(z => new Parceiro
                    {
                        IdParceiro = z.IdParceiro,
                        Nome = z.Nome,
                        Descricao = z.Descricao,
                        Logo = z.Logo
                    }).FirstOrDefault(z => z.IdParceiro == id)!;

                return parceiroBuscado;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Parceiro> Listar()
        {
            try
            {
                return _context.Parceiros.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
