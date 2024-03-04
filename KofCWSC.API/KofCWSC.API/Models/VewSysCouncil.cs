using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class VewSysCouncil
{
    public int CouncilNo { get; set; }

    public int? District { get; set; }

    public string? City { get; set; }

    public string? CouncilName { get; set; }

    public string? CouncilUrl { get; set; }

    public string CouncilUrlg { get; set; } = null!;

    public string? Chartered { get; set; }

    public string WebSiteUrl { get; set; } = null!;

    public string? BulletinUrl { get; set; }

    public string? DioceseId { get; set; }

    public string Info { get; set; } = null!;

    public string Status { get; set; } = null!;
}
