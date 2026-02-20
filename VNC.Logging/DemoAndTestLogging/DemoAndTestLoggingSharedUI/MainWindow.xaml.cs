using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows;

using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging.Configuration;

//using Microsoft.Practices.EnterpriseLibrary.Data;

using VNC;
using VNC.Logging.TraceListeners;

namespace DemoAndTestLoggingSharedUI
{
    public partial class MainWindow : Window
    {
        const string LOG_APPNAME = "DemoAndTestLogging";

        #region Constructors, Initialization, and Load

        public MainWindow()
        {
            InitializeComponent();
        }

        #endregion

        #region Enums (None)


        #endregion

        #region Structures (None)


        #endregion

        #region Fields and Properties (None)


        #endregion

        #region Event Handlers

        private void btnLearnSomething(object sender, RoutedEventArgs e)
        {
            //Learn1();
            //Learn2A();
            //Learn2();
            //Learn3();
            Learn4();
        }

        private void btnLogSomething(object sender, RoutedEventArgs e)
        {
            long startTicks;

            // NOTE(crhodes)
            // If don't delay a bit here, the SignalR logging infrastructure does not initialize quickly enough
            // and the first few log messages are missed.
            // This only seems to be an issue in NET481.  Do so more checking
            // NB.  All are properly recored in the log file.

            startTicks = Log.INFO("SignalR Delay", LOG_APPNAME);
#if NET481
            Thread.Sleep(250);
#else
            //Thread.Sleep(125);
#endif

            startTicks = Log.INFO("Good Everything", LOG_APPNAME, startTicks);
            startTicks = Log.EVENT_HANDLER("High Five", LOG_APPNAME, startTicks);

            startTicks = Log.DEBUG("Start", LOG_APPNAME);

            Thread.Sleep(750);

            startTicks = Log.TRACE("UnknownCategory", "Unknown", startTicks);
            startTicks = Log.TRACE1("VNCCore", "VNCCore", startTicks);
            Log.WARNING("WARNING", "ERRORS");
            Log.ERROR("ERROR", "ERRORS");

            Log.TRACE2("End", LOG_APPNAME, startTicks);       
        }

        private void btnListCategorySources(object sender, RoutedEventArgs e)
        {
            // Load the configuration source
            IConfigurationSource config = ConfigurationSourceFactory.Create();

            Log.INFO("CategorySources(TraceSources)", LOG_APPNAME, 0);

            foreach (TraceSourceData categorySource in GetAllCategorySources(config))
            {
                Log.INFO($" - {categorySource.Name}", LOG_APPNAME);

                DisplayListeners(categorySource.TraceListeners);
            }
        }

        private void btnListFilters(object sender, RoutedEventArgs e)
        {
            // Load the configuration source
            IConfigurationSource config = ConfigurationSourceFactory.Create();

            //// Get the logging settings from the configuration
            //LoggingSettings loggingSettings = LoggingSettings.GetLoggingSettings(config);

            //var allFilters = loggingSettings.LogFilters;
            //NameTypeConfigurationElementCollection<LogFilterData, CustomLogFilterData> allFilters2 = loggingSettings.LogFilters;

            Log.INFO("Filters", LOG_APPNAME, 0);

            foreach (CategoryFilterData filter in GetAllLogFilters(config))
            {
                Log.INFO($"Name:{filter.Name}", LOG_APPNAME);
            }
        }

        private void btnListSpecialSources(object sender, RoutedEventArgs e)
        {
            // Load the configuration source
            IConfigurationSource config = ConfigurationSourceFactory.Create();

            Log.INFO("AllEvents Listeners", LOG_APPNAME);

            DisplayListeners(GetAllSpecialSources(config).AllEventsTraceSource.TraceListeners);

            Log.INFO("NotProcessed Listeners", LOG_APPNAME);

            DisplayListeners(GetAllSpecialSources(config).NotProcessedTraceSource.TraceListeners);

            Log.INFO("Errors Listeners", LOG_APPNAME);

            DisplayListeners(GetAllSpecialSources(config).ErrorsTraceSource.TraceListeners);
        }

