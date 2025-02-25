using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace VNC.Core.Mvvm
{
    public class ViewModelBase : IViewModel, INotifyPropertyChanged
    {
        #region Constructors, Initialization, and Load

        public ViewModelBase()
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);
#endif

#if LOGGING
            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        public ViewModelBase(IView view)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR($"Enter view({view.GetType()})", Common.LOG_CATEGORY);
#endif
            View = view;
            View.ViewModel = this;
#if LOGGING
            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion

        #region Fields and Properties

        [Display(AutoGenerateField = false)]
        public IView View
        {
            get;
            set;
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                if (_isBusy == value) return;
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        private string _message;

         public string Message
        {
            get { return _message; }
            set
            {
                if (_message == value) return;
                _message = value;
                OnPropertyChanged();
            }
        }

        private string _title = "ViewModelBase.Title";

        public string Title
        {
            get => _title;
            set
            {
                if (_title == value)
                    return;
                _title = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        // This is the traditional approach - requires string name to be passed in

        //private void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            Int64 startTicks = 0;
#if LOGGING
            if (Common.VNCCoreLogging.INPC) startTicks = Log.VIEWMODEL_LOW($"Enter ({propertyName})", Common.LOG_CATEGORY);
#endif
            // This is the new CompilerServices attribute!

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
#if LOGGING
            if (Common.VNCCoreLogging.INPC) Log.VIEWMODEL_LOW("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion
    }
}
