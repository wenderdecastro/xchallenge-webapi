using System;
using System.Collections.Generic;

namespace XChallengeWebApi.Domains;

public partial class Modalidade
{
    public string? IdModalidade { get; set; }

    public string? NomeModalidade { get; set; }

    public string? DescModalidade { get; set; }

    public virtual ICollection<Competidor> Competidores { get; } = new List<Competidor>();

    public virtual ICollection<DataNacional> DataNacionais { get; } = new List<DataNacional>();

    public virtual ICollection<SkillModalidade> SkillModalidades { get; } = new List<SkillModalidade>();
}
