using System;

using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

using Unity;

namespace VNC.Core.Mvvm.Prism
{
    public abstract class ModuleBase : IModule
    {
        protected IRegionManager RegionManager { get; private set; }
        protected IUnityContainer Container { get; private set; }

        public ModuleBase(IUnityContainer container, IRegionManager regionManager)
        {

            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

            Container = container;
            RegionManager = regionManager;

            if (Common.VNCCoreLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);

        }

        public void Initialize()
        {
            RegisterTypes();
            InitializeModule();
        }

        protected abstract void InitializeModule();

        protected abstract void RegisterTypes();

        // TODO(crhodes)
        // Should these be abstract or virtual

        //These are in 7 not 6.3
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.ModuleInitialize) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);



            if (Common.VNCCoreLogging.ModuleInitialize) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);


        }

        public void OnInitialized(IContainerProvider containerProvider)
        {

            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.ModuleInitialize) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);



            if (Common.VNCCoreLogging.ModuleInitialize) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);

        }
    }
}
