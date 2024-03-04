using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblWscValAssembly
{
    public int AssemblyId { get; set; }

    public string? AssyLocation { get; set; }

    public string? AssyName { get; set; }

    public string? AddInfo1 { get; set; }

    public string? AddInfo2 { get; set; }

    public string? AddInfo3 { get; set; }

    public string? WebSiteUrl { get; set; }

    public string? MasterLoc { get; set; }

    public virtual ICollection<TblWscMasMember> TblWscMasMembers { get; set; } = new List<TblWscMasMember>();
}