        private void btnListListeners(object sender, RoutedEventArgs e)
        {
            IConfigurationSource config = ConfigurationSourceFactory.Create();

            Log.INFO("TraceListeners", LOG_APPNAME, 0);

            foreach (TraceListenerData listener in GetAllListeners(config))
            {
                Log.INFO($" - {listener.Name}", LOG_APPNAME);
            }
        }

        private void btnListFormatters(object sender, RoutedEventArgs e)
        {
            // Load the configuration source
            IConfigurationSource config = ConfigurationSourceFactory.Create();

            //// Get the logging settings from the configuration
            //LoggingSettings loggingSettings = LoggingSettings.GetLoggingSettings(config);

            //var allFormatters = loggingSettings.Formatters;
            //NameTypeConfigurationElementCollection<FormatterData, CustomFormatterData> allFormatters2 = loggingSettings.Formatters;

            //var lvf = allFormatters2.Where(f => f.Name == "LiveView Formatter").FirstOrDefault();

            Log.INFO("Formatters", LOG_APPNAME, 0);

            foreach (TextFormatterData formatter in GetAllFormaters(config))
            {
                Log.INFO($"Name:{formatter.Name} Template:>{formatter.Template}<", LOG_APPNAME);
            }
        }

        private void btnAddListener(object sender, RoutedEventArgs e)
        {
            try
            {
                // NOTE(crhodes)
                // This works but the formatter is not right
#if NET481
                SignalRListener listenerToAdd = new SignalRListener();
                listenerToAdd.Name = "SignalRListener";
#else
                SignalRCoreListenerSendAsync listenerToAdd = new SignalRCoreListenerSendAsync();
                listenerToAdd.Name = "SignalRCoreListener";
#endif

                //TextFormatter formatter = new TextFormatter("{ timestamp(local: yyyy / MM / dd HH: mm:ss.fff)}|{ category}|{ priority}|{ processId}|{ threadName}|{ win32ThreadId}|{ keyvalue(Class Name)}.{ keyvalue(Method Name)}|{ keyvalue(Duration)}|{ message}");

                //listenerToAdd.Formatter = formatter;

                // Load the configuration source

                IConfigurationSource config = ConfigurationSourceFactory.Create();

                //LoggingSettings loggingSettings = LoggingSettings.GetLoggingSettings(config);

                //NameTypeConfigurationElementCollection<FormatterData, CustomFormatterData> allFormatters = loggingSettings.Formatters;

                //var srl = allTraceListeners.Where(f => f.Name == "SignalRCoreListener").FirstOrDefault();

                //var srl2 = allTraceListeners.Where(f => f.Name == "SignalRCoreListener").FirstOrDefault().BuildTraceListener(new LoggingSettings());

                //Another Try

                //// Load the configuration source
                //IConfigurationSource config = ConfigurationSourceFactory.Create();

                //LoggingSettings loggingSettings = LoggingSettings.GetLoggingSettings(config);

                //// Access the collection of all configured TraceListeners via their configuration data
                //var allTraceListeners = loggingSettings.TraceListeners;
                //NameTypeConfigurationElementCollection<FormatterData, CustomFormatterData> allFormatters2 = loggingSettings.Formatters;

                //var srl = allTraceListeners.Where(f => f.Name == "SignalRCoreListener").FirstOrDefault();

                //var srl2 = allTraceListeners.Where(f => f.Name == "SignalRCoreListener").FirstOrDefault().BuildTraceListener(new LoggingSettings());
                //var lvf = allFormatters2.Where(f => f.Name == "LiveView Formatter").FirstOrDefault();

                // NOTE(crhodes)
                // This works!!!

                var lvf = GetAllFormaters(config).Where(f => f.Name == "LiveView Formatter").FirstOrDefault();
                listenerToAdd.Formatter = lvf.BuildFormatter();

                foreach (var categorySource in GetAllCategorySources(config))
                {
                    Log.INFO($"Adding: {listenerToAdd.Name} to categorySource: {categorySource.Name}", LOG_APPNAME);

                    LogSource logSource1 = Logger.Writer.TraceSources[categorySource.Name];
                    List<TraceListener> listeners2 = (List<TraceListener>)logSource1.Listeners;

                    var existingListener = listeners2.Where(l => l.Name == listenerToAdd.Name).FirstOrDefault();

                    if (!listeners2.Any(l => l.Name == listenerToAdd.Name))
                    {
                        listeners2.Add(listenerToAdd);
                    }
                }

                //listeners1.Add(listenerToAdd);
            }
            catch (Exception ex)
            {
                Log.ERROR(ex, LOG_APPNAME);
            }

            //}

            Log.INFO("Exit", LOG_APPNAME, 0);
        }

