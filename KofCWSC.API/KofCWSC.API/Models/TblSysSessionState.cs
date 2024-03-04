using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblSysSessionState
{
    public int Sid { get; set; }

    public string SessionId { get; set; } = null!;

    public string? UserId { get; set; }

    public bool LoggedIn { get; set; }

    public string? Roles { get; set; }

    public DateTime LoggedInDateTime { get; set; }

    public string? Council { get; set; }
}
