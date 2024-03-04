using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblSysActiveUser
{
    public string? UserId { get; set; }

    public DateTime? LoginDateTime { get; set; }
}
