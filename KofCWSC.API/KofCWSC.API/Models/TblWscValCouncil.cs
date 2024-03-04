using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblWscValCouncil
{
    public int CouncilId { get; set; }

    public string? CouncilLocation { get; set; }

    public string? CouncilName { get; set; }

    public int? DistrictId { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? St { get; set; }

    public string? Zip { get; set; }

    public string? AddInfo1 { get; set; }

    public string? AddInfo2 { get; set; }

    public string? AddInfo3 { get; set; }

    public bool? LiabIns { get; set; }

    public string? DioceseId { get; set; }

    public DateTime? Chartered { get; set; }

    public string? WebSiteUrl { get; set; }

    public string? BulletinUrl { get; set; }

    public decimal? Arbalance { get; set; }

    public virtual TblWscValDiocese? Diocese { get; set; }

    public virtual TblWscValDistrict? District { get; set; }

    public virtual ICollection<TblWscMasMember> TblWscMasMembers { get; set; } = new List<TblWscMasMember>();
}
