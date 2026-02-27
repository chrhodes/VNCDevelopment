using System.Windows.Controls;

using Prism.Regions;

using VNC.Core.Mvvm.Prism;

namespace VNC.UIApproaches.Presentation.Views
{
    public partial class ViewA : UserControl, IRegionManagerAware
    {
        public ViewA()
        {
            InitializeComponent();
        }

        public IRegionManager RegionManager { get; set; }
    }
}
