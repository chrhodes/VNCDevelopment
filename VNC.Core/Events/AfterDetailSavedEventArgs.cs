using System;

namespace VNC.Core.Events
{
    public class AfterDetailSavedEventArgs
    {
        public Int32 Id { get; set; }
        public string DisplayMember { get; set; }
        public string ViewModelName { get; set; }
    }
}
