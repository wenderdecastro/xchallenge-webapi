using System;
using System.Collections.Generic;

namespace XChallengeWebApi.Domains;

public partial class NotaCompetidor
{
    public int Id { get; set; }

    public int? IdCompetidor { get; set; }

    public int? IdNota { get; set; }

    public double? Nota { get; set; }

    public virtual Competidor? IdCompetidorNavigation { get; set; }

    public virtual Notum? IdNotaNavigation { get; set; }
}