        private void btnRemoveListener(object sender, RoutedEventArgs e)
        {
            // TODO(crhodes)
            // Need a more robust way to identify the listener to remove.  This is just for demo purposes.
            // "General" is the default category for logging.  What happens if not in app.config?

            //LogSource logSource = Logger.Writer.TraceSources["DemoAndTestLogging"];

            //            if (logSource != null)
            //            {
            //                var listeners = logSource.Listeners;
            //                List<TraceListener> listeners1 = (List<TraceListener>)logSource.Listeners;

            //                 TraceListener listenerToRemove = null;
            //                foreach (TraceListener listener in listeners)
            //                {
            //                    if (listener.Name == "Rolling FlatFile TraceListener")
            //                    {
            //                        Log.INFO($"Found {listener.Name}", LOG_APPNAME);
            //                    }
            //                    else if (listener.Name == "SignalRCoreListener")
            //                    {
            //                        Log.INFO($"Found {listener.Name}", LOG_APPNAME);
            //                        listenerToRemove = listener;
            //                        // NOTE(crhodes)
            //                        // Can't remove listener from collection while enumerating it.
            //                        // Need to save it and remove after enumeration.
            //                        //listeners1.Remove(listener);
            //                    }
            //                    else
            //                    {
            //                        Log.INFO($"Unexpected listener {listener.Name}", LOG_APPNAME);
            //                    }
            //                    //this didn't stop logging'
            //                    //listener.Close();
            //                    //Log.INFO($"{listener.Name} is closed", LOG_APPNAME);
            //                    //Console.WriteLine($"Listener Name: {listener.Name}, Type: {listener.GetType().FullName}");
            //                }

            //                if (listenerToRemove is not null)
            //                {
            //                    Log.INFO($"Removing {listenerToRemove.Name}", LOG_APPNAME);
            //                    listeners1.Remove(listenerToRemove);
            //                }
            //            }

            string listenerToRemove;
#if NET481
            listenerToRemove = "SignalRListener";
#else
            listenerToRemove = "SignalRCoreListener";
#endif
            IConfigurationSource config = ConfigurationSourceFactory.Create();

            foreach (TraceSourceData categorySource in GetAllCategorySources(config))
            {
                foreach (TraceListenerReferenceData listener in categorySource.TraceListeners)
                {
                    if (listener.Name == listenerToRemove)
                    {
                        Log.INFO($"Found {listener.Name} to remove", LOG_APPNAME);

                        RemoveListener(categorySource.Name, listener.Name);
                    }
                    else
                    {
                        Log.INFO($"Found {listener.Name}", LOG_APPNAME);
                    }
                }
            }

            // TODO(crhodes)
            // Need a RemoveAllEventsTraceSourceListener,
            // RemoveNotProcessedTraceSourceListener,
            // RemoveErrorsTraceSourceListener
            // Have not figured out how to do this yet.

            //RemoveSpecialSourcesAllEventsListener(listenerToRemove);
            //RemoveSpecialSourcesNotProcessedListener(listenerToRemove);
            //RemoveSpecialSourcesErrorsListener(listenerToRemove);

            Log.INFO("Exit", LOG_APPNAME, 0);
        }

#endregion

        #region Commands (None)

        #endregion

        #region Public Methods (None)


        #endregion

        #region Protected Methods (None)


        #endregion

        #region Private Methods

        //private static void DisplayListeners(IEnumerable<TraceListener> listeners)
        //{
        //    foreach (TraceListener listener in listeners)
        //    {
        //        Log.INFO($"Found {listener.Name}", LOG_APPNAME);
        //        foreach (var attribute in listener.Attributes)
        //        {
        //            Log.INFO($"Attribute {attribute}", LOG_APPNAME);
        //        }
        //    }
        //}

