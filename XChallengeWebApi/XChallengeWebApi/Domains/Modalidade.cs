using System;
using System.Collections.Generic;

namespace XChallengeWebApi.Domains;

public partial class Modalidade
{
    public string IdModalidade { get; set; } = null!;

    public string? NomeModalidade { get; set; }

    public string? DescModalidade { get; set; }

    public virtual ICollection<Competidor> Competidors { get; } = new List<Competidor>();

    public virtual ICollection<DataNacional> DataNacionals { get; } = new List<DataNacional>();

    public virtual ICollection<SkillModalidade> SkillModalidades { get; } = new List<SkillModalidade>();
}
