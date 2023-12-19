using System;
using System.Collections.Generic;

namespace XChallengeWebApi.Domains;

public partial class Skill
{
    public int IdSkill { get; set; }

    public string? Descricao { get; set; }

    public virtual ICollection<SkillModalidade> SkillModalidades { get; } = new List<SkillModalidade>();
}
