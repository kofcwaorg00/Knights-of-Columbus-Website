using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblValRptPeriod
{
    public int RptPeriod { get; set; }

    public string Description { get; set; } = null!;

    public int Gkfn { get; set; }

    public DateTime DateDue { get; set; }
}
