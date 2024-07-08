using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows;

namespace VNC.Core
{
    public class Common
    {
        public static Information InformationApplication = new Information();
        public static Information InformationVNCCore = new Information();

        public const string APPNAME = "VNCCore";
        public const string LOG_CATEGORY = "VNCCore";

        public static class VNCLogging
        {
            public static Boolean Enable;

            public static Boolean Info00;
            public static Boolean Info01;
            public static Boolean Info02;
            public static Boolean Info03;
            public static Boolean Info04;

            public static Boolean Debug00;
            public static Boolean Debug01;
            public static Boolean Debug02;
            public static Boolean Debug03;
            public static Boolean Debug04;

            public static Boolean ApplicationStart;
            public static Boolean ApplicationEnd;
            public static Boolean ApplicationInitialize;

            public static Boolean Application;
            public static Boolean ApplicationServices;
            public static Boolean Domain;
            public static Boolean DomainServices;
            public static Boolean Constructor;
            public static Boolean Core;
            public static Boolean Event;
            public static Boolean EventHandler;
            public static Boolean INPC;
            public static Boolean Module;
            public static Boolean ModuleInitialize;
            public static Boolean Persistence;
            public static Boolean PersistenceLow;
            public static Boolean Infrastructure;
            public static Boolean Presentation;
            public static Boolean View;
            public static Boolean ViewLow;
            public static Boolean ViewModel;
            public static Boolean ViewModelLow;
        }

        public static class VNCCoreLogging
        {
            public static Boolean Enable;

            public static Boolean Info00;
            public static Boolean Info01;
            public static Boolean Info02;
            public static Boolean Info03;
            public static Boolean Info04;

            public static Boolean Debug00;
            public static Boolean Debug01;
            public static Boolean Debug02;
            public static Boolean Debug03;
            public static Boolean Debug04;

            public static Boolean ApplicationStart;
            public static Boolean ApplicationEnd;
            public static Boolean ApplicationInitialize;

            public static Boolean Application;
            public static Boolean ApplicationServices;
            public static Boolean Domain;
            public static Boolean DomainServices;
            public static Boolean Constructor;
            public static Boolean Core;
            public static Boolean Event;
            public static Boolean EventHandler;
            public static Boolean INPC;
            public static Boolean Module;
            public static Boolean ModuleInitialize;
            public static Boolean Persistence;
            public static Boolean PersistenceLow;
            public static Boolean Infrastructure;
            public static Boolean Presentation;
            public static Boolean View;
            public static Boolean ViewLow;
            public static Boolean ViewModel;
            public static Boolean ViewModelLow;
        }

