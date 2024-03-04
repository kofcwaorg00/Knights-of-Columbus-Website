using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblWebSelfPublish
{
    public string Url { get; set; } = null!;

    public string? Data { get; set; }
}
