using System;

using VNC.Core.Mvvm;

namespace VNC.WPF.Presentation.ViewModels
{
    public class UITwoViewModel : ViewModelBase
    {
        #region Constructors, Initialization, and Load

        public UITwoViewModel()
        {
            Int64 startTicks = 0;
            if (Common.VNCLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

            InstanceCountVM++;

            Message = "Hello from UITwo ViewModel";

            if (Common.VNCLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        }

        #endregion
    }
}
