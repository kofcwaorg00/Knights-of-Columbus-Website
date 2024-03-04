using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblTmpEmailBounce
{
    public string? Address { get; set; }

    public string? Remove { get; set; }

    public double? Code { get; set; }

    public string? Error { get; set; }
}
