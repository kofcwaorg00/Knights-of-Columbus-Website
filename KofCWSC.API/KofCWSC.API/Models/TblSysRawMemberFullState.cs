using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblSysRawMemberFullState
{
    public double? Council { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public double? MembershipNumber { get; set; }

    public string? MemberType { get; set; }

    public string? MemberClass { get; set; }

    public string? Prefix { get; set; }

    public string? Suffix { get; set; }

    public string? Nickname { get; set; }

    public string? ResidencePhone { get; set; }

    public string? CellPhone { get; set; }

    public string? PrimaryEmail { get; set; }

    public DateTime? _1stDegreeDate { get; set; }

    public DateTime? _2ndDegreeDate { get; set; }

    public DateTime? _3rdDegreeDate { get; set; }

    public DateTime? _4thDegreeDate { get; set; }

    public double? AssemblyNumber { get; set; }

    public DateTime? BirthDate { get; set; }
}
