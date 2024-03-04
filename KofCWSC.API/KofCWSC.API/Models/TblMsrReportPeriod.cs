using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblMsrReportPeriod
{
    public int Id { get; set; }

    public string Period { get; set; } = null!;

    public string PeriodText { get; set; } = null!;
}
