using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class QryRptbulletin
{
    public int? District { get; set; }

    public string? AltOfficeDescription { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public int Council { get; set; }

    public int? Assembly { get; set; }

    public string OfficeId { get; set; } = null!;

    public string OfficeDescription { get; set; } = null!;

    public int MemberId { get; set; }

    public string? FullName { get; set; }
}
