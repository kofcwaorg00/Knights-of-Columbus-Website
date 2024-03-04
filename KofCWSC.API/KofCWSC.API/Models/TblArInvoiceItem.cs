using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblArInvoiceItem
{
    public string Item { get; set; } = null!;

    public decimal UnitPrice { get; set; }

    public string Description { get; set; } = null!;
}
