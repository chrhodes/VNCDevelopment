//'------------------------------------------------------------------------------------------------------------------------
//'
//' TODO: Determine how to use the TraceEventType enumeration.  Vista seems to have more levels.  Windows 2003 fewer.  
//'       Should probably plan for future. Review the mapping levels
//'       Not sure how to get Critical messages to appear in eventlog.  Go look in EntLib code to see if they do mapping.
//'
//'       TraceEventType  Description                         Value   Vista Log   2003 Log    2008 Log    Log Method	    Priority Filter
//'       --------------  ---------------------------------   -----   ---------   --------    --------    ------------		---------------
//'       Critical        Fatal error or application crash    1       Error       ?           ?           Failure			Log.Failure		(-10)
//'       Error           Recoverable error                   2       Error                               Error				Log.Error		(-1)
//'       Warning         Non-Critical Problem                4       Warning                             Warning			Log.Warning		(1)       
//'       Information     Informational message               8       Information Information ?           Info				Log.Info		(100)
//'																										  Info1				Log.Info1		(101)
//'																										  Info2				Log.Info2		(102)
//'																										  Info3				Log.Info3		(103)
//'																										  Info4				Log.Info4		(104)
//'       Verbose         Debugging trace                     16                                          Debug				Log.Debug		(1000)
//'																										  Debug1			Log.Debug1		(1001)
//'																										  Debug2			Log.Debug2		(1002)
//'																										  Debug3			Log.Debug3		(1003)
//'																										  Debug4			Log.Debug4		(1004)
//'                                                                                                       Arch              Log.Arch        (9000)
//'                                                                                                       Arch1             Log.Arch1       (9001)
//'                                                                                                       Arch2             Log.Arch2       (9002)
//'                                                                                                       Arch3             Log.Arch3       (9003)
//'                                                                                                       Arch4             Log.Arch4       (9004)
//'                                                                                                       Arch5             Log.Arch5       (9005)
//'                                                                                                       Arch6             Log.Arch6       (9006)
//'                                                                                                       Arch7             Log.Arch7       (9007)
//'                                                                                                       Arch8             Log.Arch8       (9008)
//'                                                                                                       Arch9             Log.Arch9       (9009)
//'                                                                                                       Arch10             Log.Arch10       (90010)
//'                                                                                                       Arch11             Log.Arch11       (90011)
//'                                                                                                       Arch12             Log.Arch12       (90012)
//'                                                                                                       Arch13             Log.Arch13       (90013)
//'                                                                                                       Arch14             Log.Arch14       (90014)
//'                                                                                                       Arch15             Log.Arch15       (90015)
//'                                                                                                       Arch16             Log.Arch16       (90016)
//'                                                                                                       Arch17             Log.Arch17       (90017)
//'                                                                                                       Arch18             Log.Arch18       (90018)
//'                                                                                                       Arch19             Log.Arch19       (90019)
//'                                                                                                       Arch20             Log.Arch20       (90020)
//'                                                                                                       Arch21             Log.Arch21       (90021)
//'                                                                                                       Arch22             Log.Arch22       (90022)
//'                                                                                                       Arch23             Log.Arch23       (90023)
//'                                                                                                       Arch24             Log.Arch24       (90024)
//'                                                                                                       Arch25             Log.Arch25       (90025)
//'                                                                                                       Arch26             Log.Arch26       (90026)
//'                                                                                                       Arch27             Log.Arch27       (90027)
//'                                                                                                       Arch28             Log.Arch28       (90028)
//'                                                                                                       Arch29             Log.Arch29       (90029)
//'                                                                                                       Arch30             Log.Arch30       (90030)
//'                                                                                                       Arch31             Log.Arch31       (90031)
//'                                                                                                       Arch32             Log.Arch32       (90032)
//'                                                                                                       Arch33             Log.Arch33       (90033)
//'                                                                                                       Arch34             Log.Arch34       (90034)
//'                                                                                                       Arch35             Log.Arch35       (90035)
//'                                                                                                       Arch36             Log.Arch36       (90036)
//'                                                                                                       Arch37             Log.Arch37       (90037)
//'                                                                                                       Arch38             Log.Arch38       (90038)
//'                                                                                                       Arch39             Log.Arch39       (90039)
//'                                                                                                       Trace             Log.Trace       (10000)
//'                                                                                                       Trace1			Log.Trace1		(10001)
//'                                                                                                       Trace2			Log.Trace2		(10002)
//'                                                                                                       Trace3			Log.Trace3		(10003)
//'                                                                                                       Trace4			Log.Trace4		(10004)
//'                                                                                                       Trace5			Log.Trace5		(10005)
//'                                                                                                       Trace6			Log.Trace6		(10006)
//'                                                                                                       Trace7			Log.Trace7		(10007)
//'                                                                                                       Trace8			Log.Trace8		(10008)
//'                                                                                                       Trace9			Log.Trace9		(10009)
//'                                                                                                       Trace10			Log.Trace10		(100010)
//'                                                                                                       Trace11			Log.Trace11		(100011)
//'                                                                                                       Trace12			Log.Trace12		(100012)
//'                                                                                                       Trace13			Log.Trace13		(100013)
//'                                                                                                       Trace14			Log.Trace14		(100014)
//'                                                                                                       Trace15			Log.Trace15		(100015)
//'                                                                                                       Trace16			Log.Trace16		(100016)
//'                                                                                                       Trace17			Log.Trace17		(100017)
//'                                                                                                       Trace18			Log.Trace18		(100018)
//'                                                                                                       Trace19			Log.Trace19		(100019)
//'                                                                                                       Trace20			Log.Trace20		(100020)
//'                                                                                                       Trace21			Log.Trace21		(100021)
//'                                                                                                       Trace22			Log.Trace22		(100022)
//'                                                                                                       Trace23			Log.Trace23		(100023)
//'                                                                                                       Trace24			Log.Trace24		(100024)
//'                                                                                                       Trace25			Log.Trace25		(100025)
//'                                                                                                       Trace26			Log.Trace26		(100026)
//'                                                                                                       Trace27			Log.Trace27		(100027)
//'                                                                                                       Trace28			Log.Trace28		(100028)
//'                                                                                                       Trace29			Log.Trace29		(100029)
//'
//'       Start          Starting of logical operation        256
//'       Stop           Stopping of logical operation        512
//'       Suspend        Suspension of logical operation      1024
//'       Resume         Resumption of logical operation      2048
//'       Transfer       Changing of correlation identity     4096
//'
//' TO DECIDE:
//'   I don't think we need the methods that don't pass a applicationCategory.  I also think we might want to skip the Info, Debug, and Trace
//'   versions that take a stacktrace flag.
//'   That would leave two versions for Failure and Error and one each for Warning, Info, Debug, and Trace.
//'
//' NOTES:
//'   The methods use the
//'           <System.Diagnostics.DebuggerStepThrough()> _
//'   attribute to suppress tracing through the logging code.  You can still set breakpoints in the method if you want.
//'
//'------------------------------------------------------------------------------------------------------------------------

