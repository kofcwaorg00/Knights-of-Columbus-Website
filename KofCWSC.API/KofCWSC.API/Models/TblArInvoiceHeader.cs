using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblArInvoiceHeader
{
    public int InvoiceNumber { get; set; }

    public int Council { get; set; }

    public DateOnly InvoiceDate { get; set; }

    public decimal InvoiceAmount { get; set; }

    public decimal InvoiceBalance { get; set; }

    /// <summary>
    /// (O)pen or (C)losed
    /// </summary>
    public string InvoiceStatus { get; set; } = null!;

    public string? InvoiceNotes { get; set; }

    public virtual TblValCouncil CouncilNavigation { get; set; } = null!;

    public virtual ICollection<TblArPaymentDetail> TblArPaymentDetails { get; set; } = new List<TblArPaymentDetail>();
}
