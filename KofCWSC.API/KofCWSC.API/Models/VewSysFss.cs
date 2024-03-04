using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class VewSysFss
{
    public int? CouncilNo { get; set; }

    public string? FinSec { get; set; }

    public string Fsurl { get; set; } = null!;

    public string? Fsemail { get; set; }

    public int FinSecId { get; set; }

    public int FsupdatedForNewFratYear { get; set; }
}
