using System;
using System.Collections.Generic;

namespace XChallengeWebApi.Domains;

public partial class Notum
{
    public int IdNota { get; set; }

    public int? SeqNota { get; set; }

    public virtual ICollection<NotaCompetidor> NotaCompetidors { get; } = new List<NotaCompetidor>();
}
