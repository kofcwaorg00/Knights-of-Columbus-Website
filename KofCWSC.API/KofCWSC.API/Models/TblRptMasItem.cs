using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblRptMasItem
{
    public string Rpttype { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string? ItemType { get; set; }

    public string? ItemDescr { get; set; }
}
