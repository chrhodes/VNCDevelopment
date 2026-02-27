using System;
using System.Linq;

using Prism.Events;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

using VNC.Core.Events;
using VNC.UIApproaches.Core;
using VNC.UIApproaches.Presentation.ViewModels;
using VNC.UIApproaches.Presentation.Views;
using VNC.WPF.Presentation.ViewModels;
using VNC.WPF.Presentation.Views;

namespace VNC.UIApproaches
{
    public class UIApproachesModule : IModule
    {
        private readonly IRegionManager _regionManager;

        // 01

        public UIApproachesModule(IEventAggregator eventAggregator, IRegionManager regionManager)
        {
            Int64 startTicks = 0;
            if (Common.VNCLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

            Common.EventAggregator = eventAggregator;
            _regionManager = regionManager;

            var regions = _regionManager.Regions;
            var rc = regions.Count();

            if (Common.VNCLogging.Constructor) Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        }

        // 02

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            Int64 startTicks = 0;
            if (Common.VNCLogging.ModuleInitialize) startTicks = Log.MODULE_INITIALIZE("Enter", Common.LOG_CATEGORY);

            var regions = _regionManager.Regions;
            var rc = regions.Count();
            
            containerRegistry.Register<IUILaunchApproachesViewModel, UILaunchApproachesViewModel>();
            containerRegistry.Register<UILaunchApproaches>();

            // NOTE(crhodes)
            // Observations on wiring Views and ViewModels

            // ------------------------------------------------------
            //
            // If only put ViewDiscoveryAndInjection in OnInitialized
            // and AutoWireViewModel=False
            //
            // ViewDiscoveryAndInjection() gets called and View is not wired to ViewModel
            //
            // ------------------------------------------------------

            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++
            //
            // If Set AutoWireViewModel=True in Xaml,
            // ViewDiscoveryAndInjection(IViewDiscoveryAndInjectionViewModel viewModel) gets called
            //
            // and View is wired to ViewModel
            //
            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // ------------------------------------------------------
            //
            // If only Register ViewDiscoveryAndInjection
            // either directly or against Interface

            //containerRegistry.Register<ViewDiscoveryAndInjection>();
            //containerRegistry.Register<IViewDiscoveryAndInjection, ViewDiscoveryAndInjection>();

            // ViewDiscoveryAndInjection() gets called
            // and View is not wired to ViewModel
            //
            // Why doesn't this work as IMain works, infra.

            // Oh, I see.
            // public ViewDiscoveryAndInjection(IViewDiscoveryAndInjectionViewModel viewModel)
            // Needs DI as the viewModel is an Interface
            //
            // ------------------------------------------------------

            // ------------------------------------------------------
            //
            // If both are registered, order doesn't matter

            //containerRegistry.Register<ViewDiscoveryAndInjection>();
            //containerRegistry.Register<ViewDiscoveryAndInjectionViewModel>();

            // ViewDiscoveryAndInjection() gets called
            // and View is not wired to ViewModel
            //
            // ------------------------------------------------------

            // ------------------------------------------------------
            //
            // If only Register ViewDiscoveryAndInjectionViewModel

            //containerRegistry.Register<ViewDiscoveryAndInjectionViewModel>();

            // ViewDiscoveryAndInjection() gets called
            // and View is not wired to ViewModel
            //
            // ------------------------------------------------------

            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++
            //
            // But, if register ViewDiscoveryAndInjectionViewModel
            // against an Interface

            containerRegistry.Register<IViewDiscoveryViewModel, ViewDiscoveryViewModel>();
            containerRegistry.Register<IViewInjectionViewModel, ViewInjectionViewModel>();
            containerRegistry.Register<IRegionNavigationViewModel, RegionNavigationViewModel>();

            // ViewDiscoveryAndInjection(IViewDiscoveryAndInjectionViewModel viewModel) gets called
            // and View is wired to ViewModel
            //
            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // Figure out how to use one Type

            //containerRegistry.Register<IFriendLookupDataService, LookupDataService>();
            //containerRegistry.Register<IProgrammingLanguageLookupDataService, LookupDataService>();
            //containerRegistry.Register<IMeetingLookupDataService, LookupDataService>();

            // These are for RegionNavigation

            containerRegistry.RegisterForNavigation(typeof(UI1), "UI1");
            // containerRegistry.RegisterForNavigation<UI2>();    // name defaults to UI2
            containerRegistry.RegisterForNavigation<UI2>("UI2");
            containerRegistry.RegisterForNavigation<UI3>("UI3");

            // NOTE(crhodes)
            // Can also (optionally) register a ViewModel with View

            containerRegistry.RegisterForNavigation<UI4, UI4ViewModel>("UI4");
            containerRegistry.RegisterForNavigation<UI5, UI5ViewModel>("UI5");

            // Since these do not have a ViewModel and only a parameterless constructor()
            // their DataContext is the parent control.  Probably don't want this

            containerRegistry.RegisterForNavigation<UI1_Beta>("UI1beta");
            containerRegistry.RegisterForNavigation<UI2_Beta>("UI2beta");
            containerRegistry.RegisterForNavigation<UI3_Beta>("UI3beta");

            // Can specify ViewModel to use

            containerRegistry.RegisterForNavigation<UI4_Beta, UI4ViewModel>("UI4beta");
            containerRegistry.RegisterForNavigation<UI5_Beta, UI5ViewModel>("UI5beta");

            containerRegistry.Register<IMultiStepProcessViewModel, MultiStepProcessViewModel>();
            containerRegistry.Register<IMultiStepProcess, MultiStepProcess>();

            // NOTE(crhodes)
            // If we don't register this, first step comes up but cannot navigate
            // Need to register against interface to get the parameterized constructor of StepX(viewModel) to be called

            containerRegistry.RegisterSingleton<IStepABCDEViewModel, StepABCDEViewModel>();
            containerRegistry.RegisterSingleton<StepABCDEViewModel>();

            ////containerRegistry.RegisterSingleton<ICatDetailMVViewModel, CatDetailMVViewModel>();
            //containerRegistry.Register<ICatDetailMVViewModel, CatDetailMVViewModel>();

            //containerRegistry.RegisterSingleton<ICatDetailMV, StepA>();

            // NOTE(crhodes)
            // Need to Register for Navigation so RequestNavigate works.

            containerRegistry.RegisterForNavigation<StepA, StepABCDEViewModel>("uistepa");
            containerRegistry.RegisterForNavigation<StepB, StepABCDEViewModel>("uistepb");
            containerRegistry.RegisterForNavigation<StepC, StepABCDEViewModel>("uistepc");
            containerRegistry.RegisterForNavigation<StepD, StepABCDEViewModel>("uistepd");
            containerRegistry.RegisterForNavigation<StepE, StepABCDEViewModel>("uistepe");       

            if (Common.VNCLogging.ModuleInitialize) Log.MODULE_INITIALIZE("Exit", Common.LOG_CATEGORY, startTicks);
        }

