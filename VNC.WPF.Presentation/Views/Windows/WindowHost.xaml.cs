using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

using VNC.Core.Mvvm;
using VNC.Core.Presentation;

namespace VNC.WPF.Presentation.Views
{
    public partial class WindowHost : Window, INotifyPropertyChanged
    {
        #region Constructors, Initialization, and Load

        public WindowHost()
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);
#endif

            InitializeComponent();

            this.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            this.VerticalAlignment = System.Windows.VerticalAlignment.Center;

            spDeveloperInfo.DataContext = this;

#if LOGGING
            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        // TODO: Maybe take size and position parameters
        public WindowHost(string title, string userControlFullyQualifiedName)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR($"Enter {title} {userControlFullyQualifiedName}", Common.LOG_CATEGORY);
#endif

            try
            {
                InitializeComponent();

                this.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
                this.VerticalAlignment = System.Windows.VerticalAlignment.Center;
                this.Title = title;
                LoadUserControl(userControlFullyQualifiedName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

#if LOGGING
            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion

        #region Enums (none)


        #endregion

        #region Structures (none)


        #endregion

        #region Fields and Properties

        private Visibility _developerUIMode = Visibility.Collapsed;
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
                MessageBox.Show($"Incorrect Tag Name.  Cannot load type:{userControlName} Exception: {ex}");
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
#if LOGGING
            if (Common.VNCCoreLogging.Presentation) Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        public void DisplayUserControlInHost(
            string title,
            int width, int height,
            ShowWindowMode mode,
            UserControl userControl)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Presentation) startTicks = Log.PRESENTATION("Enter", Common.LOG_CATEGORY);
#endif

            //if (host is null)
            //{
            //    host = new WindowHost();

            if (!(userControl is null))
                {
                    LoadUserControl(userControl);
                }
            //}

            DisplayHost(title, width, height, mode, startTicks);
#if LOGGING
            if (Common.VNCCoreLogging.Presentation) Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        public void DisplayUserControlInHost(
            string title,
            int width, int height,
            ShowWindowMode mode,
            string userControlName = null)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Presentation) startTicks = Log.PRESENTATION("Enter", Common.LOG_CATEGORY);
#endif

            //if (host is null)
            //{
            //    host = new WindowHost();

            if (!(userControlName is null))
                {
                    LoadUserControl(userControlName);
                }
            //}

            DisplayHost(title, width, height, mode, startTicks);
#if LOGGING
            if (Common.VNCCoreLogging.Presentation) Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        public void DisplayUserControlInHost(
            string title,
            int width, int height,
            ShowWindowMode mode,
            ViewModelBase viewModel)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Presentation) startTicks = Log.PRESENTATION("Enter", Common.LOG_CATEGORY);
#endif

            if (!(viewModel.View is null))
            {
                LoadUserControl((UserControl)viewModel.View);
            }

            DisplayHost(title, width, height, mode, startTicks);

#if LOGGING
            if (Common.VNCCoreLogging.Presentation) Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        public void DisplayHost(
            string title,
            int width, int height,
            ShowWindowMode mode,
            Int64 startTicks)
        {
            Title = title;
            Width = width;
            Height = height;

            // TODO(crhodes)
            // Figure out how to handle logging #if #endif

            if (mode == ShowWindowMode.Modal_ShowDialog)
            {
                Int64 endTicks2 = 0;
                if (Common.VNCCoreLogging.Presentation) endTicks2 = Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);

                //host.Title = $"{host.Title} loadtime: {Log.GetDuration(startTicks, endTicks2)}";

                LoadTime = $"{Log.GetDuration(startTicks, endTicks2)}";

                ShowDialog();
            }
            else
            {
                Int64 endTicks2 = 0;
                if (Common.VNCCoreLogging.Presentation) endTicks2 = Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);

                //host.Title = $"{host.Title} loadtime: {Log.GetDuration(startTicks, endTicks2)}";

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

            Int64 startTicks = 0;
//#if LOGGING
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
