using System;
using System.Collections.Generic;

namespace XChallengeWebApi.Domains;

public partial class DataNacional
{
    public int IdNacional { get; set; }

    public short? AnoMundial { get; set; }

    public string? IdModalidade { get; set; }

    public DateTime? IniCompeticao { get; set; }

    public DateTime? TerminoCompeticao { get; set; }

    public string? LocalCompeticao { get; set; }

    public virtual Modalidade? IdModalidadeNavigation { get; set; }
}
