using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

using Prism.Commands;
using Prism.Events;
using Prism.Services.Dialogs;

using VNC.Core.Events;

namespace VNC.Core.Mvvm
{
    public class NavigationItemViewModel : EventViewModelBase
    {
        #region Constructors, Initialization, and Load

        private string _displayMember;
        private string _detailViewModelName;

        public NavigationItemViewModel(
            Int32 id,
            string displayMember,
            string detailViewModelName,
            IEventAggregator eventAggregator,
            IDialogService dialogService) : base(eventAggregator, dialogService)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR($"Enter id:({id}) displayMember:({displayMember}) detailViewModelName:({detailViewModelName})", Common.LOG_CATEGORY);
#endif
            Id = id;
            DisplayMember = displayMember;
            _detailViewModelName = detailViewModelName;

            OpenDetailViewCommand = new DelegateCommand(OpenDetailView);
#if LOGGING
            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion

        #region Fields & Properties

        public Int32 Id { get; set; }

        public string DisplayMember
        {
            get { return _displayMember; }
            set
            {
                if (_displayMember == value)
                    return;
                _displayMember = value;
                OnPropertyChanged();
            }
        }

        public ICommand OpenDetailViewCommand { get; }

        #endregion

        #region Event Handlers

        // TODO(crhodes)
        // Maybe this should be protected virtual

        private void OpenDetailView()
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.EventHandler) startTicks = Log.EVENT_HANDLER("Enter", Common.LOG_CATEGORY);
#endif
            PublishOpenDetailViewEvent();
#if LOGGING
            if (Common.VNCCoreLogging.EventHandler) Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion

        #region Private Methods

        private void PublishOpenDetailViewEvent()
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Event) startTicks = Log.EVENT($"Enter Id:({Id})", Common.LOG_CATEGORY);
#endif

            EventAggregator.GetEvent<OpenDetailViewEvent>()
                .Publish(new OpenDetailViewEventArgs
                {
                    Id = Id,
                    ViewModelName = _detailViewModelName
                });

#if LOGGING
            if (Common.VNCCoreLogging.Event) Log.EVENT("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion
    }
}

