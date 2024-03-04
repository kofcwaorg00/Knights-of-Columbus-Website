using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class QryRptliabIn
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? OfficeDescription { get; set; }

    public int Council { get; set; }

    public int? District { get; set; }

    public int? Assembly { get; set; }

    public bool? LiabIns { get; set; }

    public int OfficeId { get; set; }

    public string? AltOfficeDescription { get; set; }
}
