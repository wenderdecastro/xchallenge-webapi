using XChallengeWebApi.Domains;

namespace XChallengeWebApi.Interfaces
{
    public interface ICompetidorRepository
    {
        List<Competidor> Listar();
        Competidor GetById(int id);
    }
}
