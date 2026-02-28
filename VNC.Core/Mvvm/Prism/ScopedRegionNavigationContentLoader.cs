using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;

using CommonServiceLocator;

using Prism.Common;
using Prism.Regions;

namespace VNC.Core.Mvvm.Prism
{
    /// <summary>
    /// This is from MasterTabControl and (maybe) V5
    /// </summary>
    public class ScopedRegionNavigationContentLoader : IRegionNavigationContentLoader
    {
        private readonly IServiceLocator _serviceLocator;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionNavigationContentLoader"/> class with a service locator.
        /// </summary>
        /// <param name="serviceLocator">The service locator.</param>
        public ScopedRegionNavigationContentLoader(IServiceLocator serviceLocator)
        {
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

            this._serviceLocator = serviceLocator;
        }

        /// <summary>
        /// Gets the view to which the navigation request represented by <paramref name="navigationContext"/> applies.
        /// </summary>
        /// <param name="region">The region.</param>
        /// <param name="navigationContext">The context representing the navigation request.</param>
        /// <returns>
        /// The view to be the target of the navigation request.
        /// </returns>
        /// <remarks>
        /// If none of the views in the region can be the target of the navigation request, a new view
        /// is created and added to the region.
        /// </remarks>
        /// <exception cref="ArgumentException">when a new view cannot be created for the navigation request.</exception>
        public object LoadContent(IRegion region, NavigationContext navigationContext)
        {
            Int64 startTicks = 0;
            if (Common.VNCLogging.Presentation) startTicks = Log.PRESENTATION($"Enter " +
                $"region >{region.Name}< navigationContext >{navigationContext.Uri}<", Common.LOG_CATEGORY);

            if (region == null) throw new ArgumentNullException("region");
            if (navigationContext == null) throw new ArgumentNullException("navigationContext");

            string candidateTargetContract = this.GetContractFromNavigationContext(navigationContext);

            if (Common.VNCLogging.Presentation) startTicks = Log.PRESENTATION($"" +
                $"region >{region}< candidateTargetContract >{candidateTargetContract}<", Common.LOG_CATEGORY);

            var candidates = this.GetCandidatesFromRegion(region, candidateTargetContract);

            var acceptingCandidates =
                candidates.Where(
                    v =>
                    {
                        var navigationAware = v as INavigationAware;
                        if (navigationAware != null && !navigationAware.IsNavigationTarget(navigationContext))
                        {
                            return false;
                        }

                        var frameworkElement = v as FrameworkElement;
                        if (frameworkElement == null)
                        {
                            return true;
                        }

                        navigationAware = frameworkElement.DataContext as INavigationAware;
                        return navigationAware == null || navigationAware.IsNavigationTarget(navigationContext);
                    });


            var view = acceptingCandidates.FirstOrDefault();

            if (view == null)
            {
                view = this.CreateNewRegionItem(candidateTargetContract);

                region.Add(view, null, CreateRegionManagerScope(view));
            }

            if (Common.VNCLogging.Presentation) startTicks = Log.PRESENTATION($"Exit view >{view.GetType()}<", Common.LOG_CATEGORY);

            return view;
        }

        private Boolean CreateRegionManagerScope(object view)
        {
            Int64 startTicks = 0;
            if (Common.VNCLogging.Presentation) startTicks = Log.PRESENTATION("$Enter view >{view.GetType()}<", Common.LOG_CATEGORY);

            Boolean createRegionManagerScope = false;

            var viewHasScopedRegions = view as ICreateRegionManagerScope;
            if (viewHasScopedRegions != null)
                createRegionManagerScope = viewHasScopedRegions.CreateRegionManagerScope;

            if (Common.VNCLogging.Presentation) Log.PRESENTATION($"Exit createRegionManagerScope >{createRegionManagerScope}<", Common.LOG_CATEGORY);

            return createRegionManagerScope;
        }

        /// <summary>
        /// Provides a new item for the region based on the supplied candidate target contract name.
        /// </summary>
        /// <param name="candidateTargetContract">The target contract to build.</param>
        /// <returns>An instance of an item to put into the <see cref="IRegion"/>.</returns>
        protected virtual object CreateNewRegionItem(string candidateTargetContract)
        {
            Int64 startTicks = 0;
            if (Common.VNCLogging.Presentation) startTicks = Log.PRESENTATION($"Enter candidateTargetContract >{candidateTargetContract}<", Common.LOG_CATEGORY);

            object newRegionItem;

            try
            {
                newRegionItem = this._serviceLocator.GetInstance<object>(candidateTargetContract);
            }
            catch (ActivationException e)
            {
                throw new InvalidOperationException(
                    string.Format(CultureInfo.CurrentCulture, "Cannot create navigation target", candidateTargetContract),
                    e);
            }

            if (Common.VNCLogging.Presentation) startTicks = Log.PRESENTATION($"Exit newRegionItem >{newRegionItem.GetType()}<", Common.LOG_CATEGORY);

            return newRegionItem;
        }

        /// <summary>
        /// Returns the candidate TargetContract based on the <see cref="NavigationContext"/>.
        /// </summary>
        /// <param name="navigationContext">The navigation contract.</param>
        /// <returns>The candidate contract to seek within the <see cref="IRegion"/> and to use, if not found, when resolving from the container.</returns>
        protected virtual string GetContractFromNavigationContext(NavigationContext navigationContext)
        {
            Int64 startTicks = 0;
            if (Common.VNCLogging.Presentation) startTicks = Log.PRESENTATION(
                $"Enter navigationContext.Uri >{navigationContext.Uri}<", Common.LOG_CATEGORY);

            if (navigationContext == null) throw new ArgumentNullException("navigationContext");

            var candidateTargetContract = UriParsingHelper.GetAbsolutePath(navigationContext.Uri);
            candidateTargetContract = candidateTargetContract.TrimStart('/');

            if (Common.VNCLogging.Presentation) Log.PRESENTATION($"Exit candidateTargetContract >{candidateTargetContract}<", Common.LOG_CATEGORY);

            return candidateTargetContract;
        }

        /// <summary>
        /// Returns the set of candidates that may satisfy this navigation request.
        /// </summary>
        /// <param name="region">The region containing items that may satisfy the navigation request.</param>
        /// <param name="candidateNavigationContract">The candidate navigation target as determined by <see cref="GetContractFromNavigationContext"/></param>
        /// <returns>An enumerable of candidate objects from the <see cref="IRegion"/></returns>
        protected virtual IEnumerable<object> GetCandidatesFromRegion(IRegion region, string candidateNavigationContract)
        {
            Int64 startTicks = 0;
            if (Common.VNCLogging.Presentation) startTicks = Log.PRESENTATION(
                $"Enter region " +
                $">{region.Name}< candidateNavigationContract >{candidateNavigationContract.GetType()}<", Common.LOG_CATEGORY);

            if (region is null)
            {
                throw new ArgumentNullException(nameof(region));
            }

            if (string.IsNullOrEmpty(candidateNavigationContract))
            {
                throw new ArgumentNullException(nameof(candidateNavigationContract));
            }

            var candidates = region.Views.Where(v =>
                string.Equals(v.GetType().Name, candidateNavigationContract, StringComparison.Ordinal) ||
                string.Equals(v.GetType().FullName, candidateNavigationContract, StringComparison.Ordinal));

            if (Common.VNCLogging.Presentation) Log.PRESENTATION($"Exit candidates >{candidates.Count()}<", Common.LOG_CATEGORY);

            return candidates;
        }
    }
}
