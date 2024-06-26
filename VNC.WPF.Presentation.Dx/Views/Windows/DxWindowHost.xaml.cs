﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

using DevExpress.Xpf.Core;

using VNC.Core.Presentation;

namespace VNC.WPF.Presentation.Dx.Views
{

    public partial class DxWindowHost : DXWindow, INotifyPropertyChanged
    {

        #region Constructors, Initialization, and Load
        
        public DxWindowHost()
        {
            long startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

            InitializeComponent();

            this.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            this.VerticalAlignment = System.Windows.VerticalAlignment.Center;

            spSizeInfo.DataContext = this;

            Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        }

        // TODO: Maybe take size and position parameters
        public DxWindowHost(string title, string userControlFullyQualifiedName)
        {
            long startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

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

            Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        }

        #endregion

        #region Enums (None)


        #endregion

        #region Structures (None)


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
            long startTicks = Log.EVENT_HANDLER("Enter", Common.LOG_CATEGORY);

            this.Hide();
            e.Cancel = true;

            Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY, startTicks);
        }

        private void thisControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var newSize = e.NewSize;
            var previousSize = e.PreviousSize;
            WindowSize = newSize;
        }

        #endregion

        #region Commands (None)

        #endregion

        #region Public Methods

        public void LoadUserControl(string userControlName)
        {
            long startTicks = Log.PRESENTATION("Enter", Common.LOG_CATEGORY);

            Type ucType = Type.GetType(userControlName);

            try
            {
                var uc = Activator.CreateInstance(ucType);
                LoadUserControl((UserControl)uc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect Tag Name.  Cannot load type:{0}", userControlName);
            }

            Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public void LoadUserControl(UserControl control)
        {
            long startTicks = Log.PRESENTATION("Enter", Common.LOG_CATEGORY);

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

            Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public void DisplayUserControlInHost(

            string title,
            int width, int height,
            ShowWindowMode mode,
            System.Windows.Controls.UserControl userControl)
        {
            long startTicks = Log.PRESENTATION("Enter", Common.LOG_CATEGORY);

            if (!(userControl is null))
            {
                LoadUserControl(userControl);
            }

            DisplayHost( title, width, height, mode, startTicks);

            Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public void DisplayUserControlInHost(
            string title,
            int width, int height,
            ShowWindowMode mode,
            string userControlName = null)
        {
            long startTicks = Log.PRESENTATION("Enter", Common.LOG_CATEGORY);

            if (!(userControlName is null))
            {
                LoadUserControl(userControlName);
            }

            DisplayHost(title, width, height, mode, startTicks);

            Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public void DisplayHost(
            string title,
            int width, int height,
            ShowWindowMode mode,
            long startTicks2)
        {
            long startTicks = Log.PRESENTATION("Enter", Common.LOG_CATEGORY);

            Title = title;
            Width = width;
            Height = height;

            if (mode == ShowWindowMode.Modal_ShowDialog)
            {
                long endTicks2 = Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks2);

                LoadTime = $"{Log.GetDuration(startTicks, endTicks2)}";

                ShowDialog();
            }
            else
            {
                long endTicks2 = Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks2);

                LoadTime = $"{Log.GetDuration(startTicks, endTicks2)}";

                Show();
            }

            long endTicks = Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks2);

            Tag = $"{GetType()} loadtime: {Log.GetDuration(startTicks2, endTicks)}";

            Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);
        }

        #endregion

        #region Protected Methods (None)


        #endregion

        #region Private Methods (None)


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

            long startTicks = 0;
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
