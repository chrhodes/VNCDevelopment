using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

using DevExpress.Xpf.Core;

using Prism.Commands;
using Prism.Events;
using Prism.Services.Dialogs;

using VNC.Core.Presentation;
using VNC.Core.Events;

namespace VNC.WPF.Presentation.Dx.Views
{
    public partial class DxWindowHost : DXWindow, INotifyPropertyChanged
    {
        #region Constructors, Initialization, and Load

        public readonly IEventAggregator? EventAggregator;
        public readonly IDialogService? DialogService;

        /// <summary>
        /// No Prism EventAggregator or DialogService is supported.
        /// </summary>
        public DxWindowHost()
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);
#endif

            //EventAggregator = eventAggregator;
            //DialogService = dialogService;

            try
            {
                InitializeComponent();
                InitializeWindow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log.ERROR(ex, Common.LOG_CATEGORY);
            }

#if LOGGING
            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }
        public DxWindowHost(
            IEventAggregator eventAggregator)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);
#endif

            EventAggregator = eventAggregator;
            //DialogService = dialogService;

            try
            {
                InitializeComponent();
                InitializeWindow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log.ERROR(ex, Common.LOG_CATEGORY);
            }          

#if LOGGING
            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        // TODO: Maybe take size and position parameters
        public DxWindowHost(
            IEventAggregator eventAggregator,
            string title, 
            string userControlFullyQualifiedName)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR($"Enter {title} {userControlFullyQualifiedName}", Common.LOG_CATEGORY);
#endif
            EventAggregator = eventAggregator;
            //DialogService = dialogService;

            try
            {
                InitializeComponent();
                InitializeWindow();

                this.Title = title;

                LoadUserControl(userControlFullyQualifiedName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log.ERROR(ex, Common.LOG_CATEGORY);
            }

#if LOGGING
            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        public DxWindowHost(
            IEventAggregator eventAggregator,
            string title,
            UserControl userControl)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR($"Enter {title} {userControl.GetType()}", Common.LOG_CATEGORY);
#endif
            EventAggregator = eventAggregator;
            //DialogService = dialogService;

            try
            {
                InitializeComponent();
                InitializeWindow();

                this.Title = title;

                LoadUserControl(userControl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log.ERROR(ex, Common.LOG_CATEGORY);
            }

#if LOGGING
            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        private void InitializeWindow()
        {
            spDeveloperInfo.DataContext = this;
            this.HorizontalAlignment = HorizontalAlignment.Center;
            this.VerticalAlignment = VerticalAlignment.Center;

            EventAggregator?.GetEvent<DeveloperModeEvent>()
                .Subscribe(DeveloperMode);
        }

        #endregion

        #region Enums (none)


        #endregion

        #region Structures (none)


        #endregion

        #region Fields and Properties

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

        private string _loadTime;
        public string LoadTime
        {
            get => _loadTime;
            set
            {
                if (_loadTime == value)
                {
                    return;
                }

                _loadTime = value;
                OnPropertyChanged();
            }
        }

        private System.Windows.Size _windowSize;
        public System.Windows.Size WindowSize
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

        private void DeveloperMode(Boolean developerMode)
        {
            Int64 startTicks = 0;
            if (Common.VNCLogging.EventHandler) startTicks = Log.EVENT_HANDLER("Enter", Common.LOG_CATEGORY);

            if (developerMode)
            {
                DeveloperUIMode = Visibility.Visible;
            }
            else
            {
                DeveloperUIMode = Visibility.Collapsed;
            }

            if (Common.VNCLogging.EventHandler) Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY, startTicks);
        }

        private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.EventHandler) startTicks = Log.EVENT_HANDLER("Enter", Common.LOG_CATEGORY);
#endif

            this.Hide();
            e.Cancel = true;

#if LOGGING
            if (Common.VNCCoreLogging.EventHandler) Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }
        private void thisControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.EventHandler) startTicks = Log.EVENT_HANDLER("Enter", Common.LOG_CATEGORY);
#endif
            var newSize = e.NewSize;
            var previousSize = e.PreviousSize;
            WindowSize = newSize;
#if LOGGING
            if (Common.VNCCoreLogging.EventHandler) Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion

        #region Commands (none)

        #endregion

        #region Public Methods

        public void LoadUserControl(string userControlName)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Presentation) startTicks = Log.PRESENTATION("Enter", Common.LOG_CATEGORY);