        public static void InitializeLogging()
        {
#if DEBUG
            VNCLogging.Enable = true;

            VNCLogging.Info00 = true;
            VNCLogging.Info01 = true;
            VNCLogging.Info02 = true;
            VNCLogging.Info03 = true;
            VNCLogging.Info04 = true;

            VNCLogging.Debug00 = true;
            VNCLogging.Debug01 = true;
            VNCLogging.Debug02 = true;
            VNCLogging.Debug03 = true;
            VNCLogging.Debug04 = true;

            VNCLogging.ApplicationStart = true;
            VNCLogging.ApplicationEnd = true;
            VNCLogging.ApplicationInitialize = true;
            VNCLogging.Application = true;
            VNCLogging.ApplicationServices = true;
            VNCLogging.Domain = true;
            VNCLogging.DomainServices = true;
            VNCLogging.Constructor = true;
            VNCLogging.Core = true;
            VNCLogging.Event = true;
            VNCLogging.EventHandler = true;
            VNCLogging.INPC = true;
            VNCLogging.Module = true;
            VNCLogging.ModuleInitialize = true;
            VNCLogging.Persistence = true;
            VNCLogging.PersistenceLow = true;
            VNCLogging.Infrastructure = true;
            VNCLogging.Presentation = true;
            VNCLogging.View = true;
            VNCLogging.ViewLow = true;
            VNCLogging.ViewModel = true;
            VNCLogging.ViewModelLow = true;

            VNCCoreLogging.Enable = true;

            VNCCoreLogging.Info00 = true;
            VNCCoreLogging.Info01 = true;
            VNCCoreLogging.Info02 = true;
            VNCCoreLogging.Info03 = true;
            VNCCoreLogging.Info04 = true;
               
            VNCCoreLogging.Debug00 = true;
            VNCCoreLogging.Debug01 = true;
            VNCCoreLogging.Debug02 = true;
            VNCCoreLogging.Debug03 = true;
            VNCCoreLogging.Debug04 = true;

            VNCCoreLogging.ApplicationStart = true;
            VNCCoreLogging.ApplicationEnd = true;
            VNCCoreLogging.ApplicationInitialize = true;
            VNCCoreLogging.Application = true;
            VNCCoreLogging.ApplicationServices = true;
            VNCCoreLogging.Domain = true;
            VNCCoreLogging.DomainServices = true;
            VNCCoreLogging.Constructor = true;
            VNCCoreLogging.Core = true;
            VNCCoreLogging.Event = true;
            VNCCoreLogging.EventHandler = true;
            VNCCoreLogging.INPC = true;
            VNCCoreLogging.Module = true;
            VNCCoreLogging.ModuleInitialize = true;
            VNCCoreLogging.Persistence = true;
            VNCCoreLogging.PersistenceLow = true;
            VNCCoreLogging.Infrastructure = true;
            VNCCoreLogging.Presentation = true;
            VNCCoreLogging.View = true;
            VNCCoreLogging.ViewLow = true;
            VNCCoreLogging.ViewModel = true;
            VNCCoreLogging.ViewModelLow = true;
#else
            VNCLogging.Enable = false;

            VNCLogging.Info00 = false;
            VNCLogging.Info01 = false;
            VNCLogging.Info02 = false;
            VNCLogging.Info03 = false;
            VNCLogging.Info04 = false;
               
            VNCLogging.Debug00 = false;
            VNCLogging.Debug01 = false;
            VNCLogging.Debug02 = false;
            VNCLogging.Debug03 = false;
            VNCLogging.Debug04 = false;

            VNCLogging.ApplicationStart = false;
            VNCLogging.ApplicationEnd = false;
            VNCLogging.ApplicationInitialize = false;
            VNCLogging.Application = false;
            VNCLogging.ApplicationServices = false;
            VNCLogging.Domain = false;
            VNCLogging.DomainServices = false;
            VNCLogging.Constructor = false;
            VNCLogging.Core = false;
            VNCLogging.Event = false;
            VNCLogging.EventHandler = false;
            VNCLogging.INPC = false;
            VNCLogging.Module = false;
            VNCLogging.ModuleInitialize = false;
            VNCLogging.Persistence = false;
            VNCLogging.PersistenceLow = false;
            VNCLogging.Infrastructure = true;
            VNCLogging.Presentation = false;
            VNCLogging.View = false;
            VNCLogging.ViewLow = false;
            VNCLogging.ViewModel = false;
            VNCLogging.ViewModelLow = false;

            VNCCoreLogging.Enable = false;

            VNCCoreLogging.Info00 = false;
            VNCCoreLogging.Info01 = false;
            VNCCoreLogging.Info02 = false;
            VNCCoreLogging.Info03 = false;
            VNCCoreLogging.Info04 = false;
               
            VNCCoreLogging.Debug00 = false;
            VNCCoreLogging.Debug01 = false;
            VNCCoreLogging.Debug02 = false;
            VNCCoreLogging.Debug03 = false;
            VNCCoreLogging.Debug04 = false;

            VNCCoreLogging.ApplicationStart = false;
            VNCCoreLogging.ApplicationEnd = false;
            VNCCoreLogging.ApplicationInitialize = false;
            VNCCoreLogging.Application = false;
            VNCCoreLogging.ApplicationServices = false;
            VNCCoreLogging.Domain = false;
            VNCCoreLogging.DomainServices = false;
            VNCCoreLogging.Constructor = false;
            VNCCoreLogging.Core = false;
            VNCCoreLogging.Event = false;
            VNCCoreLogging.EventHandler = false;
            VNCCoreLogging.INPC = false;
            VNCCoreLogging.Module = false;
            VNCCoreLogging.ModuleInitialize = false;
            VNCCoreLogging.Persistence = false;
            VNCCoreLogging.PersistenceLow = false;
            VNCCoreLogging.Infrastructure = true;
            VNCCoreLogging.Presentation = false;
            VNCCoreLogging.View = false;
            VNCCoreLogging.ViewLow = false;
            VNCCoreLogging.ViewModel = false;
            VNCCoreLogging.ViewModelLow = false;
#endif
        }

