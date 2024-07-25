using System;
using System.Windows;

namespace VNC.WPF.Presentation.Views
{
    public partial class UITwo_Beta
    {
        public UITwo_Beta()
        {
            Int64 startTicks = 0;
            if (Common.VNCLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

            InitializeComponent();

            if (Common.VNCLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public string Message { get; set; } = "UITwo Beta";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zoom Two");
        }
    }
}
