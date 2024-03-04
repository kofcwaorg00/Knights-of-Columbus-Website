using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblValState
{
    public string StateCode { get; set; } = null!;

    public string StateName { get; set; } = null!;

    public int Gkfn { get; set; }
}
