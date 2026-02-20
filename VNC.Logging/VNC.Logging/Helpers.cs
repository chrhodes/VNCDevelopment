using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;

using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging.TraceListeners;

namespace VNC.Logging
{
    

    public static class Helpers
    {
        #region Helper Class (From Dojie)

        // NOTE(crhodes)
        // These two methods were from Dojie

        [DebuggerStepThrough]
        public static T ExecuteLogHandledOp<T>(Func<T> action, LoggingPriority loggingPriority, string applicationCategory, string? additionalStartMessage = null, string? additionalEndMessage = null)
        {
            //StackTrace trace = new StackTrace();
            MethodBase method = new StackFrame(1).GetMethod();
            var startMethod = typeof(Log).GetMethod(loggingPriority.ToString(), new Type[] { typeof(string), typeof(string), typeof(MethodBase) });
            long dbTicks = 0;
            if (startMethod != null)
            {
                try
                {
                    dbTicks = (long)startMethod.Invoke(null, new object[] { string.Format("Enter: {0}", additionalStartMessage), applicationCategory, method });
                }
                catch (Exception ex)
                {
                    Log.ERROR(string.Format("Exception: {0}", additionalStartMessage), applicationCategory);
                    Log.ERROR(ex, applicationCategory);
                }
            }

            var result = action();

            var endMethod = typeof(Log).GetMethod(loggingPriority.ToString(), new Type[] { typeof(string), typeof(string), typeof(long), typeof(MethodBase) });
            if (endMethod != null)
            {
                try
                {
                    endMethod.Invoke(null, new object[] { string.Format("Exit: result:({0}) {1}", result, additionalEndMessage), applicationCategory, dbTicks, method });
                }
                catch (Exception ex)
                {
                    Log.ERROR(string.Format("Exception: {0}", additionalEndMessage), applicationCategory);
                    Log.ERROR(ex, applicationCategory);
                }
            }

            return result;
        }

        [DebuggerStepThrough]
        public static void ExecuteLogHandledOp(Action action, LoggingPriority loggingPriority, string applicationCategory, string? additionalStartMessage = null, string? additionalEndMessage = null)
        {
            //StackTrace trace = new StackTrace();
            MethodBase method = new StackFrame(1).GetMethod();
            var startMethod = typeof(Log).GetMethod(loggingPriority.ToString(), new Type[] { typeof(string), typeof(string), typeof(MethodBase) });
            long dbTicks = 0;
            if (startMethod != null)
            {
                try
                {
                    dbTicks = (long)startMethod.Invoke(null, new object[] { string.Format("Enter: {0}", additionalStartMessage), applicationCategory, method });
                }
                catch (Exception ex)
                {
                    Log.ERROR(string.Format("Exception: {0}", additionalStartMessage), applicationCategory);
                    Log.ERROR(ex, applicationCategory);
                }
            }

            action();

            var endMethod = typeof(Log).GetMethod(loggingPriority.ToString(), new Type[] { typeof(string), typeof(string), typeof(long), typeof(MethodBase) });
            if (endMethod != null)
            {
                try
                {
                    endMethod.Invoke(null, new object[] { string.Format("Exit: {0}", additionalEndMessage), applicationCategory, dbTicks, method });
                }
                catch (Exception ex)
                {
                    Log.ERROR(string.Format("Exception: {0}", additionalEndMessage), applicationCategory);
                    Log.ERROR(ex, applicationCategory);
                }
            }
        }

        #endregion

        /// <summary>
        /// Adds TraceListener to all CategorySources
        /// </summary>
        /// <param name="listenerName">Name of TraceListener</param>
        /// <param name="formatterName">Name of Formatter</param>
        public static void AddListener<T>(string listenerName, string formatterName) where T : CustomTraceListener, new()
        {
            if (listenerName == null)
            {
                throw new ArgumentNullException("Listener name cannot be null.");
            }

            if (formatterName == null)
            {
                throw new ArgumentNullException("Formatter name cannot be null.");
            }

            foreach (var categorySource in GetAllCategorySources())
            {
                AddListener<T>(listenerName, formatterName, categorySource.Name);
            }
        }

        /// <summary>
        /// Adds TraceListener of type T to named CategorySource
        /// </summary>
        /// <param name="listenerName">Name of TraceListener</param>
        /// <param name="formatterName">Name of Formatter</param>    
        /// <param name="categoryName">Name of CategorySource</param>
        public static void AddListener<T>(string listenerName, string formatterName, string categoryName) where T : CustomTraceListener, new()
        {
            try
            {
                T listenerToAdd = new T();
                listenerToAdd.Name = listenerName;

                IConfigurationSource config = ConfigurationSourceFactory.Create();

                var formatter = GetAllFormatters().Where(f => f.Name == formatterName).FirstOrDefault();

                if (formatter is not null)
                {
                    ((T)listenerToAdd).Formatter = formatter.BuildFormatter();

                    Log.INFO($"Adding: {listenerToAdd.Name} to categorySource: {categoryName}", "VNCCore");

                    LogSource logSource = Logger.Writer.TraceSources[categoryName];
                    List<TraceListener> listeners = (List<TraceListener>)logSource.Listeners;

                    var existingListener = listeners.Where(l => l.Name == listenerToAdd.Name).FirstOrDefault();

                    if (!listeners.Any(l => l.Name == listenerToAdd.Name))
                    {
                        listeners.Add(listenerToAdd);
                    }
                }
                else
                {
                    throw new ArgumentException($"Formatter: >{formatterName}< not found. Cannot add listener: >{listenerName}<");
                }
            }
            catch (Exception ex)
            {
                Log.ERROR(ex, "ERRORS");
            }
        }

