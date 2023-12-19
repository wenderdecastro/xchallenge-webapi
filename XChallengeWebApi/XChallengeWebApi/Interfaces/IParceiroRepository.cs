using XChallengeWebApi.Domains;

namespace XChallengeWebApi.Interfaces
{
    public interface IParceiroRepository
    {
        List<Parceiro> Listar();
        Parceiro GetById(int id);
    }
}
