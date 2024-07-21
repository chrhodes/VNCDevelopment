using System;
using System.Collections.ObjectModel;
using System.Linq;

using Prism.Commands;
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
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);
#endif

            EventAggregator = eventAggregator;
            DialogService = dialogService;

#if LOGGING
            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion

        #region Fields & Properties (none)

        #endregion

        #region Event Handlers

        public void AfterDetailSaved(ObservableCollection<NavigationItemViewModel> items,
            AfterDetailSavedEventArgs args)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.EventHandler) startTicks = Log.EVENT_HANDLER($"Enter Id:({args.Id})", Common.LOG_CATEGORY);
#endif

            var lookupItem = items.SingleOrDefault(l => l.Id == args.Id);

            if (lookupItem == null)
            {
                items.Add(new NavigationItemViewModel(args.Id, args.DisplayMember,
                    args.ViewModelName,
                    EventAggregator, DialogService));
            }
            else
            {
                lookupItem.DisplayMember = args.DisplayMember;
            }
#if LOGGING
            if (Common.VNCCoreLogging.EventHandler) Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        public void AfterDetailDeleted(ObservableCollection<NavigationItemViewModel> items,
            AfterDetailDeletedEventArgs args)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.EventHandler) startTicks = Log.EVENT_HANDLER($"Enter Id:({args.Id})", Common.LOG_CATEGORY);
#endif

            var lookupItem = items.SingleOrDefault(f => f.Id == args.Id);

            if (lookupItem != null)
            {
                items.Remove(lookupItem);
            }
#if LOGGING
            if (Common.VNCCoreLogging.EventHandler) Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion

        #region Commands (none)


        #endregion

        #region Protected Methods

        public virtual void PublishDeveloperMode(Boolean developerMode)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Event) startTicks = Log.EVENT("Enter", Common.LOG_CATEGORY);
#endif
            var evt = EventAggregator.GetEvent<DeveloperModeEvent>();
            evt.Publish(developerMode);
            //EventAggregator.GetEvent<DeveloperModeEvent>().Publish(developerMode);
#if LOGGING
            if (Common.VNCCoreLogging.Event) Log.EVENT("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        public virtual void PublishStatusMessage(string message)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Event) startTicks = Log.EVENT("Enter", Common.LOG_CATEGORY);
#endif
            var evt = EventAggregator.GetEvent<StatusMessageEvent>();
            evt.Publish(Message);
            //EventAggregator.GetEvent<StatusMessageEvent>().Publish(Message);
#if LOGGING
            if (Common.VNCCoreLogging.Event) Log.EVENT("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion
    }
}
