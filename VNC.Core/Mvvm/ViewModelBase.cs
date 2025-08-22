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
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR($"Enter VM:{InstanceCountVM}", Common.LOG_CATEGORY);

        }

        public ViewModelBase(IView view)
        {
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR($"Enter view({view.GetType()}) VM:{InstanceCountVM}", Common.LOG_CATEGORY);

            View = view;
            View.ViewModel = this;
        }

        #endregion

        #region Fields and Properties

        [Display(AutoGenerateField = false)]
        public IView View
        {
            get;
            set;
        }

        private Boolean _isBusy;
        public Boolean IsBusy
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

            if (Common.VNCCoreLogging.INPC) startTicks = Log.VIEWMODEL_LOW($"Enter ({propertyName})", Common.LOG_CATEGORY);

            // This is the new CompilerServices attribute!

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            if (Common.VNCCoreLogging.INPC) Log.VIEWMODEL_LOW("Exit", Common.LOG_CATEGORY, startTicks);

        }

        #endregion

        #region IInstanceCountVM

        private static Int32 _instanceCountVM;

        public Int32 InstanceCountVM
        {
            get => _instanceCountVM;
            set => _instanceCountVM = value;
        }

        private static Int32 _instanceCountVMP;

        public Int32 InstanceCountVMP
        {
            get => _instanceCountVMP;
            set => _instanceCountVMP = value;
        }

        #endregion
    }
}
