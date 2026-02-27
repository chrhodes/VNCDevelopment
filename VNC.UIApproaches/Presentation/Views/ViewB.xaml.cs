using System.Windows.Controls;

using Prism.Regions;

using VNC.Core.Mvvm.Prism;

namespace VNC.UIApproaches.Presentation.Views
{
    public partial class ViewB : UserControl, IRegionManagerAware
    {
        public ViewB()
        {
            InitializeComponent();
        }

        public IRegionManager RegionManager { get; set; }
    }
}