        private static void DisplayListeners(NamedElementCollection<TraceListenerReferenceData> listeners)
        {
            foreach (TraceListenerReferenceData listener in listeners)
            {
                Log.INFO($"   - listener:{listener.Name}", LOG_APPNAME);
            }
        }

        #endregion

        private void RemoveListener(string traceSourceName, string listenerName)
        {
            Log.INFO($"traceSourceName:>{traceSourceName}< listenerName:>{listenerName}<", LOG_APPNAME);

            LogSource logSource = Logger.Writer.TraceSources[traceSourceName];
            LogSource logSource2 = Log.LogWriter.TraceSources[traceSourceName];

            if (logSource != null)
            {
                var listeners = logSource.Listeners;
                List<TraceListener> listeners1 = (List<TraceListener>)logSource.Listeners;

                Log.INFO($"Found:{listeners.Count()} listeners", LOG_APPNAME);

                TraceListener listenerToRemove = null;

                foreach (TraceListener listener in listeners)
                {
                    if (listener.Name == listenerName)
                    {
                        listenerToRemove = listener;
                    }
                }

                if (listenerToRemove !=null)
                {
                    Log.INFO($"Removing {listenerName} from {traceSourceName}", LOG_APPNAME);
                    listeners1.Remove(listenerToRemove);
                }
            }
        }

        private void RemoveSpecialSourcesAllEventsListener(string listenerName)
        {
            Log.INFO($"listenerName:>{listenerName}<", LOG_APPNAME);

            // Load the configuration source
            IConfigurationSource config = ConfigurationSourceFactory.Create();

            var traceSource = GetAllSpecialSources(config).AllEventsTraceSource;

            NamedElementCollection<TraceListenerReferenceData> listeners = traceSource.TraceListeners;

            // NOTE(crhodes)
            // This does not work .  The collection is read only.  Need to find another way to remove the listener.
            //listeners.Remove(listenerName);
        }


        private void RemoveSpecialSourcesNotProcessedListener(string listenerName)
        {
            Log.INFO($"listenerName:>{listenerName}<", LOG_APPNAME);

            // Load the configuration source
            IConfigurationSource config = ConfigurationSourceFactory.Create();

            var traceSource = GetAllSpecialSources(config).NotProcessedTraceSource;

            NamedElementCollection<TraceListenerReferenceData> listeners = traceSource.TraceListeners;
            listeners.Remove(listenerName);
        }

        private void RemoveSpecialSourcesErrorsListener(string listenerName)
        {
            Log.INFO($"listenerName:>{listenerName}<", LOG_APPNAME);

            // Load the configuration source
            IConfigurationSource config = ConfigurationSourceFactory.Create();

            var traceSource = GetAllSpecialSources(config).ErrorsTraceSource;

            NamedElementCollection<TraceListenerReferenceData> listeners = traceSource.TraceListeners;
            listeners.Remove(listenerName);
        }

        private TraceListenerDataCollection GetAllListeners(IConfigurationSource config)
        {
            // Get the logging settings from the configuration
            LoggingSettings loggingSettings = LoggingSettings.GetLoggingSettings(config);

            TraceListenerDataCollection allListeners = loggingSettings.TraceListeners;

            return allListeners;
        }

        private NamedElementCollection<TraceSourceData> GetAllCategorySources(IConfigurationSource config)
        {
            // Get the logging settings from the configuration
            LoggingSettings loggingSettings = LoggingSettings.GetLoggingSettings(config);

            NamedElementCollection<TraceSourceData> allCategorySources = loggingSettings.TraceSources;

            return allCategorySources;
        }

        private SpecialTraceSourcesData GetAllSpecialSources(IConfigurationSource config)
        {
            // Get the logging settings from the configuration
            LoggingSettings loggingSettings = LoggingSettings.GetLoggingSettings(config);

            SpecialTraceSourcesData allSpecialSources = loggingSettings.SpecialTraceSources;

            return allSpecialSources;
        }

        private NameTypeConfigurationElementCollection<LogFilterData, CustomLogFilterData> GetAllLogFilters(IConfigurationSource config)
        {
            // Get the logging settings from the configuration
            LoggingSettings loggingSettings = LoggingSettings.GetLoggingSettings(config);

            var allFilters = loggingSettings.LogFilters;
            NameTypeConfigurationElementCollection<LogFilterData, CustomLogFilterData> allFilters2 = loggingSettings.LogFilters;

            return allFilters;
        }

