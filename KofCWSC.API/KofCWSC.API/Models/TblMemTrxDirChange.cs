using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblMemTrxDirChange
{
    public int Id { get; set; }

    public string Status { get; set; } = null!;

    public string KofCid { get; set; } = null!;

    public int OfficeId { get; set; }

    public int Council { get; set; }

    public string FirstName { get; set; } = null!;

    public string? Mi { get; set; }

    public string LastName { get; set; } = null!;

    public string? Suffix { get; set; }

    public string Address { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public string? Phone { get; set; }

    public string? WifesName { get; set; }

    public virtual TblValCouncil CouncilNavigation { get; set; } = null!;

    public virtual TblMasMember KofC { get; set; } = null!;

    public virtual TblValOffice Office { get; set; } = null!;
}
