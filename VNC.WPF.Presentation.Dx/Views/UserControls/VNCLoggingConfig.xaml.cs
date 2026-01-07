using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace VNC.WPF.Presentation.Dx.Views
{
    public partial class VNCLoggingConfig : UserControl, INotifyPropertyChanged
    {
        public VNCLoggingConfig()
        {
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

            InitializeComponent();

            DataContext = this;
            Loaded += OnLoaded;

            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        }

        // NOTE(crhodes)
        // Need to have LoggingUIConfig available 
        // so bindings to labels and tooltips will work at initialization

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
            if (Common.VNCCoreLogging.INPC) startTicks = Log.VIEW_LOW($"Enter ({propertyName})", Common.LOG_CATEGORY);

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            if (Common.VNCCoreLogging.INPC) Log.VIEW_LOW("Exit", Common.LOG_CATEGORY, startTicks);
        }

        #endregion

        private void ceInfo00C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Info00 = (Boolean)e.NewValue;
        }

        #region Arch Levels

        private void ceArch00C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Constructor = (Boolean)e.NewValue;
        }

        private void ceArch01C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Event = (Boolean)e.NewValue;
        }

        private void ceArch02C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.EventHandler = (Boolean)e.NewValue;
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
            Common.VNCLogging.DeviceInitialize = (Boolean)e.NewValue;
        }

        private void ceArch08C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Arch08 = (Boolean)e.NewValue;
        }

        private void ceArch09C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Arch09 = (Boolean)e.NewValue;
        }

        private void ceArch10C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Application = (Boolean)e.NewValue;
        }

        private void ceArch11C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.ApplicationServices = (Boolean)e.NewValue;
        }

        private void ceArch12C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Domain = (Boolean)e.NewValue;
        }

        private void ceArch13C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.DomainServices = (Boolean)e.NewValue;
        }

        private void ceArch14C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Infrastructure = (Boolean)e.NewValue;
        }

        private void ceArch15C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Persistence = (Boolean)e.NewValue;
        }

        private void ceArch16C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Presentation = (Boolean)e.NewValue;
        }

        private void ceArch17C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.View = (Boolean)e.NewValue;
        }

        private void ceArch18C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.ViewModel = (Boolean)e.NewValue;
        }

        private void ceArch19C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Arch19 = (Boolean)e.NewValue;
        }

        private void ceArch100C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Arch100 = (Boolean)e.NewValue;
        }

        private void ceArch101C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Arch101 = (Boolean)e.NewValue;
        }

        private void ceArch102C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.EventHandlerLow = (Boolean)e.NewValue;
        }

        private void ceArc1h03C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.ApplicationInitializeLow = (Boolean)e.NewValue;
        }

        private void ceArch104C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Arch104 = (Boolean)e.NewValue;
        }

        private void ceArch105C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Arch105 = (Boolean)e.NewValue;
        }

        private void ceArch106C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Arch106 = (Boolean)e.NewValue;
        }

        private void ceArch107C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.DeviceInitializeLow = (Boolean)e.NewValue;
        }

        private void ceArch108C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Arch108 = (Boolean)e.NewValue;
        }

        private void ceArch109C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Arch109 = (Boolean)e.NewValue;
        }

        private void ceArch110C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.ApplicationLow = (Boolean)e.NewValue;
        }

        private void ceArch111C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.ApplicationServicesLow = (Boolean)e.NewValue;
        }

        private void ceArch112C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.DomainLow = (Boolean)e.NewValue;
        }

        private void ceArch113C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.DomainServicesLow = (Boolean)e.NewValue;
        }

        private void ceArch114C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.InfrastructureLow = (Boolean)e.NewValue;
        }

        private void ceArch115C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.PersistenceLow = (Boolean)e.NewValue;
        }

        private void ceArch116C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.PresentationLow = (Boolean)e.NewValue;
        }

        private void ceArch117C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.ViewLow = (Boolean)e.NewValue;
        }

        private void ceArch118C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.ViewModelLow = (Boolean)e.NewValue;
        }

        private void ceArch119C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Arch119 = (Boolean)e.NewValue;
        }

        #endregion

        private void ceINPC_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.INPC = (Boolean)e.NewValue;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            Int64 startTicks = 0;
            if (Common.VNCLogging.EventHandler) startTicks = Log.EVENT_HANDLER("Enter", Common.LOG_CATEGORY);

            ceInfo00C.IsChecked = Common.VNCLogging.Info00;
            //ceInfo01C.IsChecked = Common.VNCLogging.Info01;
            //ceInfo02C.IsChecked = Common.VNCLogging.Info02;
            //ceInfo03C.IsChecked = Common.VNCLogging.Info03;
            //ceInfo04C.IsChecked = Common.VNCLogging.Info04;

            //ceDebug00C.IsChecked = Common.VNCLogging.Debug00;
            //ceDebug01C.IsChecked = Common.VNCLogging.Debug01;
            //ceDebug02C.IsChecked = Common.VNCLogging.Debug02;
            //ceDebug03C.IsChecked = Common.VNCLogging.Debug03;
            //ceDebug04C.IsChecked = Common.VNCLogging.Debug04;

            ceArch00C.IsChecked = Common.VNCLogging.Constructor;
            ceArch01C.IsChecked = Common.VNCLogging.Event;
            ceArch02C.IsChecked = Common.VNCLogging.EventHandler;
            ceArch03C.IsChecked = Common.VNCLogging.ApplicationInitialize;
            ceArch04C.IsChecked = Common.VNCLogging.Core;
            ceArch05C.IsChecked = Common.VNCLogging.Module;
            ceArch06C.IsChecked = Common.VNCLogging.ModuleInitialize;
            ceArch07C.IsChecked = Common.VNCLogging.DeviceInitialize;
            //ceArch08C.IsChecked = Common.VNCLogging.Arch08;
            //ceArch09C.IsChecked = Common.VNCLogging.Arch09;
            ceArch10C.IsChecked = Common.VNCLogging.Application;
            ceArch11C.IsChecked = Common.VNCLogging.ApplicationServices;
            ceArch12C.IsChecked = Common.VNCLogging.Domain;
            ceArch13C.IsChecked = Common.VNCLogging.DomainServices;
            ceArch14C.IsChecked = Common.VNCLogging.Infrastructure;
            ceArch15C.IsChecked = Common.VNCLogging.Persistence;
            ceArch16C.IsChecked = Common.VNCLogging.Presentation;
            ceArch17C.IsChecked = Common.VNCLogging.View;
            ceArch18C.IsChecked = Common.VNCLogging.ViewModel;

            //ceArch100C.IsChecked = Common.VNCLogging.Arch100;
            //ceArch101C.IsChecked = Common.VNCLogging.Arch101;
            ceArch102C.IsChecked = Common.VNCLogging.EventHandlerLow;
            ceArch103C.IsChecked = Common.VNCLogging.ApplicationInitializeLow;
            //ceArch104C.IsChecked = Common.VNCLogging.Arch104;
            //ceArch105C.IsChecked = Common.VNCLogging.Arch105;
            //ceArch106C.IsChecked = Common.VNCLogging.Arch106;
            ceArch107C.IsChecked = Common.VNCLogging.DeviceInitializeLow;
            //ceArch018C.IsChecked = Common.VNCLogging.Arch08;
            //ceArch109C.IsChecked = Common.VNCLogging.Arch09;
            ceArch110C.IsChecked = Common.VNCLogging.ApplicationLow;
            ceArch111C.IsChecked = Common.VNCLogging.ApplicationServicesLow;
            ceArch112C.IsChecked = Common.VNCLogging.DomainLow;
            ceArch113C.IsChecked = Common.VNCLogging.DomainServicesLow;
            ceArch114C.IsChecked = Common.VNCLogging.InfrastructureLow;
            ceArch115C.IsChecked = Common.VNCLogging.PersistenceLow;
            ceArch116C.IsChecked = Common.VNCLogging.PresentationLow;
            ceArch117C.IsChecked = Common.VNCLogging.ViewLow;
            ceArch118C.IsChecked = Common.VNCLogging.ViewModelLow;
            //ceArch119C.IsChecked = Common.VNCLogging.Arch119;

            ceINPC.IsChecked = Common.VNCLogging.INPC;

            if (Common.VNCLogging.EventHandler) Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY, startTicks);
        }

        private void ceEnabled_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCLogging.Enable = (Boolean)ceEnabled.IsChecked;

        }
    }
}
