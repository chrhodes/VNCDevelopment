using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

using DevExpress.Xpf.Core.Native;

namespace VNC.WPF.Presentation.Dx.Views
{
    public partial class VNCCoreLoggingConfig : UserControl, INotifyPropertyChanged
    {
        public VNCCoreLoggingConfig()
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

            // This is the new CompilerServices attribute!
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            if (Common.VNCCoreLogging.INPC) Log.VIEW_LOW("Exit", Common.LOG_CATEGORY, startTicks);
        }

        #endregion

        private void ceInfo00C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.Info00 = (Boolean)e.NewValue;
        }

        #region Arch Levels

        private void ceArch00C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.Constructor = (Boolean)e.NewValue;
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
            Common.VNCCoreLogging.ApplicationInitialize = (Boolean)e.NewValue;
        }

        private void ceArch04C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.Core = (Boolean)e.NewValue;
        }

        private void ceArch05C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.Module = (Boolean)e.NewValue;
        }

        private void ceArch06C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.ModuleInitialize = (Boolean)e.NewValue;
        }

        private void ceArch07C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.DeviceInitialize = (Boolean)e.NewValue;
        }

        private void ceArch08C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.Arch08 = (Boolean)e.NewValue;
        }

        private void ceArch09C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.Arch09 = (Boolean)e.NewValue;
        }

        private void ceArch10C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.Application = (Boolean)e.NewValue;
        }

        private void ceArch11C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.ApplicationServices = (Boolean)e.NewValue;
        }

        private void ceArch12C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.Domain = (Boolean)e.NewValue;
        }

        private void ceArch13C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.DomainServices = (Boolean)e.NewValue;
        }

        private void ceArch14C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.Infrastructure = (Boolean)e.NewValue;
        }

        private void ceArch15C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.Persistence = (Boolean)e.NewValue;
        }

        private void ceArch16C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.Presentation = (Boolean)e.NewValue;
        }

        private void ceArch17C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.View = (Boolean)e.NewValue;
        }

        private void ceArch18C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.ViewModel = (Boolean)e.NewValue;
        }

        private void ceArch19C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.Arch19 = (Boolean)e.NewValue;
        }

        private void ceArch100C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.Arch100 = (Boolean)e.NewValue;
        }

        private void ceArch101C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.EventLow = (Boolean)e.NewValue;
        }

        private void ceArch102C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.EventHandlerLow = (Boolean)e.NewValue;
        }

        private void ceArc1h03C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.ApplicationInitializeLow = (Boolean)e.NewValue;
        }

        private void ceArch104C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.Arch104 = (Boolean)e.NewValue;
        }

        private void ceArch105C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.Arch105 = (Boolean)e.NewValue;
        }

        private void ceArch106C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.Arch106 = (Boolean)e.NewValue;
        }

        private void ceArch107C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.DeviceInitializeLow = (Boolean)e.NewValue;
        }

        private void ceArch108C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.Arch108 = (Boolean)e.NewValue;
        }

        private void ceArch109C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.Arch109 = (Boolean)e.NewValue;
        }

        private void ceArch110C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.ApplicationLow = (Boolean)e.NewValue;
        }

        private void ceArch111C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.ApplicationServicesLow = (Boolean)e.NewValue;
        }

        private void ceArch112C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.DomainLow = (Boolean)e.NewValue;
        }

        private void ceArch113C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.DomainServicesLow = (Boolean)e.NewValue;
        }

        private void ceArch114C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.InfrastructureLow = (Boolean)e.NewValue;
        }

        private void ceArch115C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.PersistenceLow = (Boolean)e.NewValue;
        }

        private void ceArch116C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.PresentationLow = (Boolean)e.NewValue;
        }

        private void ceArch117C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.ViewLow = (Boolean)e.NewValue;
        }

        private void ceArch118C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.ViewModelLow = (Boolean)e.NewValue;
        }

        private void ceArch119C_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.Arch119 = (Boolean)e.NewValue;
        }

        #endregion

        private void ceINPC_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.INPC = (Boolean)e.NewValue;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.EventHandler) startTicks = Log.EVENT_HANDLER("Enter", Common.LOG_CATEGORY);

            ceInfo00C.IsChecked = Common.VNCCoreLogging.Info00;
            //ceInfo01C.IsChecked = Common.VNCCoreLogging.Info01;
            //ceInfo02C.IsChecked = Common.VNCCoreLogging.Info02;
            //ceInfo03C.IsChecked = Common.VNCCoreLogging.Info03;
            //ceInfo04C.IsChecked = Common.VNCCoreLogging.Info04;

            //ceDebug00C.IsChecked = Common.VNCCoreLogging.Debug00;
            //ceDebug01C.IsChecked = Common.VNCCoreLogging.Debug01;
            //ceDebug02C.IsChecked = Common.VNCCoreLogging.Debug02;
            //ceDebug03C.IsChecked = Common.VNCCoreLogging.Debug03;
            //ceDebug04C.IsChecked = Common.VNCCoreLogging.Debug04;

            ceArch00C.IsChecked = Common.VNCCoreLogging.Constructor;
            ceArch01C.IsChecked = Common.VNCCoreLogging.Event;
            ceArch02C.IsChecked = Common.VNCCoreLogging.EventHandler;
            ceArch03C.IsChecked = Common.VNCCoreLogging.ApplicationInitialize;
            ceArch04C.IsChecked = Common.VNCCoreLogging.Core;
            ceArch05C.IsChecked = Common.VNCCoreLogging.Module;
            ceArch06C.IsChecked = Common.VNCCoreLogging.ModuleInitialize;
            ceArch07C.IsChecked = Common.VNCCoreLogging.DeviceInitialize;
            //ceArch08C.IsChecked = Common.VNCCoreLogging.Arch08;
            //ceArch09C.IsChecked = Common.VNCCoreLogging.Arch09;
            ceArch10C.IsChecked = Common.VNCCoreLogging.Application;
            ceArch11C.IsChecked = Common.VNCCoreLogging.ApplicationServices;
            ceArch12C.IsChecked = Common.VNCCoreLogging.Domain;
            ceArch13C.IsChecked = Common.VNCCoreLogging.DomainServices;
            ceArch14C.IsChecked = Common.VNCCoreLogging.Infrastructure;
            ceArch15C.IsChecked = Common.VNCCoreLogging.Persistence;
            ceArch16C.IsChecked = Common.VNCCoreLogging.Presentation;
            ceArch17C.IsChecked = Common.VNCCoreLogging.View;
            ceArch18C.IsChecked = Common.VNCCoreLogging.ViewModel;

            //ceArch100C.IsChecked = Common.VNCCoreLogging.Arch100;
            ceArch101C.IsChecked = Common.VNCCoreLogging.EventLow;
            ceArch102C.IsChecked = Common.VNCCoreLogging.EventHandlerLow;
            ceArch103C.IsChecked = Common.VNCCoreLogging.ApplicationInitializeLow;
            //ceArch104C.IsChecked = Common.VNCCoreLogging.Arch104;
            //ceArch105C.IsChecked = Common.VNCCoreLogging.Arch105;
            //ceArch106C.IsChecked = Common.VNCCoreLogging.Arch106;
            ceArch107C.IsChecked = Common.VNCCoreLogging.DeviceInitializeLow;
            //ceArch018C.IsChecked = Common.VNCCoreLogging.Arch08;
            //ceArch109C.IsChecked = Common.VNCCoreLogging.Arch09;
            ceArch110C.IsChecked = Common.VNCCoreLogging.ApplicationLow;
            ceArch111C.IsChecked = Common.VNCCoreLogging.ApplicationServicesLow;
            ceArch112C.IsChecked = Common.VNCCoreLogging.DomainLow;
            ceArch113C.IsChecked = Common.VNCCoreLogging.DomainServicesLow;
            ceArch114C.IsChecked = Common.VNCCoreLogging.InfrastructureLow;
            ceArch115C.IsChecked = Common.VNCCoreLogging.PersistenceLow;
            ceArch116C.IsChecked = Common.VNCCoreLogging.PresentationLow;
            ceArch117C.IsChecked = Common.VNCCoreLogging.ViewLow;
            ceArch118C.IsChecked = Common.VNCCoreLogging.ViewModelLow;
            //ceArch119C.IsChecked = Common.VNCCoreLogging.Arch119;

            ceINPC.IsChecked = Common.VNCCoreLogging.INPC;

            if (Common.VNCCoreLogging.EventHandler) Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY, startTicks);
        }

        private void ceEnabled_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Common.VNCCoreLogging.Enable = (Boolean)ceEnabled.IsChecked;
        }
    }
}
