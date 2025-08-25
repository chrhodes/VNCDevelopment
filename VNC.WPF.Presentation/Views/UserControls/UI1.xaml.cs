using System;
using System.Linq;
using System.Windows;

using VNC.Core.Mvvm;

namespace VNC.WPF.Presentation.Views
{
    public partial class UI1 : ViewBase, IInstanceCountV
    {
        public UI1()
        {
            Int64 startTicks = 0;
            if (Common.VNCLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

            InstanceCountV++;

            InitializeComponent();
            InitializeView("C()");

            if (Common.VNCLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        }

        private void InitializeView(string message)
        {
            Int64 startTicks = 0;
            if (Common.VNCLogging.ViewLow) startTicks = Log.VIEW_LOW("Enter", Common.LOG_CATEGORY);

            // Store information about the View, DataContext, and ViewModel 
            // for the DeveloperInfo control. Useful for debugging binding issues
            // Set the DataContext to us.

            ViewType = this.GetType().ToString().Split('.').Last();
            ViewModelType = ViewModel?.GetType().ToString().Split('.').Last();
            ViewDataContextType = this.DataContext?.GetType().ToString().Split('.').Last();
            spDeveloperInfo.DataContext = this;

            // TODO(crhodes)
            // Put things here that initialize the View
            // Hook event handlers, etc.

            VMessage = $"{message} UI1 View says Hello";

            // Establish any additional DataContext(s) to things held in this View            

            if (Common.VNCLogging.ViewLow) Log.VIEW_LOW("Exit", Common.LOG_CATEGORY, startTicks);
        }

        private string _vMessage;
        public string VMessage
        {
            get => _vMessage;
            set
            {
                if (_vMessage == value)
                {
                    return;
                }

                _vMessage = value;
                OnPropertyChanged();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {           
            MessageBox.Show("One Boom");
        }

        #region IInstanceCountV

        private static Int32 _instanceCountV;

        public Int32 InstanceCountV
        {
            get => _instanceCountV;
            set => _instanceCountV = value;
        }

        private static Int32 _instanceCountVP;

        public Int32 InstanceCountVP
        {
            get => _instanceCountVP;
            set => _instanceCountVP = value;
        }

        #endregion        
    }
}
