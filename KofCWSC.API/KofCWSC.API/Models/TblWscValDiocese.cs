using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblWscValDiocese
{
    public string DioceseId { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<TblWscValCouncil> TblWscValCouncils { get; set; } = new List<TblWscValCouncil>();
}
