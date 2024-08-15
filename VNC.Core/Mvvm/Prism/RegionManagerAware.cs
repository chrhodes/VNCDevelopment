﻿using System.Windows;

using Prism.Regions;

namespace VNC.Core.Mvvm.Prism
{
    public static class RegionManagerAware
    {
        public static void SetRegionManagerAware(object viewOrViewModel, IRegionManager regionManager)
        {
            // Want to support View and/or ViewModel first approaches so
            // Perhaps this could become an extension method on RegionManager!

            // ViewModel first approach

            var viewModelIsRegionManagerAware = viewOrViewModel as IRegionManagerAware;

            // Check if supports IRegionManagerAware

            if (viewModelIsRegionManagerAware != null)
            {
                viewModelIsRegionManagerAware.RegionManager = regionManager;
            }

            // View first approach

            // If we get a View it will be a FrameworkElement in WPF

            var viewIsRegionManagerAware = viewOrViewModel as FrameworkElement;

            if (viewIsRegionManagerAware != null)
            {
                // Verify the View's DataContext implements the IRegionManagerAware interface

                var isDataContextRegionManagerAware = viewIsRegionManagerAware.DataContext as IRegionManagerAware;

                if (isDataContextRegionManagerAware != null)
                {
                    isDataContextRegionManagerAware.RegionManager = regionManager;
                }
            }
        }
    }
}
