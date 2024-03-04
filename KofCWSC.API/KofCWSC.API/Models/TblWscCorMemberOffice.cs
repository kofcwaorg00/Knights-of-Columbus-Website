using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblWscCorMemberOffice
{
    public int MemberId { get; set; }

    public int OfficeId { get; set; }

    public bool PrimaryOffice { get; set; }

    public virtual TblWscMasMember Member { get; set; } = null!;

    public virtual TblWscValOffice Office { get; set; } = null!;
}
