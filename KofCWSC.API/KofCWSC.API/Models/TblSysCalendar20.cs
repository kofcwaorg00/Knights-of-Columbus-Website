using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblSysCalendar20
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public string? Event { get; set; }

    public string? Description { get; set; }

    public int? Type { get; set; }

    public string? AddedBy { get; set; }
}
