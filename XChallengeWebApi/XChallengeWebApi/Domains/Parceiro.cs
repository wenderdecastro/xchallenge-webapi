using System;
using System.Collections.Generic;

namespace XChallengeWebApi.Domains;

public partial class Parceiro
{
    public int IdParceiro { get; set; }

    public byte[]? Logo { get; set; }

    public string? Nome { get; set; }

    public string? Descricao { get; set; }
}
