using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblArInvoiceDetail
{
    public int InvoiceNumber { get; set; }

    public string Item { get; set; } = null!;

    public decimal UnitPrice { get; set; }

    public decimal Qty { get; set; }

    public decimal Amount { get; set; }

    public virtual TblArInvoiceHeader InvoiceNumberNavigation { get; set; } = null!;

    public virtual TblArInvoiceItem ItemNavigation { get; set; } = null!;
}
