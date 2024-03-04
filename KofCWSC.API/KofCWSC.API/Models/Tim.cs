using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class Tim
{
    public DateTime? Date { get; set; }

    public string? Description { get; set; }

    public string? OriginalDescription { get; set; }

    public double? Amount { get; set; }

    public string? TransactionType { get; set; }

    public string? Category { get; set; }

    public string? AccountName { get; set; }
}
