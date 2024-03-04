using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblRpt4wavItem
{
    public string Rpttype { get; set; } = null!;

    public string? MasterName { get; set; }

    public string? Province { get; set; }

    public string? ReqFor { get; set; }

    public string? MemberNo { get; set; }

    public DateTime? FirstDegDate { get; set; }

    public int? CouncilNo { get; set; }

    public string? SpecialCircum { get; set; }

    public DateTime? ExemDate { get; set; }

    public string? ExemLocCity { get; set; }

    public string? ExemLocState { get; set; }

    public string? Comments { get; set; }

    public string? SendersEmail { get; set; }

    public Guid? RptId { get; set; }

    public int Gkfn { get; set; }
}
