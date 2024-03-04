using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblCorrMemberGroup
{
    public int MemberId { get; set; }

    public int GroupId { get; set; }

    public virtual TblValGroup Group { get; set; } = null!;

    public virtual TblWscValGroup GroupNavigation { get; set; } = null!;

    public virtual TblMasMember Member { get; set; } = null!;
}
