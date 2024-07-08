using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace VNC.Core.Mvvm
{
    public class ViewBase : UserControl, IView, INotifyPropertyChanged
    {
        #region Constructors, Initialization, and Load

        public ViewBase()
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter/Exit", Common.LOG_CATEGORY);
#endif
        }

        public ViewBase(IViewModel viewModel)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);
#endif
            ViewModel = viewModel;
#if LOGGING
            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion

        private IViewModel _viewModel;

        public IViewModel ViewModel
        {
            get { return _viewModel; }

            set
            {
                _viewModel = value;
                DataContext = _viewModel;
            }
        }

        private Visibility _developerUIMode = Common.DeveloperUIMode;
        public Visibility DeveloperUIMode
        {
            get => _developerUIMode;
            set
            {
                if (_developerUIMode == value)
                    return;
                _developerUIMode = value;
                OnPropertyChanged();
            }
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        // This is the traditional approach - requires string name to be passed in

        //private void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            Int64 startTicks = 0;
#if LOGGING
            if (Common.VNCCoreLogging.INPC) startTicks = Log.VIEW_LOW($"Enter ({propertyName})", Common.LOG_CATEGORY);
#endif
            // This is the new CompilerServices attribute!

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
#if LOGGING
            if (Common.VNCCoreLogging.INPC) Log.VIEW_LOW("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion
    }
}
