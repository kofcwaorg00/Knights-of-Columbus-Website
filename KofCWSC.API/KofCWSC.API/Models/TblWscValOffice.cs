using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblWscValOffice
{
    public int OfficeId { get; set; }

    public string? OfficeDescription { get; set; }

    public int? DirSortOrder { get; set; }

    public string? AltDescription { get; set; }

    public string? EmailAlias { get; set; }

    public int? GroupId { get; set; }

    public bool? UseAsFormalTitle { get; set; }

    public virtual TblWscValGroup? Group { get; set; }
}
