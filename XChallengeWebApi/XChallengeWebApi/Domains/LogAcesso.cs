using System;
using System.Collections.Generic;

namespace XChallengeWebApi.Domains;

public partial class LogAcesso
{
    public int Idlog { get; set; }

    public int? Idusuario { get; set; }

    public DateTime? DataHoraAcesso { get; set; }

    public DateTime? DataHoraSaida { get; set; }

    public virtual Acesso? IdusuarioNavigation { get; set; }
}
