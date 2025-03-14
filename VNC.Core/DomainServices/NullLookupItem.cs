using System;

namespace VNC.Core.DomainServices
{
    public class NullLookupItem : LookupItem
    {
        public new Int32? Id { get { return null; } }
    }
}
