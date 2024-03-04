using System;
using System.Collections.Generic;

namespace KofCWSC.API.Models;

public partial class TblAspnetRolesTemp
{
    public Guid ApplicationId { get; set; }

    public Guid RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string LoweredRoleName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual TblAspnetApplicationsTemp Application { get; set; } = null!;
}
