using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblRptDirChangeItem
{
    public string? EntityType { get; set; }

    public int? EntityNumber { get; set; }

    public string? EntityName { get; set; }

    public string? Miwhere { get; set; }

    public string? Miwhen { get; set; }

    public string? Ind1Type { get; set; }

    public string? Ind1FirstName { get; set; }

    public string? Ind1Mi { get; set; }

    public string? Ind1LastName { get; set; }

    public string? Ind1Address { get; set; }

    public string? Ind1City { get; set; }

    public string? Ind1State { get; set; }

    public string? Ind1Zip { get; set; }

    public string? Ind1Phone { get; set; }

    public string? Ind1Fax { get; set; }

    public string? Ind1Email { get; set; }

    public string? Ind1WifesName { get; set; }

    public string? Ind1KofCid { get; set; }

    public string? Ind2Type { get; set; }

    public string? Ind2FirstName { get; set; }

    public string? Ind2Mi { get; set; }

    public string? Ind2LastName { get; set; }

    public string? Ind2Address { get; set; }

    public string? Ind2City { get; set; }

    public string? Ind2State { get; set; }

    public string? Ind2Zip { get; set; }

    public string? Ind2Phone { get; set; }

    public string? Ind2Fax { get; set; }

    public string? Ind2Email { get; set; }

    public string? Ind2WifesName { get; set; }

    public string? Ind2KofCid { get; set; }

    public Guid RptId { get; set; }

    public int Gkfn { get; set; }

    public string? SendersName { get; set; }

    public string? SendersEmail { get; set; }

    public DateTime? SubmitDate { get; set; }
}
