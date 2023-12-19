using XChallengeWebApi.Contexts;
using XChallengeWebApi.Domains;
using XChallengeWebApi.Interfaces;

namespace XChallengeWebApi.Repositories
{
    public class NoticiumRepository
    {
        XChallengeContext context;

        private readonly INoticiumRepository noticiumRepository;

        public NoticiumRepository()
        {
            context = new XChallengeContext();
        }

        public List<Noticium> Listar()
        {
            List<Noticium> noticias = context.Noticia
            .Select(n => new Noticium
            {
                Id = n.Id,
                Data = n.Data,
                Noticia = n.Noticia,
                Status = n.Status,
                Titulo = n.Titulo
            }
            ).OrderByDescending(x => x.Data).ToList();

            return noticias;

        }
    }
}