//''' <summary>
//''' 
//''' </summary>
//''' <remarks>
//      Wrapper around EnterpriseLibrary.Logging.Logger.Write  
//      Simplifies calling by setting values for Priority and Severity.  
//      Passes several extended properties.
//  </remarks>

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace VNC
{
    [Serializable]
    public partial class Log
    {
        private const long NoElapsedTime = 0L;

        static Log()
        {
            // NOTE(crhodes)
            // After a lot of work this returns the appropriate configuration for the calling assembly.
            // This allows us to have different logging configurations for different assemblies if we want.
            // It also allows us to have a default configuration that will be used if the calling assembly
            // doesn't have a configuration section defined.
            // In testing it takes less than a 0.2 microseconds to do this.  
            // So it is not a problem to do this in the static constructor and have it ready to go for the first log message.

            Int64 startTicks = Stopwatch.GetTimestamp();

            // NOTE(crhodes)
            // Above NOTE came from the Enterprise Library Logging Application Block documentation and code.
            // and was auto generated

            IConfigurationSource configurationSource = ConfigurationSourceFactory.Create();

            // NOTE(crhodes)
            // This returns a factory that contains "loggingConfiguration".
            // Don't think anything of real interest has happened yet. Magic must be in logWriterFactory.Create()

            LogWriterFactory logWriterFactory = new LogWriterFactory(configurationSource);

            // NOTE(crhodes)
            // Magic happens here. logWriterFactory.Create reads loggingConfiguration
            // and gets all the filters, formatters, and traceListeners
            // and sets the Logger Writer

            _logWriter = logWriterFactory.Create();
            Logger.SetLogWriter(_logWriter);

            Int64 frequency = Stopwatch.Frequency;
            // 10,000,000 ticks per second, so this is 100 nanoseconds per tick.  So this is 0.1 microseconds.

            Double duration = GetDuration(startTicks);
        }

        private static LogWriter _logWriter;
        public static LogWriter LogWriter
        {
            get => _logWriter;
            private set => _logWriter = value;
        }   

        #region Public Write Methods

        [DebuggerStepThrough]
        public static void Write(Exception ex, TraceEventType severity, string category, LoggingPriority priority, 
                                 string className, string methodName, bool showStack)
        {
            string name = Assembly.GetCallingAssembly().GetName().Name;
            if (category.Length == 0)
            {
                category = "General";
            }
            InternalWrite(ex.Message + ex.StackTrace, severity, category, priority, className, methodName, name, showStack);
        }

        [DebuggerStepThrough]
        public static void Write(string message, TraceEventType severity, string category, LoggingPriority priority, 
                                 string className, string methodName, bool showStack)
        {
            string name = Assembly.GetCallingAssembly().GetName().Name;
            if (category.Length == 0)
            {
                category = "General";
            }
            InternalWrite(message, severity, category, priority, className, methodName, name, showStack);
        }

        [DebuggerStepThrough]
        public static void Write(string message, TraceEventType severity, string category, LoggingPriority priority, 
                                 string className, string methodName, bool showStack, long startTicks)
        {
            string name = Assembly.GetCallingAssembly().GetName().Name;
            if (category.Length == 0)
            {
                category = "General";
            }
            InternalWrite(message, severity, category, priority, className, methodName, name, showStack, startTicks);
        }

        [DebuggerStepThrough]
        public static void WriteLight(string message, TraceEventType severity, string category, LoggingPriority priority,
                                      string className, string methodName, bool showStack, long startTicks)
        {
            if (category.Length == 0)
            {
                category = "General";
            }
            InternalWrite(message, severity, category, priority, className, methodName, "<unknown>", showStack, startTicks);
        }

        #endregion

        #region Private Write Methods

        [DebuggerStepThrough]
        private static void InternalWrite(string message, TraceEventType severity, string category, LoggingPriority priority, 
                                          string className, string methodName, string callingAssemblyName, bool showStack)
        {
            string str = "";

            if (showStack)
            {
                StackTrace trace = new StackTrace();
                string str2 = "";
                foreach (StackFrame frame in trace.GetFrames())
                {
                    MethodBase method = frame.GetMethod();
                    str2 = method.ReflectedType.Name + "." + method.Name + " > " + str2;
                }
                str = str2 + " " + str;
            }

            LogEntry log = new LogEntry();

            if (category.Length == 0)
            {
                category = "General";
            }

            log.Categories.Add(category);
            log.Severity = severity;
            log.Priority = (int)priority;
            log.ExtendedProperties.Add("Calling Assembly", callingAssemblyName);
            log.ExtendedProperties.Add("Class Name", className);
            log.ExtendedProperties.Add("Method Name", methodName);
            log.ExtendedProperties.Add("Stack", str);
            log.ExtendedProperties.Add("User Name", Environment.UserName);
            log.Message = message;

            try
            {
                Logger.Write(log);
            }
			//catch (ServiceLocation.ActivationException)
			//{
			////	InternalWriter().Write(log);
			//}
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                throw ex;
            }
        }

        [DebuggerStepThrough]
        private static void InternalWrite(string message, TraceEventType severity, string category, LoggingPriority priority, 
                                          string className, string methodName, string callingAssemblyName, bool showStack, 
                                          int EventId)
        {
            string str = "";

            if (showStack)
            {
                StackTrace trace = new StackTrace();
                string str2 = "";
                foreach (StackFrame frame in trace.GetFrames())
                {
                    MethodBase method = frame.GetMethod();
                    str2 = method.ReflectedType.Name + "." + method.Name + " > " + str2;
                }
                str = str2 + " " + str;
            }

            LogEntry log = new LogEntry();

            if (category.Length == 0)
            {
                category = "General";
            }

            log.Categories.Add(category);
            log.EventId = EventId;
            log.Severity = severity;
            log.Priority = (int)priority;
            log.ExtendedProperties.Add("Calling Assembly", callingAssemblyName);
            log.ExtendedProperties.Add("Class Name", className);
            log.ExtendedProperties.Add("Method Name", methodName);
            log.ExtendedProperties.Add("Stack", str);
            log.ExtendedProperties.Add("User Name", Environment.UserName);
            log.Message = message;

            try
            {
                Logger.Write(log);
            }
			//catch (ServiceLocation.ActivationException)
			//{
			////	InternalWriter().Write(log);
			//}
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                throw ex;
            }
        }

        [DebuggerStepThrough]
        private static void InternalWrite(string message, TraceEventType severity, string category, LoggingPriority priority, 
                                          string className, string methodName, string callingAssemblyName, bool showStack, 
                                          Dictionary<string, string> extendedProp)
        {
            string str = "";

            if (showStack)
            {
                StackTrace trace = new StackTrace();
                string str2 = "";
                foreach (StackFrame frame in trace.GetFrames())
                {
                    MethodBase method = frame.GetMethod();
                    str2 = method.ReflectedType.Name + "." + method.Name + " > " + str2;
                }
                str = str2 + " " + str;
            }

            LogEntry log = new LogEntry();

            if (category.Length == 0)
            {
                category = "General";
            }

            log.Categories.Add(category);
            log.Severity = severity;
            log.Priority = (int)priority;
            log.ExtendedProperties.Add("Calling Assembly", callingAssemblyName);
            log.ExtendedProperties.Add("Class Name", className);
            log.ExtendedProperties.Add("Method Name", methodName);
            log.ExtendedProperties.Add("Stack", str);
            log.ExtendedProperties.Add("User Name", Environment.UserName);

            foreach (KeyValuePair<string, string> pair in extendedProp)
            {
                log.ExtendedProperties.Add(pair.Key, pair.Value);
            }

            log.Message = message;

            try
            {
                Logger.Write(log);
            }
			//catch (ServiceLocation.ActivationException)
			//{
			////	InternalWriter().Write(log);
			//}
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                throw ex;
            }
        }

        [DebuggerStepThrough]
        private static void InternalWrite(string message, TraceEventType severity, string category, LoggingPriority priority, 
                                          string className, string methodName, string callingAssemblyName, bool showStack, 
                                          int EventId, Dictionary<string, string> extendedProp)
        {
            string str = "";

            if (showStack)
            {
                StackTrace trace = new StackTrace();
                string str2 = "";
                foreach (StackFrame frame in trace.GetFrames())
                {
                    MethodBase method = frame.GetMethod();
                    str2 = method.ReflectedType.Name + "." + method.Name + " > " + str2;
                }
                str = str2 + " " + str;
            }

            LogEntry log = new LogEntry();

            if (category.Length == 0)
            {
                category = "General";
            }

            log.Categories.Add(category);
            log.EventId = EventId;
            log.Severity = severity;
            log.Priority = (int)priority;
            log.ExtendedProperties.Add("Calling Assembly", callingAssemblyName);
            log.ExtendedProperties.Add("Class Name", className);
            log.ExtendedProperties.Add("Method Name", methodName);
            log.ExtendedProperties.Add("Stack", str);
            log.ExtendedProperties.Add("User Name", Environment.UserName);

            foreach (KeyValuePair<string, string> pair in extendedProp)
            {
                log.ExtendedProperties.Add(pair.Key, pair.Value);
            }

            log.Message = message;

            try
            {
                Logger.Write(log);
            }
			//catch (ServiceLocation.ActivationException)
			//{
			////	InternalWriter().Write(log);
			//}
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                throw ex;
            }
        }

        [DebuggerStepThrough]
        private static void InternalWrite(string message, TraceEventType severity, string category, LoggingPriority priority, 
                                          string className, string methodName, string callingAssemblyName, bool showStack, 
                                          long startTicks)
        {
            string str = "";

            if (showStack)
            {
                StackTrace trace = new StackTrace();
                string str2 = "";
                foreach (StackFrame frame in trace.GetFrames())
                {
                    MethodBase method = frame.GetMethod();
                    str2 = method.ReflectedType.Name + "." + method.Name + " > " + str2;
                }
                str = str2 + " " + str;
            }

            LogEntry log = new LogEntry();

            if (category.Length == 0)
            {
                category = "General";
            }

            log.Categories.Add(category);
            log.Severity = severity;
            log.Priority = (int)priority;
            log.ExtendedProperties.Add("Calling Assembly", callingAssemblyName);
            log.ExtendedProperties.Add("Class Name", className);
            log.ExtendedProperties.Add("Method Name", methodName);
            log.ExtendedProperties.Add("Stack", str);
            log.ExtendedProperties.Add("User Name", Environment.UserName);
            log.ExtendedProperties.Add("Duration", GetDuration(startTicks));
            log.Message = message;

            try
            {
                Logger.Write(log);
            }
			//catch (ServiceLocation.ActivationException)
			//{
			////	InternalWriter().Write(log);
			//}
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                throw ex;
            }
        }

        [DebuggerStepThrough]
        private static void InternalWrite(string message, TraceEventType severity, string category, LoggingPriority priority, 
                                          string className, string methodName, string callingAssemblyName, bool showStack,
                                          int EventId, long startTicks)
        {
            string str = "";

            if (showStack)
            {
                StackTrace trace = new StackTrace();
                string str2 = "";
                foreach (StackFrame frame in trace.GetFrames())
                {
                    MethodBase method = frame.GetMethod();
                    str2 = method.ReflectedType.Name + "." + method.Name + " > " + str2;
                }
                str = str2 + " " + str;
            }

            LogEntry log = new LogEntry();

            if (category.Length == 0)
            {
                category = "General";
            }

            log.Categories.Add(category);
            log.EventId = EventId;
            log.Severity = severity;
            log.Priority = (int)priority;
            log.ExtendedProperties.Add("Calling Assembly", callingAssemblyName);
            log.ExtendedProperties.Add("Class Name", className);
            log.ExtendedProperties.Add("Method Name", methodName);
            log.ExtendedProperties.Add("Stack", str);
            log.ExtendedProperties.Add("User Name", Environment.UserName);
            log.ExtendedProperties.Add("Duration", GetDuration(startTicks));
            log.Message = message;

            try
            {
                Logger.Write(log);
            }
			//catch (ServiceLocation.ActivationException)
			//{
			////	InternalWriter().Write(log);
			//}
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                throw ex;
            }
        }

        [DebuggerStepThrough]
        private static void InternalWrite(string message, TraceEventType severity, string category, LoggingPriority priority, 
                                          string className, string methodName, string callingAssemblyName, bool showStack, 
                                          Dictionary<string, string> extendedProp, long startTicks)
        {
            string str = "";

            if (showStack)
            {
                StackTrace trace = new StackTrace();
                string str2 = "";
                foreach (StackFrame frame in trace.GetFrames())
                {
                    MethodBase method = frame.GetMethod();
                    str2 = method.ReflectedType.Name + "." + method.Name + " > " + str2;
                }
                str = str2 + " " + str;
            }

            LogEntry log = new LogEntry();

            if (category.Length == 0)
            {
                category = "General";
            }

            log.Categories.Add(category);
            log.Severity = severity;
            log.Priority = (int)priority;
            log.ExtendedProperties.Add("Calling Assembly", callingAssemblyName);
            log.ExtendedProperties.Add("Class Name", className);
            log.ExtendedProperties.Add("Method Name", methodName);
            log.ExtendedProperties.Add("Stack", str);
            log.ExtendedProperties.Add("User Name", Environment.UserName);
            log.ExtendedProperties.Add("Duration", GetDuration(startTicks));

            foreach (KeyValuePair<string, string> pair in extendedProp)
            {
                log.ExtendedProperties.Add(pair.Key, pair.Value);
            }

            log.Message = message;

            try
            {
                Logger.Write(log);
            }
			//catch (ServiceLocation.ActivationException)
			//{
			////	InternalWriter().Write(log);
			//}
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                throw ex;
            }
        }

        [DebuggerStepThrough]
        private static void InternalWrite(string message, TraceEventType severity, string category, LoggingPriority priority, 
                                          string className, string methodName, string callingAssemblyName, bool showStack, 
                                          int EventId, Dictionary<string, string> extendedProp, long startTicks)
        {
            string str = "";

            if (showStack)
            {
                StackTrace trace = new StackTrace();
                string str2 = "";
                foreach (StackFrame frame in trace.GetFrames())
                {
                    MethodBase method = frame.GetMethod();
                    str2 = method.ReflectedType.Name + "." + method.Name + " > " + str2;
                }
                str = str2 + " " + str;
            }

            LogEntry log = new LogEntry();

            if (category.Length == 0)
            {
                category = "General";
            }

            log.Categories.Add(category);
            log.EventId = EventId;
            log.Severity = severity;
            log.Priority = (int)priority;
            log.ExtendedProperties.Add("Calling Assembly", callingAssemblyName);
            log.ExtendedProperties.Add("Class Name", className);
            log.ExtendedProperties.Add("Method Name", methodName);
            log.ExtendedProperties.Add("Stack", str);
            log.ExtendedProperties.Add("User Name", Environment.UserName);
            log.ExtendedProperties.Add("Duration", GetDuration(startTicks));

            foreach (KeyValuePair<string, string> pair in extendedProp)
            {
                log.ExtendedProperties.Add(pair.Key, pair.Value);
            }

            log.Message = message;

            try
            {
                Logger.Write(log);
            }
			//catch (ServiceLocation.ActivationException)
			//{
			////	InternalWriter().Write(log);
			//}
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                throw ex;
            }
        }

		// This is new in EASE
		// Think it might be an alternative to the Log() constructor

		//private static LogWriter InternalWriter()
        //{
		//	//Internal Writer allows callers to just log without any configuration from the calling assembly
		//	//This also allows us to wrap tests around this class.
		//
        //    string loggingConfigSetting = Properties.Resources.LoggingConfiguration;
		//
        //    string tempConfigPath = System.IO.Path.GetTempFileName();
        //    System.IO.File.AppendAllText(tempConfigPath, loggingConfigSetting);
		//
        //    Microsoft.Practices.EnterpriseLibrary.Common.Configuration.FileConfigurationSource configSource = new Microsoft.Practices.EnterpriseLibrary.Common.Configuration.FileConfigurationSource(tempConfigPath);
        //    LogWriterFactory logFactory = new LogWriterFactory(configSource);
        //    return logFactory.Create();
        //}

    #endregion

        #region Log Failure Methods

        [DebuggerStepThrough]
        public static void FAILURE(Exception ex, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(ex.Message + ex.StackTrace, TraceEventType.Critical, applicationCategory, LoggingPriority.Failure, method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, true);
        }

        [DebuggerStepThrough]
        public static void FAILURE(Exception ex, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(ex.Message + ex.StackTrace, TraceEventType.Critical, applicationCategory, LoggingPriority.Failure,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, true, 
                props);
        }

        [DebuggerStepThrough]
        public static void FAILURE(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Critical, applicationCategory, LoggingPriority.Failure,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
        }

        [DebuggerStepThrough]
        public static void FAILURE(Exception ex, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(ex.Message + ex.StackTrace, TraceEventType.Critical, applicationCategory, LoggingPriority.Failure,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, true, 
                EventId);
        }

        [DebuggerStepThrough]
        public static void FAILURE(string message, string applicationCategory, bool showStack)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Critical, applicationCategory, LoggingPriority.Failure,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, showStack);
        }

        [DebuggerStepThrough]
        public static void FAILURE(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Critical, applicationCategory, LoggingPriority.Failure,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId);
        }

        [DebuggerStepThrough]
        public static void FAILURE(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Critical, applicationCategory, LoggingPriority.Failure,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                props);
        }

        [DebuggerStepThrough]
        public static void FAILURE(Exception ex, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(ex.Message + ex.StackTrace, TraceEventType.Critical, applicationCategory, LoggingPriority.Failure,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, true, 
                EventId, props);
        }

        [DebuggerStepThrough]
        public static void FAILURE(string message, string applicationCategory, bool showStack, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Critical, applicationCategory, LoggingPriority.Failure,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, showStack, 
                props);
        }

        [DebuggerStepThrough]
        public static void FAILURE(string message, string applicationCategory, 
        int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Critical, applicationCategory, LoggingPriority.Failure,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
        }

    #endregion

        #region Log Error Methods

        [DebuggerStepThrough]
        public static void ERROR(Exception ex, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(ex.Message + ex.StackTrace, TraceEventType.Error, applicationCategory, LoggingPriority.Error, method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, true);
        }

        [DebuggerStepThrough]
        public static void ERROR(Exception ex, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(ex.Message + ex.StackTrace, TraceEventType.Error, applicationCategory, LoggingPriority.Error,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, true, 
                props);
        }

        [DebuggerStepThrough]
        public static void ERROR(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Error, applicationCategory, LoggingPriority.Error,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
        }

        [DebuggerStepThrough]
        public static void ERROR(Exception ex, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(ex.Message + ex.StackTrace, TraceEventType.Error, applicationCategory, LoggingPriority.Error,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, true, 
                EventId);
        }

        [DebuggerStepThrough]
        public static void ERROR(string message, string applicationCategory, bool showStack)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Error, applicationCategory, LoggingPriority.Error,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, showStack);
        }

        [DebuggerStepThrough]
        public static void ERROR(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Error, applicationCategory, LoggingPriority.Error,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId);
        }

        [DebuggerStepThrough]
        public static void ERROR(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Error, applicationCategory, LoggingPriority.Error,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                props);
        }

        [DebuggerStepThrough]
        public static void ERROR(Exception ex, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(ex.Message + ex.StackTrace, TraceEventType.Error, applicationCategory, LoggingPriority.Error,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, true, 
                EventId, props);
        }

        [DebuggerStepThrough]
        public static void ERROR(string message, string applicationCategory, bool showStack, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Error, applicationCategory, LoggingPriority.Error,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, showStack, 
                props);
        }

        [DebuggerStepThrough]
        public static void ERROR(string message, string applicationCategory, 
        int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Error, applicationCategory, LoggingPriority.Error,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
        }

    #endregion

        #region Log Warning Methods

        [DebuggerStepThrough]
        public static void WARNING(Exception ex, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(ex.Message + ex.StackTrace, TraceEventType.Warning, applicationCategory, LoggingPriority.Warning, method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, true);
        }

        [DebuggerStepThrough]
        public static void WARNING(Exception ex, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(ex.Message + ex.StackTrace, TraceEventType.Warning, applicationCategory, LoggingPriority.Warning,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, true, 
                props);
        }

        [DebuggerStepThrough]
        public static void WARNING(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Warning, applicationCategory, LoggingPriority.Warning,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
        }

        [DebuggerStepThrough]
        public static void WARNING(Exception ex, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(ex.Message + ex.StackTrace, TraceEventType.Warning, applicationCategory, LoggingPriority.Warning,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, true, 
                EventId);
        }

        [DebuggerStepThrough]
        public static void WARNING(string message, string applicationCategory, bool showStack)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Warning, applicationCategory, LoggingPriority.Warning,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, showStack);
        }

        [DebuggerStepThrough]
        public static void WARNING(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Warning, applicationCategory, LoggingPriority.Warning,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId);
        }

        [DebuggerStepThrough]
        public static void WARNING(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Warning, applicationCategory, LoggingPriority.Warning,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                props);
        }

        [DebuggerStepThrough]
        public static void WARNING(Exception ex, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(ex.Message + ex.StackTrace, TraceEventType.Warning, applicationCategory, LoggingPriority.Warning,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, true, 
                EventId, props);
        }

        [DebuggerStepThrough]
        public static void WARNING(string message, string applicationCategory, bool showStack, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Warning, applicationCategory, LoggingPriority.Warning,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, showStack, 
                props);
        }

        [DebuggerStepThrough]
        public static void WARNING(string message, string applicationCategory, 
        int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Warning, applicationCategory, LoggingPriority.Warning,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
        }

    #endregion

        #region Log INFO Methods

        #region INFO

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long INFOLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region INFO1

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long INFO1Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO1,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO1(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO1(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO1(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO1(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO1(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO1(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO1(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO1(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region INFO2

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long INFO2Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO2,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO2(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO2(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO2(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO2(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO2(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO2(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO2(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO2(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region INFO3

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long INFO3Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO3,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO3(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO3(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO3(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO3(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO3(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO3(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO3(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO3(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region INFO4

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long INFO4Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO4,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO4(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO4(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO4(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO4(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO4(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO4(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO4(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFO4(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.INFO4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

	    #endregion

        #region Log DEBUG Methods

        #region DEBUG

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long DEBUGLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region DEBUG1

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long DEBUG1Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG1,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG1(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG1(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG1(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG1(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG1(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG1(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG1(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG1(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region DEBUG2

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long DEBUG2Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG2,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG2(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG2(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG2(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG2(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG2(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG2(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG2(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG2(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region DEBUG3

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long DEBUG3Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG3,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG3(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG3(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG3(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG3(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG3(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG3(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG3(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG3(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region DEBUG4

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long DEBUG4Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG4,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG4(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG4(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG4(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG4(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG4(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG4(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG4(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEBUG4(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.DEBUG4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

	    #endregion

        #region Log ARCH Methods

        #region ARCH

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCHLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH1

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH1Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH1,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH1(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH1(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH1(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH1(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH1(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH1(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH1(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH1(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH2

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH2Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH2,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH2(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH2(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH2(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH2(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH2(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH2(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH2(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH2(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH3

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH3Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH3,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH3(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH3(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH3(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH3(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH3(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH3(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH3(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH3(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH4

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH4Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH4,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH4(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH4(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH4(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH4(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH4(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH4(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH4(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH4(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH5

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH5Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH5,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH5(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH5,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH5(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH5,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH5(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH5,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH5(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH5,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH5(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH5,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH5(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH5,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH5(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH5,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH5(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH5,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH6

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH6Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH6,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH6(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH6,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH6(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH6,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH6(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH6,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH6(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH6,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH6(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH6,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH6(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH6,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH6(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH6,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH6(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH6,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH7

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH7Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH7,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH7(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH7,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH7(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH7,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH7(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH7,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH7(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH7,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH7(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH7,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH7(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH7,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH7(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH7,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH7(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH7,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH8

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH8Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH8,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH8(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH8,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH8(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH8,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH8(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH8,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH8(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH8,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH8(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH8,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH8(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH8,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH8(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH8,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH8(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH8,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH9

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH9Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH9,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH9(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH9,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH9(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH9,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH9(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH9,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH9(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH9,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH9(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH9,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH9(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH9,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH9(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH9,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH9(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH9,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH10

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH10Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH10,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH10(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH10,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH10(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH10,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH10(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH10,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH10(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH10,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH10(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH10,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH10(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH10,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH10(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH10,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH10(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH10,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH11

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH11Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH11,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH11(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH11,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH11(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH11,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH11(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH11,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH11(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH11,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH11(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH11,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH11(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH11,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH11(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH11,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH11(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH11,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH12

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH12Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH12,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH12(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH12,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH12(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH12,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH12(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH12,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH12(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH12,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH12(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH12,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH12(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH12,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH12(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH12,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH12(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH12,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH13

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH13Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH13,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH13(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH13,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH13(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH13,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH13(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH13,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH13(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH13,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH13(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH13,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH13(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH13,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH13(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH13,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH13(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH13,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH14

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH14Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH14,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH14(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH14,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH14(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH14,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH14(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH14,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH14(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH14,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH14(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH14,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH14(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH14,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH14(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH14,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH14(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH14,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH15

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH15Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH15,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH15(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH15,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH15(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH15,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH15(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH15,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH15(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH15,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH15(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH15,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH15(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH15,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH15(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH15,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH15(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH15,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH16

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH16Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH16,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH16(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH16,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH16(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH16,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH16(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH16,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH16(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH16,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH16(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH16,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH16(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH16,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH16(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH16,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH16(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH16,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH17

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH17Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH17,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH17(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH17,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH17(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH17,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH17(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH17,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH17(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH17,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH17(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH17,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH17(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH17,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH17(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH17,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH17(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH17,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH18

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH18Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH18,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH18(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH18,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH18(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH18,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH18(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH18,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH18(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH18,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH18(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH18,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH18(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH18,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH18(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH18,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH18(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH18,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH19

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH19Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH19,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH19(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH19,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH19(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH19,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH19(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH19,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH19(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH19,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH19(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH19,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH19(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH19,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH19(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH19,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH19(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH19,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH20

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH20Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH20,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH20(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH20,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH20(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH20,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH20(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH20,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH20(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH20,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH20(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH20,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH20(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH20,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH20(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH20,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH20(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH20,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH21

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH21Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH21,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH21(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH21,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH21(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH21,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH21(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH21,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH21(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH21,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH21(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH21,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH21(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH21,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH21(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH21,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH21(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH21,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH22

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH22Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH22,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH22(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH22,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH22(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH22,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH22(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH22,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH22(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH22,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH22(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH22,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH22(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH22,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH22(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH22,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH22(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH22,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH23

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH23Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH23,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH23(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH23,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH23(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH23,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH23(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH23,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH23(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH23,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH23(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH23,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH23(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH23,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH23(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH23,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH23(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH23,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH24

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH24Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH24,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH24(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH24,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH24(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH24,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH24(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH24,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH24(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH24,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH24(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH24,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH24(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH24,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH24(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH24,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH24(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH24,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH25

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH25Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH25,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH25(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH25,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH25(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH25,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH25(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH25,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH25(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH25,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH25(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH25,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH25(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH25,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH25(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH25,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH25(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH25,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH26

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH26Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH26,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH26(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH26,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH26(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH26,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH26(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH26,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH26(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH26,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH26(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH26,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH26(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH26,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH26(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH26,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH26(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH26,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH27

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH27Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH27,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH27(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH27,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH27(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH27,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH27(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH27,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH27(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH27,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH27(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH27,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH27(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH27,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH27(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH27,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH27(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH27,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH28

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH28Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH28,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH28(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH28,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH28(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH28,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH28(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH28,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH28(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH28,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH28(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH28,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH28(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH28,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH28(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH28,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH28(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH28,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH29

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH29Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH29,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH29(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH29,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH29(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH29,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH29(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH29,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH29(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH29,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH29(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH29,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH29(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH29,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH29(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH29,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH29(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH29,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH30

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH30Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH30,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH30(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH30,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH30(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH30,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH30(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH30,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH30(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH30,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH30(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH30,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH30(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH30,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH30(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH30,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH30(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH30,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH31

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH31Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH31,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH31(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH31,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH31(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH31,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH31(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH31,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH31(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH31,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH31(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH31,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH31(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH31,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH31(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH31,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH31(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH31,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH32

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH32Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH32,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH32(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH32,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH32(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH32,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH32(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH32,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH32(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH32,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH32(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH32,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH32(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH32,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH32(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH32,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH32(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH32,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH33

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH33Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH33,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH33(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH33,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH33(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH33,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH33(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH33,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH33(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH33,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH33(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH33,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH33(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH33,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH33(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH33,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH33(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH33,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH34

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH34Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH34,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH34(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH34,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH34(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH34,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH34(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH34,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH34(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH34,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH34(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH34,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH34(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH34,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH34(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH34,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH34(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH34,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH35

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH35Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH35,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH35(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH35,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH35(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH35,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH35(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH35,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH35(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH35,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH35(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH35,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH35(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH35,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH35(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH35,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH35(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH35,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH36

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH36Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH36,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH36(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH36,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH36(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH36,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH36(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH36,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH36(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH36,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH36(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH36,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH36(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH36,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH36(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH36,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH36(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH36,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH37

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH37Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH37,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH37(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH37,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH37(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH37,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH37(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH37,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH37(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH37,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH37(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH37,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH37(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH37,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH37(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH37,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH37(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH37,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH38

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH38Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH38,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH38(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH38,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH38(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH38,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH38(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH38,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH38(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH38,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH38(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH38,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH38(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH38,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH38(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH38,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH38(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH38,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region ARCH39

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ARCH39Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH39,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH39(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH39,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH39(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH39,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH39(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH39,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH39(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH39,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH39(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH39,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH39(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH39,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH39(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH39,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ARCH39(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.ARCH39,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

	    #endregion

        #region Log TRACE Methods

        #region TRACE

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACELight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE1

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE1Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE1,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE1(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE1(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE1(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE1(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE1(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE1(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE1(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE1(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE1,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE2

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE2Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE2,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE2(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE2(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE2(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE2(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE2(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE2(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE2(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE2(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE2,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE3

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE3Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE3,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE3(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE3(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE3(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE3(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE3(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE3(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE3(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE3(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE3,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE4

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE4Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE4,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE4(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE4(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE4(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE4(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE4(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE4(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE4(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE4(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE4,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE5

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE5Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE5,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE5(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE5,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE5(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE5,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE5(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE5,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE5(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE5,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE5(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE5,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE5(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE5,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE5(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE5,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE5(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE5,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE6

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE6Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE6,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE6(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE6,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE6(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE6,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE6(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE6,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE6(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE6,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE6(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE6,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE6(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE6,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE6(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE6,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE6(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE6,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE7

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE7Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE7,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE7(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE7,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE7(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE7,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE7(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE7,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE7(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE7,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE7(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE7,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE7(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE7,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE7(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE7,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE7(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE7,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE8

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE8Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE8,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE8(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE8,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE8(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE8,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE8(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE8,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE8(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE8,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE8(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE8,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE8(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE8,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE8(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE8,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE8(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE8,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE9

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE9Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE9,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE9(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE9,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE9(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE9,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE9(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE9,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE9(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE9,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE9(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE9,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE9(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE9,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE9(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE9,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE9(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE9,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE10

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE10Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE10,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE10(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE10,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE10(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE10,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE10(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE10,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE10(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE10,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE10(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE10,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE10(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE10,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE10(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE10,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE10(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE10,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE11

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE11Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE11,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE11(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE11,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE11(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE11,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE11(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE11,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE11(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE11,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE11(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE11,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE11(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE11,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE11(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE11,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE11(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE11,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE12

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE12Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE12,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE12(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE12,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE12(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE12,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE12(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE12,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE12(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE12,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE12(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE12,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE12(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE12,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE12(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE12,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE12(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE12,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE13

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE13Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE13,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE13(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE13,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE13(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE13,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE13(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE13,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE13(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE13,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE13(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE13,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE13(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE13,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE13(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE13,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE13(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE13,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE14

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE14Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE14,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE14(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE14,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE14(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE14,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE14(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE14,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE14(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE14,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE14(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE14,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE14(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE14,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE14(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE14,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE14(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE14,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE15

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE15Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE15,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE15(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE15,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE15(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE15,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE15(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE15,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE15(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE15,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE15(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE15,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE15(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE15,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE15(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE15,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE15(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE15,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE16

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE16Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE16,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE16(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE16,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE16(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE16,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE16(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE16,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE16(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE16,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE16(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE16,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE16(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE16,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE16(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE16,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE16(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE16,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE17

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE17Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE17,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE17(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE17,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE17(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE17,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE17(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE17,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE17(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE17,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE17(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE17,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE17(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE17,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE17(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE17,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE17(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE17,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE18

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE18Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE18,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE18(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE18,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE18(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE18,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE18(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE18,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE18(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE18,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE18(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE18,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE18(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE18,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE18(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE18,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE18(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE18,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE19

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE19Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE19,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE19(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE19,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE19(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE19,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE19(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE19,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE19(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE19,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE19(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE19,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE19(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE19,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE19(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE19,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE19(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE19,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE20

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE20Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE20,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE20(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE20,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE20(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE20,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE20(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE20,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE20(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE20,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE20(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE20,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE20(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE20,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE20(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE20,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE20(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE20,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE21

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE21Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE21,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE21(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE21,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE21(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE21,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE21(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE21,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE21(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE21,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE21(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE21,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE21(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE21,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE21(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE21,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE21(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE21,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE22

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE22Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE22,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE22(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE22,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE22(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE22,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE22(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE22,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE22(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE22,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE22(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE22,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE22(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE22,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE22(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE22,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE22(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE22,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE23

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE23Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE23,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE23(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE23,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE23(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE23,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE23(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE23,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE23(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE23,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE23(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE23,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE23(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE23,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE23(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE23,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE23(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE23,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE24

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE24Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE24,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE24(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE24,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE24(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE24,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE24(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE24,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE24(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE24,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE24(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE24,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE24(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE24,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE24(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE24,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE24(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE24,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE25

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE25Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE25,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE25(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE25,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE25(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE25,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE25(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE25,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE25(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE25,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE25(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE25,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE25(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE25,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE25(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE25,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE25(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE25,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE26

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE26Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE26,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE26(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE26,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE26(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE26,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE26(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE26,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE26(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE26,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE26(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE26,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE26(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE26,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE26(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE26,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE26(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE26,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE27

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE27Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE27,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE27(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE27,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE27(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE27,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE27(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE27,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE27(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE27,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE27(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE27,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE27(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE27,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE27(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE27,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE27(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE27,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE28

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE28Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE28,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE28(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE28,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE28(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE28,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE28(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE28,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE28(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE28,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE28(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE28,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE28(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE28,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE28(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE28,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE28(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE28,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

        #region TRACE29

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TRACE29Light(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE29,
                "<unknown>", "<unknown>", "<unknown>", false); 
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE29(string message, string applicationCategory, 
                                            MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE29,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE29(string message, string applicationCategory, 
                                            Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE29,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE29(string message, string applicationCategory, 
                                            int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE29,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE29(string message, string applicationCategory, 
                                            long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE29,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE29(string message, string applicationCategory, 
                                            int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE29,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE29(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE29,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE29(string message, string applicationCategory, 
                                            Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE29,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TRACE29(string message, string applicationCategory, 
                                            int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();
            InternalWrite(message, TraceEventType.Information, applicationCategory, LoggingPriority.TRACE29,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, EventId, props, startTicks);
            return Stopwatch.GetTimestamp();
        }

	    #endregion

	    #endregion

        public static double GetDuration(long startTicks)
        {
            return (double)(Stopwatch.GetTimestamp() - startTicks) / ((double)Stopwatch.Frequency);
        }

        public static double GetDuration(long startTicks, long endTicks)
        {
            return (double)(endTicks - startTicks) / ((double)Stopwatch.Frequency);
        }
    }
}