using XChallengeWebApi.Domains;

namespace XChallengeWebApi.Interfaces
{
    public interface ISkillModalidadeRepository
    {
        List<SkillModalidade> Listar();
        SkillModalidade GetById(int id);
    }
}
