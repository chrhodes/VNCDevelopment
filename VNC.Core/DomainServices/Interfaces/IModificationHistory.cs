﻿using System;

namespace VNC.Core.DomainServices
{
    public interface IModificationHistory
    {
        Nullable<DateTime> DateModified { get; set; }

        Nullable<DateTime> DateCreated { get; set; }

        Boolean? IsDirty { get; set; }
    }
}
