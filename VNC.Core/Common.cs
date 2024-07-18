using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Policy;
using System.Text.Json;
using System.Windows;
using System.Windows.Media;

namespace VNC.Core
{
    public class Common
    {
        public static Information InformationApplication = new Information();
        public static Information InformationVNCCore = new Information();

        public const string APPNAME = "VNCCore";
        public const string LOG_CATEGORY = "VNCCore";

        public static VNCLoggingConfig VNCLogging = new VNCLoggingConfig();
        public static VNCLoggingConfig VNCCoreLogging = new VNCLoggingConfig();

        //public static class VNCLogging
        //{
        //    public static Boolean Enable;

        //    public static Boolean Info00;
        //    public static Boolean Info01;
        //    public static Boolean Info02;
        //    public static Boolean Info03;
        //    public static Boolean Info04;

        //    public static Boolean Debug00;
        //    public static Boolean Debug01;
        //    public static Boolean Debug02;
        //    public static Boolean Debug03;
        //    public static Boolean Debug04;

        //    public static Boolean ApplicationStart;
        //    public static Boolean ApplicationEnd;
        //    public static Boolean ApplicationInitialize;

        //    public static Boolean Application;
        //    public static Boolean ApplicationServices;
        //    public static Boolean Domain;
        //    public static Boolean DomainServices;
        //    public static Boolean Constructor;
        //    public static Boolean Core;
        //    public static Boolean Event;
        //    public static Boolean EventHandler;
        //    public static Boolean INPC;
        //    public static Boolean Module;
        //    public static Boolean ModuleInitialize;
        //    public static Boolean Persistence;
        //    public static Boolean PersistenceLow;
        //    public static Boolean Infrastructure;
        //    public static Boolean Presentation;
        //    public static Boolean View;
        //    public static Boolean ViewLow;
        //    public static Boolean ViewModel;
        //    public static Boolean ViewModelLow;
        //}

        //public static class VNCCoreLogging
        //{
        //    public static Boolean Enable;

        //    public static Boolean Info00;
        //    public static Boolean Info01;
        //    public static Boolean Info02;
        //    public static Boolean Info03;
        //    public static Boolean Info04;

        //    public static Boolean Debug00;
        //    public static Boolean Debug01;
        //    public static Boolean Debug02;
        //    public static Boolean Debug03;
        //    public static Boolean Debug04;

        //    public static Boolean ApplicationStart;
        //    public static Boolean ApplicationEnd;
        //    public static Boolean ApplicationInitialize;

        //    public static Boolean Application;
        //    public static Boolean ApplicationServices;
        //    public static Boolean Domain;
        //    public static Boolean DomainServices;
        //    public static Boolean Constructor;
        //    public static Boolean Core;
        //    public static Boolean Event;
        //    public static Boolean EventHandler;
        //    public static Boolean INPC;
        //    public static Boolean Module;
        //    public static Boolean ModuleInitialize;
        //    public static Boolean Persistence;
        //    public static Boolean PersistenceLow;
        //    public static Boolean Infrastructure;
        //    public static Boolean Presentation;
        //    public static Boolean View;
        //    public static Boolean ViewLow;
        //    public static Boolean ViewModel;
        //    public static Boolean ViewModelLow;
        //}

        private static VNCLoggingConfig LoadLoggingConfig(string configFile)
        {
            VNCLoggingConfig vncLogging = null;

            if (File.Exists(configFile))
            {
                try
                {
                    string jsonString = File.ReadAllText(configFile);

                    vncLogging = JsonSerializer.Deserialize<VNCLoggingConfig>
                        (jsonString, GetJsonSerializerOptions());
                }
                catch (Exception ex)
                {
                    Log.Error(ex, LOG_CATEGORY);
                }
            }

            if (vncLogging is null)
            {
                vncLogging = new VNCLoggingConfig();
#if DEBUG
                vncLogging.Enable = true;

                vncLogging.Info00 = true;
                vncLogging.Info01 = true;
                vncLogging.Info02 = true;
                vncLogging.Info03 = true;
                vncLogging.Info04 = true;

                vncLogging.Debug00 = true;
                vncLogging.Debug01 = true;
                vncLogging.Debug02 = true;
                vncLogging.Debug03 = true;
                vncLogging.Debug04 = true;

                vncLogging.ApplicationStart = true;
                vncLogging.ApplicationEnd = true;
                vncLogging.ApplicationInitialize = true;
                vncLogging.Application = true;
                vncLogging.ApplicationServices = true;
                vncLogging.Domain = true;
                vncLogging.DomainServices = true;
                vncLogging.Constructor = true;
                vncLogging.Core = true;
                vncLogging.Event = true;
                vncLogging.EventHandler = true;
                vncLogging.INPC = true;
                vncLogging.Module = true;
                vncLogging.ModuleInitialize = true;
                vncLogging.Persistence = true;
                vncLogging.PersistenceLow = true;
                vncLogging.Infrastructure = true;
                vncLogging.Presentation = true;
                vncLogging.View = true;
                vncLogging.ViewLow = true;
                vncLogging.ViewModel = true;
                vncLogging.ViewModelLow = true;
#else
                vncLogging.Enable = false;

                vncLogging.Info00 = false;
                vncLogging.Info01 = false;
                vncLogging.Info02 = false;
                vncLogging.Info03 = false;
                vncLogging.Info04 = false;
               
                vncLogging.Debug00 = false;
                vncLogging.Debug01 = false;
                vncLogging.Debug02 = false;
                vncLogging.Debug03 = false;
                vncLogging.Debug04 = false;

                vncLogging.ApplicationStart = false;
                vncLogging.ApplicationEnd = false;
                vncLogging.ApplicationInitialize = false;
                vncLogging.Application = false;
                vncLogging.ApplicationServices = false;
                vncLogging.Domain = false;
                vncLogging.DomainServices = false;
                vncLogging.Constructor = false;
                vncLogging.Core = false;
                vncLogging.Event = false;
                vncLogging.EventHandler = false;
                vncLogging.INPC = false;
                vncLogging.Module = false;
                vncLogging.ModuleInitialize = false;
                vncLogging.Persistence = false;
                vncLogging.PersistenceLow = false;
                vncLogging.Infrastructure = true;
                vncLogging.Presentation = false;
                vncLogging.View = false;
                vncLogging.ViewLow = false;
                vncLogging.ViewModel = false;
                vncLogging.ViewModelLow = false;
#endif
            }

            return vncLogging;
        }

        private static JsonSerializerOptions GetJsonSerializerOptions()
        {
            var jsonOptions = new JsonSerializerOptions
            {
                ReadCommentHandling = JsonCommentHandling.Skip,
                AllowTrailingCommas = true
            };

            return jsonOptions;
        }

        public static void InitializeLogging()
        {
#if DEBUG
            VNCLogging = LoadLoggingConfig("vncloggingconfig-debug.json");
            VNCCoreLogging = LoadLoggingConfig("vnccoreloggingconfig-debug.json");
#else
            VNCLogging = LoadLoggingConfig("vncloggingconfig.json");
            VNCCoreLogging = LoadLoggingConfig("vnccoreloggingconfig.json");
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
