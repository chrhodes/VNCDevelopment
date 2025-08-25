using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace VNC.Core.Mvvm
{
    public class ViewBase : UserControl, IView, INotifyPropertyChanged, IViewSize
    {
        #region Constructors, Initialization, and Load

        public ViewBase()
        {
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

            this.DataContextChanged += UserControl_DataContextChanged;
        }

        public ViewBase(IViewModel viewModel)
        {
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter viewModel({viewModel.GetType()})", Common.LOG_CATEGORY);

            ViewModel = viewModel;

            this.DataContextChanged += UserControl_DataContextChanged;
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

        private string _viewDataContextType;

        public string ViewDataContextType
        {
            get => _viewDataContextType;
            set
            {
                if (_viewDataContextType == value)
                {
                    return;
                }

                _viewDataContextType = value;
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

        private Size _windowSize;
        public Size WindowSize
        {
            get => _windowSize;
            set
            {
                if (_windowSize == value)
                    return;
                _windowSize = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Event Handlers

        public void thisControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {

            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.EventHandlerLow) startTicks = Log.EVENT_HANDLER_LOW("Enter", Common.LOG_CATEGORY);

            var newSize = e.NewSize;
            var previousSize = e.PreviousSize;

            // TODO(crhodes)
            // Learn how to get runtime value of DeveloperUIInfo RenderHeight

            // HACK (crhodes)
            // For now assume if height is > 46 it is visible.

            if (newSize.Height > 46)
            {
                newSize.Height -= 46; // Adjust for visible DeveloperUIInfo control height
            }

            WindowSize = newSize;

            if (Common.VNCCoreLogging.EventHandlerLow) Log.EVENT_HANDLER_LOW("Exit", Common.LOG_CATEGORY, startTicks);
        }

        private void UserControl_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var dcType = DataContext is null ? "null" : DataContext.GetType().ToString().Split('.').Last();
            ViewModelType = dcType;
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

            if (Common.VNCCoreLogging.INPC) startTicks = Log.VIEW_LOW($"Enter ({propertyName})", Common.LOG_CATEGORY);

            // This is the new CompilerServices attribute!

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            if (Common.VNCCoreLogging.INPC) Log.VIEW_LOW("Exit", Common.LOG_CATEGORY, startTicks);

        }

        #endregion
    }
}
