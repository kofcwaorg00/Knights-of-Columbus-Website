using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblSysValObject
{
    public string ObjId { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string TypeId { get; set; } = null!;
}
