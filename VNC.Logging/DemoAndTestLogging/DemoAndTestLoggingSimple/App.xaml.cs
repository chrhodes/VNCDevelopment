using System.Windows;

using VNC.Core;

namespace DemoAndTestLoggingSimple
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
#if DEBUG
            Common.InitializeLogging(debugConfig: true);
#else
            Common.InitializeLogging();
#endif
        }
    }
}
