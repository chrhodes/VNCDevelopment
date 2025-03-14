using System;
using System.Collections.ObjectModel;
using System.Linq;

using Prism.Commands;
using Prism.Events;
using Prism.Regions;
using Prism.Services.Dialogs;

using VNC.Core.Events;

namespace VNC.Core.Mvvm
{
    public abstract class NavigationViewModelBase : EventViewModelBase, IConfirmNavigationRequest //, INavigationAware
    {
        #region Constructors, Initialization, and Load

        public readonly IRegionManager RegionManager;

        public NavigationViewModelBase(
            IRegionManager regionManager,
            IEventAggregator eventAggregator,
            IDialogService dialogService) : base (eventAggregator, dialogService)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);
#endif
            RegionManager = regionManager;

#if LOGGING
            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion

        #region Fields & Properties (none)


        #endregion

        #region Event Handlers



        #endregion

        #region Commands (none)


        #endregion

        #region Public Methods

        #region IConfirmNavigationRequest

        public virtual void ConfirmNavigationRequest(NavigationContext navigationContext, Action<Boolean> continuationCallback)
        {
            Int64 startTicks = 0;
            if (Common.VNCLogging.EventHandler) startTicks = Log.EVENT_HANDLER($"Enter {navigationContext.Uri}", Common.LOG_CATEGORY);

            continuationCallback(true);

            if (Common.VNCLogging.EventHandler) Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY, startTicks);
        }

        #endregion

        #region INavigationAware

        public virtual Boolean IsNavigationTarget(NavigationContext navigationContext)
        {
            Int64 startTicks = 0;
            if (Common.VNCLogging.EventHandler) startTicks = Log.EVENT_HANDLER($"Enter {navigationContext.Uri}", Common.LOG_CATEGORY);

            if (Common.VNCLogging.EventHandler) Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY, startTicks);

            // Create New Instance
            return false;
            // Use Existing Instance
            //return true;
        }

        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {
            Int64 startTicks = 0;
            if (Common.VNCLogging.EventHandler) startTicks = Log.EVENT_HANDLER($"Enter {navigationContext.Uri}", Common.LOG_CATEGORY);


            if (Common.VNCLogging.EventHandler) Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {
            Int64 startTicks = 0;
            if (Common.VNCLogging.EventHandler) startTicks = Log.EVENT_HANDLER($"Enter {navigationContext.Uri}", Common.LOG_CATEGORY);


            if (Common.VNCLogging.EventHandler) Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY, startTicks);
        }

        #endregion

        #endregion

        #region Protected Methods (none)


        #endregion

        #region Private Methods (none)


        #endregion
    }
}
