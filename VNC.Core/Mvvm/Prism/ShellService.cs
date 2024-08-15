using System;

using Prism.Regions;

using Unity;

namespace VNC.Core.Mvvm.Prism
{
    // TODO(crhodes)
    // Maybe this should be called ViewService

    public class ShellService : IShellService
    {
        private readonly IUnityContainer _container;
        private readonly IRegionManager _regionManager;

        public ShellService(IUnityContainer container, IRegionManager regionManager)
        {
            _regionManager = regionManager;
            _container = container;
        }

        public void ShowShell()
        {
            throw new NotImplementedException();
            // NOTE(crhodes)
            // If ShellService was defined in PAEF1, we would do this

            //var shell = _container.Resolve<Shell>();

            //var scopedRegion = _regionManager.CreateRegionManager();
            //RegionManager.SetRegionManager(shell, scopedRegion);

            //shell.Show();
        }

        public void ShowShell(string uri)
        {
            // NOTE(crhodes)
            // If ShellService was defined in PAEF1, we would do this

            //var shell = _container.Resolve<Shell>();

            //var scopedRegion = _regionManager.CreateRegionManager();
            //RegionManager.SetRegionManager(shell, scopedRegion);

            // Ugh looking more problematic to do in VNC.Core
            // Don't know aobut ReigonNames

            //scopedRegion.RequestNavigate(RegionNames.ContentRegion, uri);
            //shell.Show();
        }

        public void ShowShell(object view, string regionName, string uri)
        {
            // NOTE(crhodes)
            // If ShellService was defined in PAEF1, we would do this

            //var shell = _container.Resolve<Shell>();

            //var scopedRegion = _regionManager.CreateRegionManager();
            //RegionManager.SetRegionManager(shell, scopedRegion);

            // Ugh looking more problematic to do in VNC.Core
            // Don't know aobut ReigonNames

            //scopedRegion.RequestNavigate(RegionNames.ContentRegion, uri);
            //shell.Show();
        }


    }
}
