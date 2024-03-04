using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblSysUserRole
{
    public int Gkfn { get; set; }

    public string MemberNo { get; set; } = null!;

    public string RoleId { get; set; } = null!;

    public virtual TblSysValRole Role { get; set; } = null!;
}