        // 03

        public void OnInitialized(IContainerProvider containerProvider)
        {
            Int64 startTicks = 0;
            if (Common.VNCLogging.ModuleInitialize) startTicks = Log.MODULE_INITIALIZE("Enter", Common.LOG_CATEGORY);

            var regions = _regionManager.Regions;
            var rc = regions.Count();

            // NOTE(crhodes)
            // using typeof(TYPE) calls constructor
            // using typeof(ITYPE) resolves type (see RegisterTypes)
            // but only wires ViewModel if IViewModel is used


            _regionManager.RegisterViewWithRegion(RegionNames.UILaunchApproaches, typeof(UILaunchApproaches));

            _regionManager.RegisterViewWithRegion(RegionNames.ViewInjection, typeof(ViewInjection));
            _regionManager.RegisterViewWithRegion(RegionNames.ViewDiscovery, typeof(ViewDiscovery));
            _regionManager.RegisterViewWithRegion(RegionNames.RegionNavigation, typeof(RegionNavigation));
            _regionManager.RegisterViewWithRegion(RegionNames.MultiStepProcess, typeof(MultiStepProcess));

            //var ok = _regionManager.Regions.ContainsRegionWithName(RegionNames.MultiStepProcessViewMV);

            Common.EventAggregator.GetEvent<ModuleLoadedEvent>()
                .Publish("UIApproachesModule");

            if (Common.VNCLogging.ModuleInitialize) Log.MODULE_INITIALIZE("Exit", Common.LOG_CATEGORY, startTicks);
        }
    }
}
