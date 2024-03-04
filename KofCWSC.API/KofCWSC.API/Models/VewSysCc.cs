using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class VewSysCc
{
    public int? AssemblyNo { get; set; }

    public string? Cc { get; set; }

    public string Ccurl { get; set; } = null!;

    public string? Ccemail { get; set; }

    public int Ccid { get; set; }

    public int CcupdatedForNewFratYear { get; set; }
}
