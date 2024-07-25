using System;
using System.Windows;

namespace VNC.WPF.Presentation.Views
{
    public partial class UIFive
    {
        public UIFive()
        {
            Int64 startTicks = 0;
            if (Common.VNCLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

            InitializeComponent();

            if (Common.VNCLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public string Message { get; set; } = "UIFive";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Five Booms");
        }
    }
}
