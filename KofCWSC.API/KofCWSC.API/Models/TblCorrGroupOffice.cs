using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblCorrGroupOffice
{
    public int GroupId { get; set; }

    public int OfficeId { get; set; }

    public string? BegFratYear { get; set; }

    public virtual TblValGroup Group { get; set; } = null!;

    public virtual TblValOffice Office { get; set; } = null!;
}
