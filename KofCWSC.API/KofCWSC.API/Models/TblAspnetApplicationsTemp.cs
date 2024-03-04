using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblAspnetApplicationsTemp
{
    public string ApplicationName { get; set; } = null!;

    public string LoweredApplicationName { get; set; } = null!;

    public Guid ApplicationId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<TblAspnetRolesTemp> TblAspnetRolesTemps { get; set; } = new List<TblAspnetRolesTemp>();
}
