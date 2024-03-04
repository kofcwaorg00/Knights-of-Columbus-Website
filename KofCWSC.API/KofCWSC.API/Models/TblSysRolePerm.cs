using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblSysRolePerm
{
    public string RoleId { get; set; } = null!;

    public string ObjId { get; set; } = null!;

    public bool Enabled { get; set; }
}
