using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblValDistrict
{
    public int District { get; set; }

    public float? DdId { get; set; }

    public string? Description { get; set; }

    public string? AddInfo1 { get; set; }

    public string? AddInfo2 { get; set; }

    public virtual ICollection<TblValCouncil> TblValCouncils { get; set; } = new List<TblValCouncil>();
}
