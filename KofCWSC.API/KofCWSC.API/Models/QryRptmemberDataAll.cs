using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class QryRptmemberDataAll
{
    public int? MemberId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? AddInfo1 { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? Phone { get; set; }

    public string? AddInfo2 { get; set; }

    public string? WifesName { get; set; }

    public string? FaxNumber { get; set; }

    public int? Council { get; set; }

    public int? Assembly { get; set; }

    public int? Circle { get; set; }

    public string? Email { get; set; }

    public bool? Deceased { get; set; }

    public string? CellPhone { get; set; }

    public DateTime? LastUpdated { get; set; }

    public bool? Bulletin { get; set; }

    public int GroupId { get; set; }

    public string? GroupName { get; set; }

    public int OfficeId { get; set; }

    public bool PrimaryOffice { get; set; }

    public string? OfficeDescription { get; set; }

    public int? DirSortOrder { get; set; }

    public string? AltDescription { get; set; }

    public int? District { get; set; }
}
