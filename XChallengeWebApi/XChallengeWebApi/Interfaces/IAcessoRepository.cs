using XChallengeWebApi.Domains;

namespace XChallengeWebApi.Interfaces
{
    public interface IAcessoRepository 
    {
        List<Acesso> Listar();

        Acesso GetById(int id);

        Acesso Login(string email, string senha);
    }
}
