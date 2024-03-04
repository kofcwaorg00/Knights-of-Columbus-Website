using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblCorrMemberGroupHistory
{
    public int MemberId { get; set; }

    public int GroupId { get; set; }

    public int BegFratYear { get; set; }
}
