using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblValGroup
{
    public int GroupId { get; set; }

    public string? GroupName { get; set; }

    public virtual ICollection<TblCorrGroupOffice> TblCorrGroupOffices { get; set; } = new List<TblCorrGroupOffice>();

    public virtual ICollection<TblCorrMemberGroup> TblCorrMemberGroups { get; set; } = new List<TblCorrMemberGroup>();
}
