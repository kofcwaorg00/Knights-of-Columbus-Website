using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblSysCalendar
{
    public int Id { get; set; }

    public string? AddedBy { get; set; }

    public DateTime? DateAdded { get; set; }

    public int? Day { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }

    public string? Subject { get; set; }

    public string? Message { get; set; }
}
