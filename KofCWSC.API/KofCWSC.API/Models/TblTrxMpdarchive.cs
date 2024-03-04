using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblTrxMpdarchive
{
    public int Id { get; set; }

    public int? CNumber { get; set; }

    public string Fullname { get; set; } = null!;

    public int? Code { get; set; }

    public float? Totaldue { get; set; }

    public int? CheckNo { get; set; }

    public DateTime? CheckDate { get; set; }

    public bool? Day1 { get; set; }

    public bool? Day2 { get; set; }

    public bool? Day3 { get; set; }

    public float? Misc { get; set; }

    public int? NoCheck { get; set; }

    public int? District { get; set; }

    public string? Office { get; set; }

    public int? NoMileage { get; set; }

    public int? CheckPrinted { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Location { get; set; }

    public string? Groups { get; set; }

    public int? Miles { get; set; }

    public int MemberId { get; set; }

    public string? BatchId { get; set; }
}
