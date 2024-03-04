using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblSysLoginLog
{
    public string? UserId { get; set; }

    public DateTime? LogDateTime { get; set; }

    public bool? Success { get; set; }

    public string? Action { get; set; }
}
