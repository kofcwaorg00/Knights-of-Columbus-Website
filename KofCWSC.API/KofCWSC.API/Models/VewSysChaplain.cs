using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class VewSysChaplain
{
    public int? CouncilNo { get; set; }

    public string? Chaplain { get; set; }

    public string ChaplainUrl { get; set; } = null!;

    public string? ChaplainEmail { get; set; }

    public int ChaplainId { get; set; }

    public int ChaplainUpdatedForNewFratYear { get; set; }
}
