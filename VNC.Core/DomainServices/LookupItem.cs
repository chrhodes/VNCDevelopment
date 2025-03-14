using System;

namespace VNC.Core.DomainServices
{
    public class LookupItem : ILookupItem<Int32>
    {
        public Int32 Id { get; set; }

        public string DisplayMember { get; set; }
    }
}
