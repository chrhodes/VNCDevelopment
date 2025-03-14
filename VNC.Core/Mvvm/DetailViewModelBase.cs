using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

using Microsoft.EntityFrameworkCore;

using Prism.Commands;
using Prism.Events;
using Prism.Services.Dialogs;

using VNC.Core.Events;

namespace VNC.Core.Mvvm
{
    public abstract class DetailViewModelBase : EventViewModelBase, IDetailViewModel
    {
        #region Constructors, Initialization, and Load

        public DetailViewModelBase(
            IEventAggregator eventAggregator,
            IDialogService dialogService) : base(eventAggregator, dialogService)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);
#endif
            SaveCommand = new DelegateCommand(
                SaveExecute, SaveCanExecute);

            DeleteCommand = new DelegateCommand(
                DeleteExecute, DeleteCanExecute);

            CloseDetailViewCommand = new DelegateCommand(
                CloseDetailViewExecute);
#if LOGGING
            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion

        #region Enums (none)


        #endregion

        #region Structures (none)


        #endregion

        #region Fields and Properties

        private Int32 _id;
        public Int32 Id
        {
            get { return _id; }
            protected set
            {
                if (_id == value)
                    return;
                _id = value;
                OnPropertyChanged();
            }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            protected set
            {
                if (_title == value)
                    return;
                _title = value;
                OnPropertyChanged();
            }
        }

        private Boolean _hasChanges;
        public Boolean HasChanges
        {
            get { return _hasChanges; }
            set
            {
                if (_hasChanges != value)
                {
                    _hasChanges = value;
                    OnPropertyChanged();
                    ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();
                }
            }
        }

        public ICommand SaveCommand { get; }

        public ICommand DeleteCommand { get; }

        public ICommand CloseDetailViewCommand { get; }

        #endregion

        #region Event Handlers

        protected virtual void CloseDetailViewExecute()
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.EventHandler) startTicks = Log.EVENT_HANDLER("Enter", Common.LOG_CATEGORY);
#endif

            if (HasChanges)
            {
                var result = MessageBox.Show(
                    "You've made changes.  Close this item?", "Question", MessageBoxButton.OKCancel);

                if (result == MessageBoxResult.Cancel)
                {
                    return;
                }
            }

            PublishAfterDetailClosedEvent();
#if LOGGING
            if (Common.VNCCoreLogging.EventHandler) Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion

        #region Commands (none)



        #endregion

        #region Event (publish)

        protected virtual void PublishAfterCollectionSavedEvent()
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Event) startTicks = Log.EVENT("Enter", Common.LOG_CATEGORY);
#endif

            EventAggregator.GetEvent<AfterCollectionSavedEvent>()
                .Publish(new AfterCollectionSavedEventArgs
                {
                    ViewModelName = this.GetType().Name
                });
#if LOGGING
            if (Common.VNCCoreLogging.Event) Log.EVENT("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        protected virtual void PublishAfterDetailClosedEvent()
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Event) startTicks = Log.EVENT("Enter", Common.LOG_CATEGORY);
#endif

            EventAggregator.GetEvent<AfterDetailClosedEvent>()
                .Publish(new AfterDetailClosedEventArgs
                {
                    Id = this.Id,
                    ViewModelName = this.GetType().Name
                });
#if LOGGING
            if (Common.VNCCoreLogging.Event) Log.EVENT("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        protected virtual void PublishAfterDetailDeletedEvent(Int32 modelId)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Event) startTicks = Log.EVENT("Enter", Common.LOG_CATEGORY);
#endif

            EventAggregator.GetEvent<AfterDetailDeletedEvent>()
                .Publish(new AfterDetailDeletedEventArgs
                {
                    Id = modelId,
                    ViewModelName = this.GetType().Name
                });
#if LOGGING
            if (Common.VNCCoreLogging.Event) Log.EVENT("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        protected virtual void PublishAfterDetailSavedEvent(Int32 modelId, string displayMember)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Event) startTicks = Log.EVENT("Enter", Common.LOG_CATEGORY);
#endif

            EventAggregator.GetEvent<AfterDetailSavedEvent>()
                .Publish(new AfterDetailSavedEventArgs
                {
                    Id = modelId,
                    DisplayMember = displayMember,
                    ViewModelName = this.GetType().Name
                });
#if LOGGING
            if (Common.VNCCoreLogging.Event) Log.EVENT("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion

        #region Public Methods

        public abstract Task LoadAsync(Int32 id);

        #endregion

        #region Protected Methods

        // TODO(crhodes)
        // Should these do a bit more?  Maybe publish event?

        protected abstract void DeleteExecute();

        protected abstract Boolean DeleteCanExecute();

        protected abstract void SaveExecute();

        protected abstract Boolean SaveCanExecute();

        protected virtual async Task SaveWithOptimisticConcurrencyAsync(Func<Task> saveFunc, Action afterSaveAction)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Persistence) startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);
#endif

            try
            {
                await saveFunc();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                var databaseValues = ex.Entries.Single().GetDatabaseValues();

                if (databaseValues == null)
                {
                    MessageBox.Show(
                        "The entity has been deleted by another user.  Cannot continue.", "Error, Aborting");
                    PublishAfterDetailDeletedEvent(Id);
                    return;
                }

                var result = MessageBox.Show(
                    "The entity has been changed by someone else." +
                    " Click OK to save your changes anyway; Click Cancel" +
                    " to reload the entity from the database.", "Question", MessageBoxButton.OKCancel);

                if (result == MessageBoxResult.OK)   // Client Wins
                {
                    // Update the original values with database-values
                    var entry = ex.Entries.Single();
                    entry.OriginalValues.SetValues(entry.GetDatabaseValues());
                    await saveFunc();
                }
                else  // Database Wins
                {
                    // Reload entity from database
                    await ex.Entries.Single().ReloadAsync();
                    await LoadAsync(Id);
                }
            }

            // Do anything that needs to occur after saving

            afterSaveAction();
#if LOGGING
            if (Common.VNCCoreLogging.Persistence) Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion

        #region Private Methods (none)


        #endregion
    }
}
