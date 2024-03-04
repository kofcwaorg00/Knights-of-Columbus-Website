using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblSysValRole
{
    public string RoleId { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Msrtype { get; set; }

    public virtual TblRptValMsrtype MsrtypeNavigation { get; set; } = null!;

    public virtual ICollection<TblSysUserRole> TblSysUserRoles { get; set; } = new List<TblSysUserRole>();
}
