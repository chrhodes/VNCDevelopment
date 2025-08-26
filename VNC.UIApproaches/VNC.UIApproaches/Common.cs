using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

using Prism.Events;
using Prism.Ioc;
using Prism.Regions;

namespace VNC.UIApproaches
{
    public class Common : VNC.WPF.Presentation.Common
    {
        public const string PROJECT_NAME = "UIApproachesModule";
        public new const string LOG_CATEGORY = "UIApproachesModule";

        // HACK(crhodes)
        // Decide if want to keep this.
        // Put here to try to get in View and ViewModel can ask for in constructor

        // TODO(crhodes)
        // When will these get initialized?

        public static IContainerProvider Container;
        public static IEventAggregator EventAggregator;
        public static IRegionManager DefaultRegionManager;
    }
}
