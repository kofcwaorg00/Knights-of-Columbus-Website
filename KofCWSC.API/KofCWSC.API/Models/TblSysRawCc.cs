using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblSysRawCc
{
    public double? District { get; set; }

    public double? Council { get; set; }

    public double? Member { get; set; }

    public double? Assembly { get; set; }

    public string? Officer { get; set; }

    public string? Lname { get; set; }

    public string? Fname { get; set; }

    public string? Email { get; set; }

    public string? MemberType { get; set; }
}
