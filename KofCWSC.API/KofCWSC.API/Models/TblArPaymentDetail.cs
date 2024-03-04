using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblArPaymentDetail
{
    public int Id { get; set; }

    public int InvoiceNumber { get; set; }

    public string PaymentReference { get; set; } = null!;

    public decimal PaymentAmount { get; set; }

    public DateOnly PaymentDate { get; set; }

    public virtual TblArInvoiceHeader InvoiceNumberNavigation { get; set; } = null!;
}
