using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblSysControl
{
    public int Cid { get; set; }

    public string CurrentVersion { get; set; } = null!;

    public bool StopApp { get; set; }

    public string BusyMessage { get; set; } = null!;
}