#endif

            Type ucType = Type.GetType(userControlName);

            try
            {
                var uc = Activator.CreateInstance(ucType);
                LoadUserControl((UserControl)uc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect Tag Name.  Cannot load type:{0}", userControlName);
                Log.ERROR(ex, Common.LOG_CATEGORY);
            }

#if LOGGING
            if (Common.VNCCoreLogging.Presentation) Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        public void LoadUserControl(UserControl control)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Presentation) startTicks = Log.PRESENTATION("Enter", Common.LOG_CATEGORY);
#endif

            //UnhookTitleEvent(_currentControl);
            g_UserControlContainer.Children.Clear();

            if (control is not null)
            {
                g_UserControlContainer.Children.Add(control);

                if (control.MinWidth > 0)
                {
                    this.Width = control.MinWidth + Common.WINDOW_HOSTING_USER_CONTROL_WIDTH_PAD;
                    this.MinWidth = this.Width;
                }

                if (control.MinHeight > 0)
                {
                    this.Height = control.MinHeight + Common.WINDOW_HOSTING_USER_CONTROL_HEIGHT_PAD;
                    this.MinHeight = this.Height;
                }
                //_currentControl = control;
            }

            //HookTitleEvent(_currentControl);

#if LOGGING
            if (Common.VNCCoreLogging.Presentation) Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        public void DisplayUserControlInHost(
            string title,
            Int32 width, Int32 height,
            ShowWindowMode mode,
            System.Windows.Controls.UserControl userControl)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Presentation) startTicks = Log.PRESENTATION("Enter", Common.LOG_CATEGORY);
#endif

            if (userControl is not null)
            {
                LoadUserControl(userControl);
            }

            DisplayHost( title, width, height, mode, startTicks);

#if LOGGING
            if (Common.VNCCoreLogging.Presentation) Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        public void DisplayUserControlInHost(
            string title,
            Int32 width, Int32 height,
            ShowWindowMode mode,
            string? userControlName = null)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Presentation) startTicks = Log.PRESENTATION("Enter", Common.LOG_CATEGORY);
#endif

            if (userControlName is not null)
            {
                LoadUserControl(userControlName);
            }

            DisplayHost(title, width, height, mode, startTicks);

#if LOGGING
            if (Common.VNCCoreLogging.Presentation) Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        public void DisplayHost(
            string title,
            Int32 width, Int32 height,
            ShowWindowMode mode,
            Int64 startTicks)
        {
#if LOGGING
            Int64 startTicks2 = 0;
            if (Common.VNCCoreLogging.Presentation) startTicks = Log.PRESENTATION("Enter", Common.LOG_CATEGORY);
#endif

            Title = title;
            Width = width;
            Height = height;

            if (mode == ShowWindowMode.Modal_ShowDialog)
            {
#if LOGGING
                Int64 endTicks2 = 0;
                if (Common.VNCCoreLogging.Presentation) endTicks2 = Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);
#endif

                LoadTime = $"{Log.GetDuration(startTicks, endTicks2)}";

                ShowDialog();
            }
            else
            {
#if LOGGING
                Int64 endTicks2 = 0;
                if (Common.VNCCoreLogging.Presentation) endTicks2 = Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);
#endif

                LoadTime = $"{Log.GetDuration(startTicks, endTicks2)}";

                Show();
            }

#if LOGGING
            long endTicks = 0;
            if (Common.VNCCoreLogging.Presentation) endTicks = Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);
#endif

            // TODO(crhodes)
            // How is this used?

            Tag = $"{GetType()} loadtime: {Log.GetDuration(startTicks, endTicks)}";

#if LOGGING
            if (Common.VNCCoreLogging.Presentation) Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks2);
#endif
        }

        #endregion

        #region Protected Methods (none)


        #endregion

        #region Private Methods (none)


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
            //#if LOGGING
            //      Int64 startTicks = 0;
            //            if (LogOnPropertyChanged)
            //            {
            //                startTicks = Log.VIEWMODEL_LOW($"Enter ({propertyName})", Common.LOG_CATEGORY);
            //            }
            //#endif
            // This is the new CompilerServices attribute!

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            //#if LOGGING
            //            if (LogOnPropertyChanged)
            //            {
            //                Log.VIEWMODEL_LOW("Exit", Common.LOG_CATEGORY, startTicks);
            //            }
            //#endif
        }

        #endregion
    }
}
