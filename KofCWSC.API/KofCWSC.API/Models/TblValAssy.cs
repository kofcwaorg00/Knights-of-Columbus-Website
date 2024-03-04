using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblValAssy
{
    public int ANumber { get; set; }

    public string? ALocation { get; set; }

    public string? AName { get; set; }

    public string? AddInfo1 { get; set; }

    public string? AddInfo2 { get; set; }

    public string? AddInfo3 { get; set; }

    public string? WebSiteUrl { get; set; }

    public string? MasterLoc { get; set; }

    public virtual ICollection<TblMasMember> TblMasMembers { get; set; } = new List<TblMasMember>();
}
