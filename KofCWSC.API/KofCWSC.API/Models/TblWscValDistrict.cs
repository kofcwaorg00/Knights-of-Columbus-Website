using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblWscValDistrict
{
    public int DistrictId { get; set; }

    public float? DdId { get; set; }

    public string? Description { get; set; }

    public string? AddInfo1 { get; set; }

    public string? AddInfo2 { get; set; }

    public virtual ICollection<TblWscValCouncil> TblWscValCouncils { get; set; } = new List<TblWscValCouncil>();
}
