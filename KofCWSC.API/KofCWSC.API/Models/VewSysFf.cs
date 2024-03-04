using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class VewSysFf
{
    public int? AssemblyNo { get; set; }

    public string? Ff { get; set; }

    public string Ffurl { get; set; } = null!;

    public string? Ffemail { get; set; }

    public int Ffid { get; set; }

    public int FfupdatedForNewFratYear { get; set; }
}
