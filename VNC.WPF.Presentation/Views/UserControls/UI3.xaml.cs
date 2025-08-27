using System;
using System.Linq;
using System.Windows;

using VNC.Core.Mvvm;
using VNC.WPF.Presentation.ViewModels;

namespace VNC.WPF.Presentation.Views
{
    public partial class UI3 : ViewBase, IInstanceCountV
    {
        //public UI3()
        //{
        //    Int64 startTicks = 0;
        //    if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

        //    InstanceCountV++;

        //    InitializeComponent();
        //    InitializeView("C()");

        //    if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        //}

        public UI3(UI3ViewModel viewModel)
        {
            Int64 startTicks = Log.CONSTRUCTOR($"Enter viewModel({viewModel.GetType()}", Common.LOG_CATEGORY);

            InstanceCountVP++;

            InitializeComponent();

            ViewModel = viewModel;  // ViewBase sets the DataContext to ViewModel

            // For the rare case where the ViewModel needs to know about the View
            // ViewModel.View = this;

            InitializeView("C(VM)");

            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        }

        private void InitializeView(string message)
        {
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.ViewLow) startTicks = Log.VIEW_LOW("Enter", Common.LOG_CATEGORY);

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

            VMessage = $"{message} UI3 View says Hello";

            // Establish any additional DataContext(s) to things held in this View            

            tbVMessage.DataContext = this;

            if (Common.VNCCoreLogging.ViewLow) Log.VIEW_LOW("Exit", Common.LOG_CATEGORY, startTicks);
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
            MessageBox.Show("Three Booms");
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