        public static bool DeveloperMode { get; set; } = false;

        public static Visibility DeveloperUIMode { get; set; } = Visibility.Visible;

        private static void SetInformation(Information information, Assembly assembly, FileVersionInfo fileVersionInfo)
        {
            AssemblyName assemblyName = assembly.GetName();

            PopulateInformation(assembly, fileVersionInfo, information, assemblyName);
        }

        public static Information GetInformation(Assembly assembly, FileVersionInfo fileVersionInfo)
        {
            Information information = new Information();

            AssemblyName assemblyName = assembly.GetName();

            PopulateInformation(assembly, fileVersionInfo, information, assemblyName);

            return information;
        }

        private static void PopulateInformation(Assembly assembly, FileVersionInfo fileVersionInfo, Information information, AssemblyName assemblyName)
        {
            // Information in Assembly

            information.AssemblyInformation.Version = assemblyName.Version.ToString();
            information.AssemblyInformation.Name = assemblyName.Name;
            information.AssemblyInformation.FullName = assemblyName.FullName;

            information.AssemblyInformation.AssemblyTitle = assembly.GetCustomAttribute<AssemblyTitleAttribute>()?.Title;
            // NOTE(crhodes)
            // This does not get populated for some reason.
            //information.AssemblyInformation.AssemblyVersion = assembly.GetCustomAttribute<AssemblyVersionAttribute>()?.Version;
            information.AssemblyInformation.Company = assembly.GetCustomAttribute<AssemblyCompanyAttribute>()?.Company;
            information.AssemblyInformation.Configuration = assembly.GetCustomAttribute<AssemblyConfigurationAttribute>()?.Configuration;
            information.AssemblyInformation.Copyright = assembly.GetCustomAttribute<AssemblyCopyrightAttribute>()?.Copyright;
            information.AssemblyInformation.Description = assembly.GetCustomAttribute<AssemblyDescriptionAttribute>()?.Description;
            information.AssemblyInformation.FileVersion = assembly.GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version;
            information.AssemblyInformation.InformationalVersion = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
            information.AssemblyInformation.Product = assembly.GetCustomAttribute<AssemblyProductAttribute>()?.Product;
            // Information in FileVersionInfo
            information.FileInformation.FileVersion = fileVersionInfo.FileVersion;
            information.FileInformation.FileDescription = fileVersionInfo.FileDescription;

            information.FileInformation.ProductName = fileVersionInfo.ProductName;
            information.FileInformation.InternalName = fileVersionInfo.InternalName;
            information.FileInformation.ProductVersion = fileVersionInfo.ProductVersion;
            information.FileInformation.ProductMajorPart = fileVersionInfo.ProductMajorPart.ToString();
            information.FileInformation.ProductMinorPart = fileVersionInfo.ProductMinorPart.ToString();
            information.FileInformation.ProductBuildPart = fileVersionInfo.ProductBuildPart.ToString();
            information.FileInformation.ProductPrivatePart = fileVersionInfo.ProductPrivatePart.ToString();

            information.FileInformation.Comments = fileVersionInfo.Comments;

            information.FileInformation.IsDebug = fileVersionInfo.IsDebug;
            information.FileInformation.IsPatched = fileVersionInfo.IsPatched;
            information.FileInformation.IsPreRelease = fileVersionInfo.IsPreRelease;
            information.FileInformation.IsPrivateBuild = fileVersionInfo.IsPrivateBuild;
            information.FileInformation.IsSpecialBuild = fileVersionInfo.IsSpecialBuild;

            // Runtime Information

            information.RuntimeVersion = FileVersionInfo.GetVersionInfo(typeof(int).Assembly.Location).FileVersion;
        }

        public static void SetVersionInfoApplication(Assembly appAssembly, FileVersionInfo appFileVersionInfo)
        {
            SetInformation(InformationApplication, 
                appAssembly, 
                appFileVersionInfo);
        }

        public static void SetVersionInfoVNCCore()
        {
            SetInformation(InformationVNCCore, 
                Assembly.GetExecutingAssembly(), 
                FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location));
        }
    }
}
