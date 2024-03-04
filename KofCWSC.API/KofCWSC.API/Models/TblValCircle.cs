using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblValCircle
{
    public int CNumber { get; set; }

    public string? CLocation { get; set; }

    public string? CName { get; set; }

    public float? SponsorCouncil { get; set; }

    public string? AddInfo1 { get; set; }

    public string? AddInfo2 { get; set; }

    public string? AddInfo3 { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<TblMasMember> TblMasMembers { get; set; } = new List<TblMasMember>();
}
