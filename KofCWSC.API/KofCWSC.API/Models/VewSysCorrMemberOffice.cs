using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class VewSysCorrMemberOffice
{
    public int Memberid { get; set; }

    public int OfficeId { get; set; }

    public int UpdatedForNewFratYear { get; set; }
}
