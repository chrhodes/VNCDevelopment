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

            VNCLoggingCommand = new DelegateCommand(VNCLogging);
            ConstructorLoggingCommand = new DelegateCommand(ConstructorLogging);
            INPCLoggingCommand = new DelegateCommand(INPCLogging);
            EventHandlerLoggingCommand = new DelegateCommand(EventHandlerLogging);
            EventLoggingCommand = new DelegateCommand(EventLogging);

#if LOGGING
            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion

        #region Fields & Properties

        public DelegateCommand VNCLoggingCommand { get; set; }
        public DelegateCommand ConstructorLoggingCommand { get; set; }
        public DelegateCommand INPCLoggingCommand { get; set; }
        public DelegateCommand EventHandlerLoggingCommand { get; set; }
        public DelegateCommand EventLoggingCommand { get; set; }

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

        #region Commands

        #region VNCLogging Command

        public string VNCLoggingContent { get; set; } = "VNCLogging";
        public string VNCLoggingToolTip { get; set; } = "VNCLogging ToolTip";

        public void VNCLogging()
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.EventHandler) startTicks = Log.EVENT_HANDLER("Enter", Common.LOG_CATEGORY);
#endif
            Message = "Cool, you called VNCLogging";

            PublishStatusMessage(Message);

            Common.VNCCoreLogging.Enable = ! Common.VNCCoreLogging.Enable;
            Common.VNCLogging.Enable = !Common.VNCLogging.Enable;
#if LOGGING
            if (Common.VNCCoreLogging.EventHandler) Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion

        #region ConstructorLogging Command

        public string ConstructorLoggingContent { get; set; } = "ConstructorLogging";
        public string ConstructorLoggingToolTip { get; set; } = "ConstructorLogging ToolTip";

        public void ConstructorLogging()
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.EventHandler) startTicks = Log.EVENT_HANDLER("Enter", Common.LOG_CATEGORY);
#endif
            Message = "Cool, you called ConstructorLogging";

            PublishStatusMessage(Message);

            Common.VNCCoreLogging.Constructor = !Common.VNCCoreLogging.Constructor;
            Common.VNCLogging.Constructor = !Common.VNCLogging.Constructor;

#if LOGGING
            if (Common.VNCCoreLogging.EventHandler) Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion

        #region INPCLogging Command

        public string INPCLoggingContent { get; set; } = "INPCLogging";
        public string INPCLoggingToolTip { get; set; } = "INPCLogging ToolTip";

        public void INPCLogging()
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.EventHandler) startTicks = Log.EVENT_HANDLER("Enter", Common.LOG_CATEGORY);
#endif
            Message = "Cool, you called INPCLogging";

            PublishStatusMessage(Message);

            Common.VNCCoreLogging.INPC = !Common.VNCCoreLogging.INPC;

#if LOGGING
            if (Common.VNCCoreLogging.EventHandler) Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion

        #region EventHandlerLogging Command

        public string EventHandlerLoggingContent { get; set; } = "EventHandlerLogging";
        public string EventHandlerLoggingToolTip { get; set; } = "EventHandlerLogging ToolTip";

        public void EventHandlerLogging()
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.EventHandler) startTicks = Log.EVENT_HANDLER("Enter", Common.LOG_CATEGORY);
#endif
            Message = "Cool, you called EventHandlerLogging";

            PublishStatusMessage(Message);

            Common.VNCCoreLogging.EventHandler = !Common.VNCCoreLogging.EventHandler;

#if LOGGING
            if (Common.VNCCoreLogging.EventHandler) Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion

        #region EventLogging Command

        public string EventLoggingContent { get; set; } = "EventLogging";
        public string EventLoggingToolTip { get; set; } = "EventLogging ToolTip";

        public void EventLogging()
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.EventHandler) startTicks = Log.EVENT_HANDLER("Enter", Common.LOG_CATEGORY);
#endif
            Message = "Cool, you called EventLogging";

            PublishStatusMessage(Message);

            Common.VNCCoreLogging.Event = !Common.VNCCoreLogging.Event;

#if LOGGING
            if (Common.VNCCoreLogging.EventHandler) Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion

        #endregion

        #region Protected Methods

        protected virtual void PublishStatusMessage(string message)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Event) startTicks = Log.EVENT("Enter", Common.LOG_CATEGORY);
#endif
            EventAggregator.GetEvent<StatusMessageEvent>().Publish(Message);
#if LOGGING
            if (Common.VNCCoreLogging.Event) Log.EVENT("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion
    }
}
