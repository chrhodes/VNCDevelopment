using System;

using VNC.Core.Mvvm;

namespace VNC.WPF.Presentation.ViewModels
{
    public class UIFiveViewModel : ViewModelBase
    {
        #region Constructors, Initialization, and Load

        public UIFiveViewModel()
        {
            Int64 startTicks = 0;
            if (Common.VNCLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

            InstanceCountVM++;

            Message = "Hello from UIFive ViewModel";

            if (Common.VNCLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        }

        #endregion
    }
}
