using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblCorrMemberOffice
{
    public int MemberId { get; set; }

    public int OfficeId { get; set; }

    public bool PrimaryOffice { get; set; }

    public virtual TblMasMember Member { get; set; } = null!;

    public virtual TblValOffice Office { get; set; } = null!;
}
