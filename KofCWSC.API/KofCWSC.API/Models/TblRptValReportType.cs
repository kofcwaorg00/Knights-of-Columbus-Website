using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblRptValReportType
{
    public string Rpttype { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Gkfn { get; set; }
}
