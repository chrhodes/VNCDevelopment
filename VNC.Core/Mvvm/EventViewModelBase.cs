using System;

using Prism.Events;
using Prism.Services.Dialogs;

using VNC.Core.Events;

namespace VNC.Core.Mvvm
{
    public abstract class EventViewModelBase : ViewModelBase
    {
        #region Constructors, Initialization, and Load

        public readonly IEventAggregator EventAggregator;
        public readonly IDialogService DialogService;

        public EventViewModelBase(
            IEventAggregator eventAggregator,
            IDialogService dialogService)
        {
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

            EventAggregator = eventAggregator;
            DialogService = dialogService;

            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        }

        #endregion

        #region Fields & Properties (none)

        #endregion

        #region Event Handlers

//        // TODO(crhodes)
//        // Maybe these should go in NavigationItemViewModelBase
//        // That didn't work
//        // Put them in CombinedNavigationViewModel and CatNavigationViewModel

//        public virtual void AfterDetailSaved(ObservableCollection<NavigationItemViewModel> items,
//            AfterDetailSavedEventArgs args)
//        {
//
//            Int64 startTicks = 0;
//            if (Common.VNCCoreLogging.EventHandler) startTicks = Log.EVENT_HANDLER($"Enter Id:({args.Id})", Common.LOG_CATEGORY);
//

//            var lookupItem = items.SingleOrDefault(l => l.Id == args.Id);

//            if (lookupItem == null)
//            {
//                items.Add(new NavigationItemViewModel(args.Id, args.DisplayMember,
//                    args.ViewModelName,
//                    EventAggregator, DialogService));
//            }
//            else
//            {
//                lookupItem.DisplayMember = args.DisplayMember;
//            }
//
//            if (Common.VNCCoreLogging.EventHandler) Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY, startTicks);
//
//        }

//        public virtual void AfterDetailDeleted(ObservableCollection<NavigationItemViewModel> items,
//            AfterDetailDeletedEventArgs args)
//        {
//
//            Int64 startTicks = 0;
//            if (Common.VNCCoreLogging.EventHandler) startTicks = Log.EVENT_HANDLER($"Enter Id:({args.Id})", Common.LOG_CATEGORY);
//
//            var lookupItem = items.SingleOrDefault(f => f.Id == args.Id);

//            if (lookupItem != null)
//            {
//                items.Remove(lookupItem);
//            }
//
//            if (Common.VNCCoreLogging.EventHandler) Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY, startTicks);
//
//        }

        #endregion

        #region Commands (none)


        #endregion

        #region Public Methods

        public virtual void PublishDeveloperMode(Boolean developerMode)
        {

            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Event) startTicks = Log.EVENT("Enter", Common.LOG_CATEGORY);

            var evt = EventAggregator.GetEvent<DeveloperModeEvent>();
            evt.Publish(developerMode);
            //EventAggregator.GetEvent<DeveloperModeEvent>().Publish(developerMode);

            if (Common.VNCCoreLogging.Event) Log.EVENT("Exit", Common.LOG_CATEGORY, startTicks);

        }

        public virtual void PublishStatusMessage(string message)
        {

            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Event) startTicks = Log.EVENT("Enter", Common.LOG_CATEGORY);

            var evt = EventAggregator.GetEvent<StatusMessageEvent>();
            evt.Publish(message);
            //EventAggregator.GetEvent<StatusMessageEvent>().Publish(message);

            if (Common.VNCCoreLogging.Event) Log.EVENT("Exit", Common.LOG_CATEGORY, startTicks);

        }

        #endregion
    }
}
