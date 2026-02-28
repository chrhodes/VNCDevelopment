using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Annotations;

using CommonServiceLocator;

using Prism.Common;
using Prism.Ioc;
using Prism.Ioc.Internals;
using Prism.Regions;

namespace VNC.Core.Mvvm.Prism
{
    /// <summary>
    /// Implementation of <see cref="IRegionNavigationContentLoader"/> 
    /// that relies on a <see cref="IContainerProvider"/>
    /// to create new views when necessary.
    /// </summary>
    public class ScopedRegionNavigationContentLoaderP8 : IRegionNavigationContentLoader
    {
        private readonly IContainerExtension _container;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionNavigationContentLoader"/> class with a service locator.
        /// </summary>
        /// <param name="container">The <see cref="IContainerExtension" />.</param>
        public ScopedRegionNavigationContentLoaderP8(IContainerExtension container)
        {
            Int64 startTicks = 0;
            if (Common.VNCCoreLogging.Constructor) startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

            _container = container;
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

            if (region == null)
                throw new ArgumentNullException(nameof(region));

            if (navigationContext == null)
                throw new ArgumentNullException(nameof(navigationContext));

            string candidateTargetContract = GetContractFromNavigationContext(navigationContext);

            if (Common.VNCLogging.Presentation) startTicks = Log.PRESENTATION($"" +
                $"region >{region}< candidateTargetContract >{candidateTargetContract}<", Common.LOG_CATEGORY);

            var candidates = GetCandidatesFromRegion(region, candidateTargetContract);

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
                view = CreateNewRegionItem(candidateTargetContract);

                if (view != null)
                {
                    AddViewToRegion(region, view);
                }
                else
                {
                    Log.ERROR($"Cannot create view from >{candidateTargetContract}<", Common.LOG_ERROR);
                }
            }

            if (Common.VNCLogging.Presentation) startTicks = Log.PRESENTATION($"Exit view >{view.GetType()}<", Common.LOG_CATEGORY);

            return view;
        }

        /// <summary>
        /// Adds the view to the region.
        /// </summary>
        /// <param name="region">The region to add the view to</param>
        /// <param name="view">The view to add to the region</param>
        protected virtual void AddViewToRegion(IRegion region, object view)
        {
            Int64 startTicks = 0;
            if (Common.VNCLogging.Presentation) startTicks = Log.PRESENTATION($"Enter region >{region.Name}< view >{view.GetType()}<", Common.LOG_CATEGORY);

            //region.Add(view);
            // NOTE(crhodes)
            // This is new

            try
            {
                region.Add(view, null, CreateRegionManagerScope(view));
            }
            catch (Exception ex)
            {
                Log.ERROR(ex, Common.LOG_ERROR);
            }            

            if (Common.VNCLogging.Presentation) Log.PRESENTATION("Exit", Common.LOG_CATEGORY);
        }

        // NOTE(crhodes)
        // This is new
        private Boolean CreateRegionManagerScope(object view)
        {
            Int64 startTicks = 0;
            if (Common.VNCLogging.Presentation) startTicks = Log.PRESENTATION($"Enter view >{view.GetType()}<", Common.LOG_CATEGORY);

            Boolean createRegionManagerScope = false;

            var viewHasScopedRegions = view as ICreateRegionManagerScope;

            // TODO(crhodes)
            // This could get fancier and check more than just view
            // ViewModel, FrameworkElement, Parent
            // This leaves the onus on the View itself

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
                newRegionItem = _container.Resolve<object>(candidateTargetContract);
            }
            catch (ActivationException e)
            {
                throw new InvalidOperationException(
                    string.Format(CultureInfo.CurrentCulture, "Cannot create navigation target", candidateTargetContract),
                    e);
            }

            // NOTE(crhodes)
            // This was in Prism Code for RegionNavigationContentLoader
            //MvvmHelpers.AutowireViewModel(newRegionItem);

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

            if (navigationContext == null) throw new ArgumentNullException(nameof(navigationContext));

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

            var contractCandidates = GetCandidatesFromRegionViews(region, candidateNavigationContract);

            if (!contractCandidates.Any())
            {
                var matchingType = _container.GetRegistrationType(candidateNavigationContract);
                if (matchingType is null)
                {
                    return Array.Empty<object>();
                }

                return GetCandidatesFromRegionViews(region, matchingType.FullName);
            }

            return contractCandidates;
        }

        private IEnumerable<object> GetCandidatesFromRegionViews(IRegion region, string candidateNavigationContract)
        {
            Int64 startTicks = 0;
            if (Common.VNCLogging.Presentation) startTicks = Log.PRESENTATION(
                $"Enter region >{region.Name}< candidateNavigationContract >{candidateNavigationContract.GetType()}<", Common.LOG_CATEGORY);

            var candidates =  region.Views.Where(v => ViewIsMatch(v.GetType(), candidateNavigationContract));

            if (Common.VNCLogging.Presentation) Log.PRESENTATION($"Exit candidates >{candidates.Count()}<", Common.LOG_CATEGORY);

            return candidates;
        }

        private static Boolean ViewIsMatch(Type viewType, string navigationSegment)
        {
            Int64 startTicks = 0;
            if (Common.VNCLogging.Presentation) startTicks = Log.PRESENTATION(
                $"Enter viewType >{viewType.Name}< navigationSegment >{navigationSegment}<", Common.LOG_CATEGORY);

            var names = new[] { viewType.Name, viewType.FullName };

            Boolean isMatch = names.Any(x => x.Equals(navigationSegment, StringComparison.Ordinal));

            if (Common.VNCLogging.Presentation) Log.PRESENTATION(
                 $"Exit isMatch >{isMatch}<", Common.LOG_CATEGORY);

            return isMatch;
        }
    }
}
