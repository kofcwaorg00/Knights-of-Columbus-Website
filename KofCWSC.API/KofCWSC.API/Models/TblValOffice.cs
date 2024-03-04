using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblValOffice
{
    public int OfficeId { get; set; }

    public string? OfficeDescription { get; set; }

    public int? DirSortOrder { get; set; }

    public string? AltDescription { get; set; }

    public string? EmailAlias { get; set; }

    public bool? UseAsFormalTitle { get; set; }

    public virtual ICollection<TblCorrGroupOffice> TblCorrGroupOffices { get; set; } = new List<TblCorrGroupOffice>();

    public virtual ICollection<TblCorrMemberOffice> TblCorrMemberOffices { get; set; } = new List<TblCorrMemberOffice>();

    public virtual ICollection<TblMemTrxDirChange> TblMemTrxDirChanges { get; set; } = new List<TblMemTrxDirChange>();
}
