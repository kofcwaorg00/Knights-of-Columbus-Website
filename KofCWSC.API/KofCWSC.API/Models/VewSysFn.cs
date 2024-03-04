using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class VewSysFn
{
    public int? AssemblyNo { get; set; }

    public string? Fn { get; set; }

    public string Fnurl { get; set; } = null!;

    public string? Fnemail { get; set; }

    public int Fnid { get; set; }

    public int FnupdatedForNewFratYear { get; set; }
}
