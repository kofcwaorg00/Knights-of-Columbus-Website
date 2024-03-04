using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblRptValMsrtype
{
    public int Msrtype { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<TblSysValRole> TblSysValRoles { get; set; } = new List<TblSysValRole>();
}
