using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblSysBulletinLog
{
    public int Gkfn { get; set; }

    public DateTime EventDateTime { get; set; }

    public string? UrlReferrer { get; set; }

    public string? Source { get; set; }

    public string? Type { get; set; }
}
