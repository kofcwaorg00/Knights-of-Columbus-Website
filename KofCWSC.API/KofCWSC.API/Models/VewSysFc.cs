using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class VewSysFc
{
    public int? AssemblyNo { get; set; }

    public string? Location { get; set; }

    public string? Name { get; set; }

    public string? Fc { get; set; }

    public string Fcurl { get; set; } = null!;

    public string? Fcemail { get; set; }

    public int Fcid { get; set; }

    public int FcupdatedForNewFratYear { get; set; }
}
