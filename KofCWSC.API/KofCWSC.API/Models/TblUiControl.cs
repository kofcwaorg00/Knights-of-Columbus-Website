using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblUiControl
{
    public int Gkfn { get; set; }

    public DateTime LastDirUpdatePrint { get; set; }

    public bool StopApp { get; set; }

    public string StopAppMessage { get; set; } = null!;
}
