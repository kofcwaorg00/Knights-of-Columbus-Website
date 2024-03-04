using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblValCouncil
{
    public int CNumber { get; set; }

    public string? CLocation { get; set; }

    public string? CName { get; set; }

    public int? District { get; set; }

    public string? AddInfo1 { get; set; }

    public string? AddInfo2 { get; set; }

    public string? AddInfo3 { get; set; }

    public bool? LiabIns { get; set; }

    public string? DioceseId { get; set; }

    public DateTime? Chartered { get; set; }

    public string? WebSiteUrl { get; set; }

    public string? BulletinUrl { get; set; }

    public decimal? Arbalance { get; set; }

    public string Status { get; set; } = null!;

    public virtual TblValDistrict? DistrictNavigation { get; set; }

    public virtual ICollection<TblArInvoiceHeader> TblArInvoiceHeaders { get; set; } = new List<TblArInvoiceHeader>();

    public virtual ICollection<TblMasMember> TblMasMembers { get; set; } = new List<TblMasMember>();

    public virtual ICollection<TblMemTrxDirChange> TblMemTrxDirChanges { get; set; } = new List<TblMemTrxDirChange>();
}