        /// <summary>
        /// Removes a TraceListener from all CategorySources
        /// </summary>
        /// <param name="listenerName"></param>
        public static void RemoveListener(string listenerName)
        {
            foreach (TraceSourceData categorySource in Helpers.GetAllCategorySources())
            {
                 RemoveListener(categorySource, listenerName);
            }
        }

        /// <summary>
        /// Removes a TraceListener from a CategorySource
        /// </summary>
        /// <param name="listenerName"></param>
        /// <param name="categorySource"></param>
        public static void RemoveListener(TraceSourceData categorySource, string listenerName)
        {
            foreach (TraceListenerReferenceData listener in categorySource.TraceListeners)
            {
                if (listener.Name == listenerName)
                {
                    RemoveListener(categorySource.Name, listener.Name);
                }
            }
        }

        private static void RemoveListener(string traceSourceName, string listenerName)
        {
            //Log.INFO($"traceSourceName:>{traceSourceName}< listenerName:>{listenerName}<", LOG_APPNAME);

            LogSource logSource = Logger.Writer.TraceSources[traceSourceName];
            //LogSource logSource2 = Log.LogWriter.TraceSources[traceSourceName];

            if (logSource != null)
            {
                var listeners = logSource.Listeners;
                List<TraceListener> listeners1 = (List<TraceListener>)logSource.Listeners;

                //Log.INFO($"Found:{listeners.Count()} listeners", LOG_APPNAME);

                TraceListener listenerToRemove = null;

                foreach (TraceListener listener in listeners)
                {
                    if (listener.Name == listenerName)
                    {
                        listenerToRemove = listener;
                    }
                }

                if (listenerToRemove != null)
                {
                    //Log.INFO($"Removing {listenerName} from {traceSourceName}", LOG_APPNAME);
                    listeners1.Remove(listenerToRemove);
                }
            }
        }

        /// <summary>
        /// Gets all Formatters from the logging configuration.
        /// </summary>
        /// <returns>NameTypeConfigurationElementCollection<FormatterData, CustomFormatterData></returns>
        public static NameTypeConfigurationElementCollection<FormatterData, CustomFormatterData> GetAllFormatters()
        {
            // Load the configuration source
            IConfigurationSource config = ConfigurationSourceFactory.Create();

            // Get the logging settings from the configuration
            LoggingSettings loggingSettings = LoggingSettings.GetLoggingSettings(config);

            NameTypeConfigurationElementCollection<FormatterData, CustomFormatterData> allFormatters = loggingSettings.Formatters;

            return allFormatters;
        }

        /// <summary>
        /// Gets all LogFilters from the logging configuration.
        /// </summary>
        /// <returns>NameTypeConfigurationElementCollection<LogFilterData, CustomLogFilterData></returns>
        public static NameTypeConfigurationElementCollection<LogFilterData, CustomLogFilterData> GetAllLogFilters()
        {
            // Load the configuration source
            IConfigurationSource config = ConfigurationSourceFactory.Create();

            // Get the logging settings from the configuration
            LoggingSettings loggingSettings = LoggingSettings.GetLoggingSettings(config);

            var allFilters = loggingSettings.LogFilters;
            NameTypeConfigurationElementCollection<LogFilterData, CustomLogFilterData> allFilters2 = loggingSettings.LogFilters;

            return allFilters;
        }

        /// <summary>
        /// Gets all TraceListeners from the logging configuration.
        /// </summary>
        /// <returns>TraceListenerDataCollection</returns>
        public static TraceListenerDataCollection GetAllListeners()
        {
            // Load the configuration source
            IConfigurationSource config = ConfigurationSourceFactory.Create();

            // Get the logging settings from the configuration
            LoggingSettings loggingSettings = LoggingSettings.GetLoggingSettings(config);

            TraceListenerDataCollection allListeners = loggingSettings.TraceListeners;

            return allListeners;
        }

        /// <summary>
        /// Gets all category sources from the logging configuration.
        /// </summary>
        /// <returns>NamedElementCollection<TraceSourceData></returns>
        public static NamedElementCollection<TraceSourceData> GetAllCategorySources()
        {
            // Load the configuration source
            IConfigurationSource config = ConfigurationSourceFactory.Create();

            // Get the logging settings from the configuration
            LoggingSettings loggingSettings = LoggingSettings.GetLoggingSettings(config);

            NamedElementCollection<TraceSourceData> allCategorySources = loggingSettings.TraceSources;

            return allCategorySources;
        }

        /// <summary>
        /// Gets the SpecialTraceSources section of the configuration. 
        /// This includes the AllEventsCategory, UnprocessedCategory, and ErrorsCategory
        /// </summary>
        /// <returns>SpecialTraceSourcesData</returns>
        public static SpecialTraceSourcesData GetAllSpecialSources()
        {
            // Load the configuration source
            IConfigurationSource config = ConfigurationSourceFactory.Create();

            // Get the logging settings from the configuration
            LoggingSettings loggingSettings = LoggingSettings.GetLoggingSettings(config);

            SpecialTraceSourcesData allSpecialSources = loggingSettings.SpecialTraceSources;

            return allSpecialSources;
        }
    }
}
