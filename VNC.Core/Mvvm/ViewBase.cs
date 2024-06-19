using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace VNC.Core.Mvvm
{
    public class ViewBase : UserControl, IView, INotifyPropertyChanged
    {
        public ViewBase()
        {
        }

        public ViewBase(IViewModel viewModel)
        {
            ViewModel = viewModel;
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

        private bool _logOnPropertyChanged = false;

        [Display(AutoGenerateField = false)]
        public bool LogOnPropertyChanged
        {
            get => _logOnPropertyChanged;
            set
            {
                if (_logOnPropertyChanged == value)
                    return;
                _logOnPropertyChanged = value;
                OnPropertyChanged();
            }
        }

        private Visibility _developerUIMode = Visibility.Visible;
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
            long startTicks = 0;
#if LOGGING
            if (LogOnPropertyChanged)
            {
                startTicks = Log.VIEW_LOW($"Enter ({propertyName})", Common.LOG_CATEGORY);
            }
#endif
            // This is the new CompilerServices attribute!

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
#if LOGGING
            if (LogOnPropertyChanged)
            {
                Log.VIEW_LOW("Exit", Common.LOG_CATEGORY, startTicks);
            }
#endif
        }

        #endregion
    }
}
