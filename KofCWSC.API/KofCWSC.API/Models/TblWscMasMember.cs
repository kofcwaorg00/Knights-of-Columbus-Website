using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblWscMasMember
{
    public int MemberId { get; set; }

    public string? KofCid { get; set; }

    public string? Prefix { get; set; }

    public string? FirstName { get; set; }

    public string? NickName { get; set; }

    public string? Mi { get; set; }

    public string? LastName { get; set; }

    public string? Suffix { get; set; }

    public string? AddInfo1 { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? Phone { get; set; }

    public string? WifesName { get; set; }

    public string? AddInfo2 { get; set; }

    public string? FaxNumber { get; set; }

    public int CouncilId { get; set; }

    public int? AssemblyId { get; set; }

    public int? Circle { get; set; }

    public string? Email { get; set; }

    public bool? Deceased { get; set; }

    public DateTime? LastUpdated { get; set; }

    public bool? SeatedDelegateDay1 { get; set; }

    public bool? SeatedDelegateDay2 { get; set; }

    public bool? SeatedDelegateDay3 { get; set; }

    public bool? PaidMpd { get; set; }

    public string? UserId { get; set; }

    public string? Data { get; set; }

    public bool? DataChanged { get; set; }

    public DateTime? LastLoggedIn { get; set; }

    public bool? CanEditAdmUi { get; set; }

    public int? DoNotEmail { get; set; }

    public virtual TblWscValAssembly? Assembly { get; set; }

    public virtual TblWscValCouncil Council { get; set; } = null!;
}
