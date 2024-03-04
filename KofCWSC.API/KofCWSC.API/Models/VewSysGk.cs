using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class VewSysGk
{
    public int? CouncilNo { get; set; }

    public string? GrandKnight { get; set; }

    public string Gkurl { get; set; } = null!;

    public string? Gkemail { get; set; }

    public int GrandKnightId { get; set; }

    public int GkupdatedForNewFratYear { get; set; }

    public DateTime? LastUpdated { get; set; }
}
