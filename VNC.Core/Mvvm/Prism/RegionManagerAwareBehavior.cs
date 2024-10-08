﻿using System;
using System.Collections.Specialized;
using System.Linq;
using System.Windows;
using Prism.Regions;

namespace VNC.Core.Mvvm.Prism
{
    public class RegionManagerAwareBehavior : RegionBehavior
    {
        // Every behavior needs a key

        public const string BehaviorKey = "RegionManagerAwareBehavior";

        protected override void OnAttach()
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCLogging.Presentation) startTicks = Log.PRESENTATION($"Enter", Common.LOG_CATEGORY);
#endif
            // Attach to all regions.  But, can also pick and choose


            if (Region.ActiveViews.Count() > 0)
            if (Common.VNCLogging.Presentation) Log.PRESENTATION($"Region.ActiveViews {Region.ActiveViews.Count()} {Region.ActiveViews.First()}", Common.LOG_CATEGORY);

            Region.ActiveViews.CollectionChanged += ActiveViews_CollectionChanged;

#if LOGGING
            if (Common.VNCLogging.Presentation) Log.PRESENTATION($"Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        void ActiveViews_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCLogging.Presentation) startTicks = Log.PRESENTATION($"Enter", Common.LOG_CATEGORY);
#endif
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (var item in e.NewItems)
                {
                    if (Common.VNCLogging.Presentation) startTicks = Log.PRESENTATION($"{item.GetType()}", Common.LOG_CATEGORY);

                    IRegionManager regionManager = Region.RegionManager;

                    FrameworkElement element = item as FrameworkElement;

                    if (element != null)
                    {
                        IRegionManager scopedRegionManager =
                            element.GetValue(RegionManager.RegionManagerProperty) as IRegionManager;

                        if (scopedRegionManager != null)
                        {
                            regionManager = scopedRegionManager;
                        }
                    }

                    InvokeOnRegionManagerAwareElement(item, x => x.RegionManager = regionManager);
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (var item in e.OldItems)
                {
                    if (Common.VNCLogging.Presentation) startTicks = Log.PRESENTATION($"{item.GetType()}", Common.LOG_CATEGORY);

                    InvokeOnRegionManagerAwareElement(item, x => x.RegionManager = null);
                }
            }

#if LOGGING
            if (Common.VNCLogging.Presentation) Log.PRESENTATION($"Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        static void InvokeOnRegionManagerAwareElement(object item, Action<IRegionManagerAware> invocation)
        {
#if LOGGING
            Int64 startTicks = 0;
            if (Common.VNCLogging.Presentation) startTicks = Log.PRESENTATION($"Enter {item.GetType()}", Common.LOG_CATEGORY);
#endif

            // Want to support View and/or ViewModel first approaches

            // ViewModel first approach

            // Check if supports IRegionManagerAware

            var rmAwareItem = item as IRegionManagerAware;

            if (rmAwareItem != null)
            {
                if (Common.VNCLogging.Presentation) startTicks = Log.PRESENTATION($"VM rmAware", Common.LOG_CATEGORY);

                invocation(rmAwareItem);
            }

            // View first approach

            // If we get a View it will be a FrameworkElement in WPF

            var frameworkElement = item as FrameworkElement;

            if (frameworkElement != null)
            {
                IRegionManagerAware rmAwareDataContext = frameworkElement.DataContext as IRegionManagerAware;

                if (rmAwareDataContext != null)
                {
                    var frameworkElementParent = frameworkElement.Parent as FrameworkElement;

                    // If a view does not have a DataContext, i.e. a ViewModel,
                    // it will inherit DataContext of parent view
                    // Avoid setting RegionManager of parent view

                    if (frameworkElementParent != null)
                    {
                        var rmAwareDataContextParent = frameworkElementParent.DataContext as IRegionManagerAware;

                        if (rmAwareDataContextParent != null)
                        {
                            if (rmAwareDataContext == rmAwareDataContextParent)
                            {
                                // This View doesn't have a ViewModel.  
                                // It is using ViewModel of Visible parent.  Do not set.

                                return;
                            }
                        }
                    }

                    if (Common.VNCLogging.Presentation) startTicks = Log.PRESENTATION($"V rmAwareDataContext", Common.LOG_CATEGORY);

                    invocation(rmAwareDataContext);
                }
            }
#if LOGGING
            if (Common.VNCLogging.Presentation) Log.PRESENTATION($"Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }
    }
}
