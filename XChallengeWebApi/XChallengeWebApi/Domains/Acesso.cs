using System;
using System.Collections.Generic;

namespace XChallengeWebApi.Domains;

public partial class Acesso
{
    public int IdAcesso { get; set; }

    public string? Email { get; set; }

    public string? SenhaAcesso { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<LogAcesso> LogAcessos { get; } = new List<LogAcesso>();
}
