using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class QryRptrollCallSubOther
{
    public int GroupId { get; set; }

    public string? GroupName { get; set; }

    public int MemberId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? AddInfo1 { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? Phone { get; set; }

    public string? WifesName { get; set; }

    public string? AddInfo2 { get; set; }

    public int Council { get; set; }

    public int? Assembly { get; set; }

    public int? Circle { get; set; }

    public string? Email { get; set; }

    public int CNumber { get; set; }

    public string? CLocation { get; set; }

    public string? CName { get; set; }

    public int? District { get; set; }
}
