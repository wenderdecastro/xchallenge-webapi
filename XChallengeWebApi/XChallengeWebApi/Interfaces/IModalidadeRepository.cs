using XChallengeWebApi.Domains;

namespace XChallengeWebApi.Interfaces
{
    public interface IModalidadeRepository
    {
        List<Modalidade> Listar();
        Modalidade GetById(string id);
    }
}
