using System;
using System.Collections.Generic;

namespace XChallengeWebApi.Domains;

public partial class Competidor
{
    public int IdCompetidor { get; set; }

    public string? IdModalidade { get; set; }

    public string? Nome { get; set; }

    public string? Estado { get; set; }

    public DateTime? DataNascimento { get; set; }

    public virtual Estado? EstadoNavigation { get; set; }

    public virtual Modalidade? IdModalidadeNavigation { get; set; }

    public virtual ICollection<NotaCompetidor> NotaCompetidors { get; } = new List<NotaCompetidor>();
}
