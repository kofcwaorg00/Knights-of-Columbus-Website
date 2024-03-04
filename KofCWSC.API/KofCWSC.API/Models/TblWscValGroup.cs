using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblWscValGroup
{
    public int GroupId { get; set; }

    public string? GroupName { get; set; }

    public virtual ICollection<TblCorrMemberGroup> TblCorrMemberGroups { get; set; } = new List<TblCorrMemberGroup>();

    public virtual ICollection<TblWscValOffice> TblWscValOffices { get; set; } = new List<TblWscValOffice>();
}
