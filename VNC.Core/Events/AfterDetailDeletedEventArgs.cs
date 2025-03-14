using System;

namespace VNC.Core.Events
{
    public class AfterDetailDeletedEventArgs
    {
        public Int32 Id { get; set; }
        public string ViewModelName { get; set; }
    }
}
