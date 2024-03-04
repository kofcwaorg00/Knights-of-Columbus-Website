using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblCorrMemberOfficeHistory
{
    public int MemberId { get; set; }

    public int OfficeId { get; set; }

    public bool PrimaryOffice { get; set; }

    public int BegFratYear { get; set; }
}
