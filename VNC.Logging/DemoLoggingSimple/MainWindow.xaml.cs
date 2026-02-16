using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows;

using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging.Configuration;

//using Microsoft.Practices.EnterpriseLibrary.Data;

using VNC;
using VNC.Logging.TraceListeners;

namespace DemoLoggingSimple
{
    public partial class MainWindow : Window
    {
        const string LOG_APPNAME = "DemoAndTestLogging";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogSomething(object sender, RoutedEventArgs e)
        {
            long startTicks;

            startTicks = Log.INFO("SignalR Delay", LOG_APPNAME);

            Thread.Sleep(125);

            startTicks = Log.INFO("Good Everything", LOG_APPNAME, startTicks);
            startTicks = Log.EVENT_HANDLER("High Five", LOG_APPNAME, startTicks);

            startTicks = Log.DEBUG("Start", LOG_APPNAME);

            Thread.Sleep(750);

            startTicks = Log.TRACE("UnknownCategory", "Unknown", startTicks);
            startTicks = Log.TRACE1("VNCCore", "VNCCore", startTicks);

            Log.TRACE2("End", LOG_APPNAME, startTicks);       
        }

        private void btnListListeners(object sender, RoutedEventArgs e)
        {
            IConfigurationSource config = ConfigurationSourceFactory.Create();

            Log.INFO("TraceListeners", LOG_APPNAME, 0);

            foreach (TraceListenerData listener in GetAllListeners(config))
            {
                Log.INFO($"  {listener.Name}", LOG_APPNAME);
            }
        }

        private static void DisplayListeners(IEnumerable<TraceListener> listeners)
        {
            foreach (TraceListener listener in listeners)
            {
                Log.INFO($"Found {listener.Name}", LOG_APPNAME);
                foreach (var attribute in listener.Attributes)
                {
                    Log.INFO($"Attribute {attribute}", LOG_APPNAME);
                }
            }
        }

        private static void DisplayListeners(NamedElementCollection<TraceListenerReferenceData> listeners)
        {
            foreach (TraceListenerReferenceData listener in listeners)
            {
                Log.INFO($"Found {listener.Name}", LOG_APPNAME);
            }
        }

        private void btnAddListener(object sender, RoutedEventArgs e)
        {
            Log.INFO("Enter", LOG_APPNAME, 0);

            // TODO(crhodes)
            // Need a more robust way to identify the listener to remove.  This is just for demo purposes.
            // "General" is the default category for logging.  What happens if not in app.config?
            
            //LogSource logSource = Logger.Writer.TraceSources["DemoAndTestLogging"];

            //if (logSource != null)
            //{
            //    var listeners = logSource.Listeners;
            //    List<TraceListener> listeners1 = (List<TraceListener>)logSource.Listeners;
      
                try
                {
                    // NOTE(crhodes)
                    // This works but the formatter is not right

                    SignalRCoreListenerSendAsync listenerToAdd = new SignalRCoreListenerSendAsync();
                    listenerToAdd.Name = "SignalRCoreListener";

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

                        listeners2.Add(listenerToAdd);
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
            Log.INFO("Enter", LOG_APPNAME, 0);

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
            //                        listernerToRemove = listener;
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

            IConfigurationSource config = ConfigurationSourceFactory.Create();

            foreach (TraceSourceData categorySource in GetAllCategorySources(config))
            {
                foreach (TraceListenerReferenceData listener in categorySource.TraceListeners)
                {                    
                    TraceListenerReferenceData listenerToRemove = null;

                    if (listener.Name == "Rolling FlatFile TraceListener")
                    {
                        Log.INFO($"Found {listener.Name}", LOG_APPNAME);
                    }
                    else if (listener.Name == "SignalRCoreListener")
                    {
                        Log.INFO($"Found {listener.Name}", LOG_APPNAME);

                        //listenerToRemove = listener;
                        // NOTE(crhodes)
                        // Can't remove listener from collection while enumerating it.
                        // Need to save it and remove after enumeration.
                        //listeners1.Remove(listener);
                        // NOTE(crhodes)
                        // Can't do this.  Read Only
                        //categorySource.TraceListeners.Remove(listener.Name);
                        RemoveListener(categorySource.Name, listener.Name);
                    }
                    else
                    {
                        Log.INFO($"Unexpected listener {listener.Name}", LOG_APPNAME);
                    }
                }

                //this didn't stop logging'
                //listener.Close();
                //Log.INFO($"{listener.Name} is closed", LOG_APPNAME);
                //Console.WriteLine($"Listener Name: {listener.Name}, Type: {listener.GetType().FullName}");
            }

            Log.INFO("Exit", LOG_APPNAME, 0);
        }

        private void RemoveListener(string traceSourceName, string listenerName)
        {
            LogSource logSource = Logger.Writer.TraceSources[traceSourceName];

            if (logSource != null)
            {
                var listeners = logSource.Listeners;
                List<TraceListener> listeners1 = (List<TraceListener>)logSource.Listeners;

                TraceListener listenerToRemove = null;

                foreach (TraceListener listener in listeners)
                {
                    if (listener.Name == listenerName)
                    {
                        listenerToRemove = listener;
                    }
                }

                if (listenerToRemove is not null)
                {
                    Log.INFO($"Removing {listenerName} from {traceSourceName}", LOG_APPNAME);
                    listeners1.Remove(listenerToRemove);
                }
            }
        }

        private void btnLearnSomething(object sender, RoutedEventArgs e)
        {
            Try3();
        }


        private void Try1()
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

        private void Try3()
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

        private void btnListCategorySources(object sender, RoutedEventArgs e)
        {
            // Load the configuration source
            IConfigurationSource config = ConfigurationSourceFactory.Create();

            Log.INFO("CategorySources(TraceSources)", LOG_APPNAME, 0);

            foreach (TraceSourceData categorySource in GetAllCategorySources(config))
            {
                Log.INFO($"Name:{categorySource.Name}", LOG_APPNAME);

                DisplayListeners(categorySource.TraceListeners);
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

        private void btnListFilters(object sender, RoutedEventArgs e)
        {
            Log.INFO("Good Everything", LOG_APPNAME, 0);

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

        private void btnListFormatters(object sender, RoutedEventArgs e)
        {
            Log.INFO("Good Everything", LOG_APPNAME, 0);
            
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


    }
}
