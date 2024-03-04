using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblCorrGroupOfficeHistory
{
    public int GroupId { get; set; }

    public int OfficeId { get; set; }

    public string? BegFratYear { get; set; }
}
