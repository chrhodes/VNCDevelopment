using System;

namespace VNC.Core
{
    public class VNCLoggingConfig
    {
        public Boolean Enable { get; set; }

        public Boolean Info00 { get; set; }
        public Boolean Info01 { get; set; }
        public Boolean Info02 { get; set; }
        public Boolean Info03 { get; set; }
        public Boolean Info04 { get; set; }

        public Boolean Debug00 { get; set; }
        public Boolean Debug01 { get; set; }
        public Boolean Debug02 { get; set; }
        public Boolean Debug03 { get; set; }
        public Boolean Debug04 { get; set; }

        public Boolean ApplicationStart { get; set; }
        public Boolean ApplicationEnd { get; set; }
        public Boolean ApplicationInitialize { get; set; }
        public Boolean ApplicationInitializeLow { get; set; }

        public Boolean Application { get; set; }
        public Boolean ApplicationLow { get; set; }
        public Boolean ApplicationServices { get; set; }
        public Boolean ApplicationServicesLow { get; set; }
        public Boolean DeviceInitialize { get; set; }
        public Boolean DeviceInitializeLow { get; set; }
        public Boolean Domain { get; set; }
        public Boolean DomainLow { get; set; }
        public Boolean DomainServices { get; set; }
        public Boolean DomainServicesLow { get; set; }
        public Boolean Constructor { get; set; }
        public Boolean Core { get; set; }
        public Boolean Event { get; set; }
        public Boolean EventLow { get; set; }
        public Boolean EventHandler { get; set; }
        public Boolean EventHandlerLow { get; set; }
        public Boolean Infrastructure { get; set; }
        public Boolean InfrastructureLow { get; set; }
        public Boolean INPC { get; set; }
        public Boolean Module { get; set; }
        public Boolean ModuleInitialize { get; set; }
        public Boolean Persistence { get; set; }
        public Boolean PersistenceLow { get; set; }
        public Boolean Presentation { get; set; }
        public Boolean PresentationLow { get; set; }
        public Boolean View { get; set; }
        public Boolean ViewLow { get; set; }
        public Boolean ViewModel { get; set; }
        public Boolean ViewModelLow { get; set; }

        // NOTE(crhodes)
        // These are Available

        public Boolean Arch08 { get; set; }
        public Boolean Arch09 { get; set; }

        public Boolean Arch19 { get; set; }

        public Boolean Arch100 { get; set; }
        //public Boolean Arch101 { get; set; }
        public Boolean Arch104 { get; set; }
        public Boolean Arch105 { get; set; }
        public Boolean Arch106 { get; set; }
        //public Boolean Arch107 { get; set; }
        public Boolean Arch108 { get; set; }
        public Boolean Arch109 { get; set; }

        public Boolean Arch119 { get; set; }

        public Boolean Trace00 { get; set; }
        public Boolean Trace01 { get; set; }
        public Boolean Trace02 { get; set; }
        public Boolean Trace03 { get; set; }
        public Boolean Trace04 { get; set; }
    }
}
