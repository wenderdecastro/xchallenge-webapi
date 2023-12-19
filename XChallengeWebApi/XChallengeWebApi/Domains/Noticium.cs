using System;
using System.Collections.Generic;

namespace XChallengeWebApi.Domains;

public partial class Noticium
{
    public int Id { get; set; }

    public DateTime? Data { get; set; }

    public string? Titulo { get; set; }

    public string? Noticia { get; set; }

    public string? Status { get; set; }
}