        private NameTypeConfigurationElementCollection<FormatterData, CustomFormatterData> GetAllFormaters(IConfigurationSource config)
        {
            // Get the logging settings from the configuration
            LoggingSettings loggingSettings = LoggingSettings.GetLoggingSettings(config);

            var allFormatters = loggingSettings.Formatters;
            NameTypeConfigurationElementCollection<FormatterData, CustomFormatterData> allFormatters2 = loggingSettings.Formatters;

            return allFormatters2;
        }

        #region Learn Methods

        private void Learn1()
        {
            Log.INFO("Good Everything", LOG_APPNAME, 0);
            //this throws exception -  not set exception.
            LogWriter logWriter = Logger.Writer;

            // Retrieve a specific LogSource (e.g., the "General" category)
            // The actual name "General" depends on your configuration
            LogSource generalSource = logWriter.TraceSources["General"];

            if (generalSource != null)
            {
                // Access the collection of TraceListeners for this source
                TraceListenerCollection listeners = (TraceListenerCollection)generalSource.Listeners;

                // Iterate over the listeners
                foreach (TraceListener listener in listeners)
                {
                    // Access listener properties (e.g., Name, type)
                    //Console.WriteLine($"Listener Name: {listener.Name}, Type: {listener.GetType().FullName}");
                }
            }
        }

        private void Learn2A()
        {
            //string configFilePath = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
            //Console.WriteLine(configFilePath);

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string fullPath = config.FilePath;
            string fileName = Path.GetFileName(fullPath);

            Console.WriteLine($"Full Path: {fullPath}");
            Console.WriteLine($"File Name: {fileName}");


        }

        private void Learn2()
        {
            //how does microsoft.practices.enterpriselibrary logging initialization work
            // Conceptual example

            //// Load configuration from a specific file
            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
            //fileMap.ExeConfigFilename = @"\MyApp.config";
            fileMap.ExeConfigFilename = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).FilePath;
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

            // Get the logging settings section
            LoggingSettings loggingSettings = config.GetSection("loggingConfiguration") as LoggingSettings;

            //this throws exception
            //// Create a LogWriter from the settings
            //LogWriterFactory factory = new LogWriterFactory(settings);

            IConfigurationSource config2 = ConfigurationSourceFactory.Create();

            // Get the logging settings from the configuration
            LoggingSettings loggingSettings2 = LoggingSettings.GetLoggingSettings(config2);

            //LogWriter customLogWriter = factory.Create();

            //// Optionally set the static Logger facade instance
            //Logger.SetLogWriter(customLogWriter);
        }

        private void Learn3()
        {
            Log.INFO("Good Everything", LOG_APPNAME, 0);

            // Load the configuration source
            IConfigurationSource config = ConfigurationSourceFactory.Create();

            // Get the logging settings from the configuration
            LoggingSettings loggingSettings = LoggingSettings.GetLoggingSettings(config);

            // Access the collection of all configured TraceListeners via their configuration data
            var allTraceListeners = loggingSettings.TraceListeners;

            var srl = allTraceListeners.Where(f => f.Name == "SignalRCoreListener").FirstOrDefault();

            Log.INFO("TraceListeners", LOG_APPNAME, 0);

            foreach (TraceListenerData listener in allTraceListeners)
            {
                Log.INFO($"Name:{listener.Name}", LOG_APPNAME);
            }

            var allFormatters = loggingSettings.Formatters;
            NameTypeConfigurationElementCollection<FormatterData, CustomFormatterData> allFormatters2 = loggingSettings.Formatters;

            var lvf = allFormatters2.Where(f => f.Name == "LiveView Formatter").FirstOrDefault();

            Log.INFO("Formatters", LOG_APPNAME, 0);

            foreach (TextFormatterData formatter in allFormatters)
            {
                Log.INFO($"Name:{formatter.Name} Template:{formatter.Template}", LOG_APPNAME);
            }
        }

        private void Learn4()
        {
            LoggingConfiguration config = new LoggingConfiguration();
            
            var lw = Log.LogWriter;

            var foo = 1;

        }

        #endregion
    }
}
