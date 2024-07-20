using System;
using System.ComponentModel;
using System.Linq;
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
            this.DataContextChanged += UserControl_DataContextChanged;
#if LOGGING
            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        public ViewBase(IViewModel viewModel)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);
#endif
            ViewModel = viewModel;

            this.DataContextChanged += UserControl_DataContextChanged;
#if LOGGING
            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion

        #region Fields and Properties

        private string _viewType;

        public string ViewType
        {
            get => _viewType;
            set
            {
                if (_viewType == value)
                {
                    return;
                }

                _viewType = value;
                OnPropertyChanged();
            }
        }

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

        private string _viewModelType;

        public string ViewModelType
        {
            get => _viewModelType;
            set
            {
                if (_viewModelType == value)
                {
                    return;
                }

                _viewModelType = value;
                OnPropertyChanged();
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

        #endregion

        #region Event Handlers (none)

        private void UserControl_DataContextChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            var dc = DataContext is null ? "null" : DataContext.GetType().ToString().Split('.').Last();
            ViewModelType = dc;
        }

        #endregion

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
