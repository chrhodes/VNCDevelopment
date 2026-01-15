using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

using DevExpress.Xpf.Core;

using Prism.Commands;
using Prism.Events;
using Prism.Services.Dialogs;

using VNC;
using VNC.Core.Events;
using VNC.Core.Mvvm;
using VNC.Core.Presentation;

namespace VNC.WPF.Presentation.Dx.Views
{
    /// <summary>
    /// Interaction logic for DxThemedWindowHost.xaml
    /// </summary>
    public partial class DxThemedWindowHost : ThemedWindow, INotifyPropertyChanged
    {
        #region Constructors, Initialization, and Load

        public readonly IEventAggregator EventAggregator;
        public readonly IDialogService DialogService;

        /// <summary>
        /// No Prism EventAggregator or DialogService is supported.
        /// </summary>
        public DxThemedWindowHost()
        {
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);
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
            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public DxThemedWindowHost(
            IEventAggregator eventAggregator)
        {
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);
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
            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        }

        // TODO: Maybe take size and position parameters
        public DxThemedWindowHost(
            IEventAggregator eventAggregator,
            string title,
            string userControlFullyQualifiedName)
        {
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR($"Enter {title} {userControlFullyQualifiedName}", Common.LOG_CATEGORY);
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

            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public DxThemedWindowHost(
            IEventAggregator eventAggregator,
            string title,
            UserControl userControl)
        {
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR($"Enter {title} {userControl.GetType()}", Common.LOG_CATEGORY);
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

            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        }

        private void InitializeWindow()
        {
            spDeveloperInfo.DataContext = this;
            this.HorizontalAlignment = HorizontalAlignment.Center;
            this.VerticalAlignment = VerticalAlignment.Center;

            EventAggregator.GetEvent<DeveloperModeEvent>()
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
            if (Common.VNCCoreLogging.EventHandler) startTicks = Log.EVENT_HANDLER("Enter", Common.LOG_CATEGORY);

            if (developerMode)
            {
                DeveloperUIMode = Visibility.Visible;
            }
            else
            {
                DeveloperUIMode = Visibility.Collapsed;
            }

            if (Common.VNCCoreLogging.EventHandler) Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY, startTicks);
        }

        private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.EventHandler) startTicks = Log.EVENT_HANDLER("Enter", Common.LOG_CATEGORY);

            this.Hide();
            e.Cancel = true;

            if (Common.VNCCoreLogging.EventHandler) Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY, startTicks);
        }

        private void thisControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.EventHandler) startTicks = Log.EVENT_HANDLER("Enter", Common.LOG_CATEGORY);
            var newSize = e.NewSize;
            var previousSize = e.PreviousSize;

            // HACK(crhodes)
            // Learn how to get runtime value

            newSize.Height -= 55; // Adjust for DeveloperUIInfo control height

            WindowSize = newSize;

            if (Common.VNCCoreLogging.EventHandler) Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY, startTicks);
        }

        #endregion

        #region Commands (none)

        #endregion

        #region Public Methods

        public void LoadUserControl(string userControlName)
        {
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Presentation) startTicks = Log.PRESENTATION("Enter", Common.LOG_CATEGORY);

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

            if (Common.VNCCoreLogging.Presentation) Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public void LoadUserControl(UserControl control)
        {
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Presentation) startTicks = Log.PRESENTATION("Enter", Common.LOG_CATEGORY);

            //UnhookTitleEvent(_currentControl);
            g_UserControlContainer.Children.Clear();

            if (control != null)
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
            if (Common.VNCCoreLogging.Presentation) Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public void DisplayUserControlInHost(
            string title,
            Int32 width, Int32 height,
            ShowWindowMode mode,
            UserControl userControl)
        {
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Presentation) startTicks = Log.PRESENTATION("Enter", Common.LOG_CATEGORY);

            if (userControl is not null)
            {
                LoadUserControl(userControl);
            }

            DisplayHost(title, width, height, mode, startTicks);

            if (Common.VNCCoreLogging.Presentation) Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public void DisplayUserControlInHost(
            string title,
            Int32 width, Int32 height,
            ShowWindowMode mode,
            string userControlName = null)
        {
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Presentation) startTicks = Log.PRESENTATION("Enter", Common.LOG_CATEGORY);

            if (userControlName is not null)
            {
                LoadUserControl(userControlName);
            }

            DisplayHost(title, width, height, mode, startTicks);

            if (Common.VNCCoreLogging.Presentation) Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public void DisplayUserControlInHost(
            string title,
            Int32 width, Int32 height,
            ShowWindowMode mode,
            ViewModelBase viewModel)
        {
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Presentation) startTicks = Log.PRESENTATION("Enter", Common.LOG_CATEGORY);

            if (viewModel.View is not null)
            {
                LoadUserControl((UserControl)viewModel.View);
            }

            DisplayHost(title, width, height, mode, startTicks);

            if (Common.VNCCoreLogging.Presentation) Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public void DisplayHost(
            string title,
            Int32 width, Int32 height,
            ShowWindowMode mode,
            Int64 startTicks)
        {
            Title = title;
            Width = width;
            Height = height;

            if (mode == ShowWindowMode.Modal_ShowDialog)
            {
                Int64 endTicks2 = 0;
                if (Common.VNCCoreLogging.Presentation) endTicks2 = Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);

                LoadTime = $"{Log.GetDuration(startTicks, endTicks2)}";

                ShowDialog();
            }
            else
            {
                Int64 endTicks2 = 0;
                if (Common.VNCCoreLogging.Presentation) endTicks2 = Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);

                LoadTime = $"{Log.GetDuration(startTicks, endTicks2)}";

                Show();
            }

            long endTicks = 0;
            if (Common.VNCCoreLogging.Presentation) endTicks = Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);

            // TODO(crhodes)
            // How is this used?

            Tag = $"{GetType()} loadtime: {Log.GetDuration(startTicks, endTicks)}";
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
            // This is the new CompilerServices attribute!

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
