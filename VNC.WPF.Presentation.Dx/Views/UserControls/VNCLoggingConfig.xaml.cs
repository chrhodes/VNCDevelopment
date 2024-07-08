using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace VNC.WPF.Presentation.Dx.Views
{
    public partial class VNCLoggingConfig : UserControl, INotifyPropertyChanged
    {
        public VNCLoggingConfig()
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

            InitializeComponent();

            DataContext = this;

            Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        }


        private LoggingUIConfigVNCARCH _loggingUIConfig = new LoggingUIConfigVNCARCH();

        public LoggingUIConfigVNCARCH LoggingUIConfig
        {
            get => _loggingUIConfig;
            set
            {
                if (_loggingUIConfig == value)
                    return;
                _loggingUIConfig = value;
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


        private void ceInfo00C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.EventHandler = (Boolean)e.NewValue;
        }

        private void ceArch00C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Constructor = (Boolean)e.NewValue;
        }

        private void ceArch01C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.Event = (Boolean)e.NewValue;

        }

        private void ceArch02C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.EventHandler = (Boolean)e.NewValue;
        }

        private void ceArch03C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.ApplicationInitialize = (Boolean)e.NewValue;
        }

        private void ceArch04C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Core = (Boolean)e.NewValue;
        }

        private void ceArch05C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Module = (Boolean)e.NewValue;
        }

        private void ceArch06C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.ModuleInitialize = (Boolean)e.NewValue;
        }

        private void ceArch07C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Application = (Boolean)e.NewValue;
        }

        private void ceArch08C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.ApplicationServices = (Boolean)e.NewValue;
        }

        private void ceArch09C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Domain = (Boolean)e.NewValue;
        }

        private void ceArch10C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.DomainServices = (Boolean)e.NewValue;
        }

        private void ceArch11C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Persistence = (Boolean)e.NewValue;
        }

        private void ceArch12C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.PersistenceLow = (Boolean)e.NewValue;
        }

        private void ceArch13C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Infrastructure = (Boolean)e.NewValue;
        }

        private void ceArch14C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Presentation = (Boolean)e.NewValue;
        }

        private void ceArch15C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.View = (Boolean)e.NewValue;
        }

        private void ceArch16C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.ViewLow = (Boolean)e.NewValue;
        }

        private void ceArch17C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.ViewModel = (Boolean)e.NewValue;
        }

        private void ceArch18C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.ViewModelLow = (Boolean)e.NewValue;
        }
    }
}
