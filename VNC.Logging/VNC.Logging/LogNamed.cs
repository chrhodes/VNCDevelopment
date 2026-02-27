/// <summary>
/// Low level routines used by client and web applications
/// This file produces the NAMED Log.NAMED_METHOD calls that are defined in
/// Log.LoggingPriority
/// 
/// </summary>
namespace VNC
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Reflection;

    using Microsoft.Practices.EnterpriseLibrary.Logging;
    
    public partial class Log
    {
		#region APPLICATION_START

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long APPLICATION_STARTLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_START,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_START(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_START,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_START(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_START,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_START(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_START,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_START(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_START,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_START(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_START,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_START(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_START,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_START(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_START,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_START(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_START,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region APPLICATION_END

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long APPLICATION_ENDLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_END,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_END(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_END,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_END(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_END,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_END(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_END,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_END(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_END,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_END(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_END,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_END(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_END,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_END(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_END,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_END(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_END,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region LOADEASE

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long LOADEASELight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LOADEASE,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LOADEASE(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LOADEASE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LOADEASE(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LOADEASE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LOADEASE(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LOADEASE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LOADEASE(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LOADEASE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LOADEASE(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LOADEASE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LOADEASE(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LOADEASE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LOADEASE(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LOADEASE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LOADEASE(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LOADEASE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region SQL_CALL

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long SQL_CALLLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SQL_CALL,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SQL_CALL(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SQL_CALL,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SQL_CALL(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SQL_CALL,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SQL_CALL(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SQL_CALL,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SQL_CALL(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SQL_CALL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SQL_CALL(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SQL_CALL,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SQL_CALL(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SQL_CALL,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SQL_CALL(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SQL_CALL,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SQL_CALL(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SQL_CALL,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region PAGE_LOAD

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long PAGE_LOADLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PAGE_LOAD,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PAGE_LOAD(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PAGE_LOAD,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PAGE_LOAD(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PAGE_LOAD,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PAGE_LOAD(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PAGE_LOAD,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PAGE_LOAD(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PAGE_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PAGE_LOAD(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PAGE_LOAD,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PAGE_LOAD(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PAGE_LOAD,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PAGE_LOAD(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PAGE_LOAD,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PAGE_LOAD(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PAGE_LOAD,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region FORM_LOAD

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long FORM_LOADLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FORM_LOAD,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FORM_LOAD(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FORM_LOAD,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FORM_LOAD(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FORM_LOAD,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FORM_LOAD(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FORM_LOAD,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FORM_LOAD(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FORM_LOAD,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FORM_LOAD(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FORM_LOAD,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FORM_LOAD(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FORM_LOAD,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FORM_LOAD(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FORM_LOAD,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FORM_LOAD(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FORM_LOAD,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region STATUS

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long STATUSLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.STATUS,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long STATUS(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.STATUS,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long STATUS(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.STATUS,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long STATUS(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.STATUS,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long STATUS(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.STATUS,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long STATUS(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.STATUS,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long STATUS(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.STATUS,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long STATUS(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.STATUS,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long STATUS(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.STATUS,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region REDIRECT_TRANSFER

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long REDIRECT_TRANSFERLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.REDIRECT_TRANSFER,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long REDIRECT_TRANSFER(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.REDIRECT_TRANSFER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long REDIRECT_TRANSFER(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.REDIRECT_TRANSFER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long REDIRECT_TRANSFER(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.REDIRECT_TRANSFER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long REDIRECT_TRANSFER(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.REDIRECT_TRANSFER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long REDIRECT_TRANSFER(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.REDIRECT_TRANSFER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long REDIRECT_TRANSFER(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.REDIRECT_TRANSFER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long REDIRECT_TRANSFER(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.REDIRECT_TRANSFER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long REDIRECT_TRANSFER(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.REDIRECT_TRANSFER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region POLLING

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long POLLINGLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.POLLING,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long POLLING(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.POLLING,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long POLLING(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.POLLING,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long POLLING(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.POLLING,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long POLLING(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.POLLING,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long POLLING(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.POLLING,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long POLLING(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.POLLING,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long POLLING(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.POLLING,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long POLLING(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.POLLING,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region ERROR_TRACE

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ERROR_TRACELight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region ERROR_TRACE_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long ERROR_TRACE_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long ERROR_TRACE_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.ERROR_TRACE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region EASESYS_IO

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long EASESYS_IOLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region EASESYS_IO_MED

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long EASESYS_IO_MEDLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_MED,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_MED(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_MED,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_MED(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_MED,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_MED(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_MED,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_MED(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_MED(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_MED,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_MED(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_MED,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_MED(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_MED,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_MED(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_MED,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region EASESYS_IO_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long EASESYS_IO_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EASESYS_IO_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EASESYS_IO_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region UI_CONTROL

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long UI_CONTROLLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region UI_CONTROL_MED

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long UI_CONTROL_MEDLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_MED,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_MED(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_MED,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_MED(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_MED,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_MED(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_MED,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_MED(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_MED(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_MED,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_MED(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_MED,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_MED(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_MED,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_MED(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_MED,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region UI_CONTROL_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long UI_CONTROL_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UI_CONTROL_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UI_CONTROL_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region UTILITY

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long UTILITYLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region UTILITY_MED

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long UTILITY_MEDLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_MED,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_MED(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_MED,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_MED(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_MED,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_MED(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_MED,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_MED(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_MED,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_MED(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_MED,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_MED(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_MED,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_MED(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_MED,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_MED(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_MED,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region UTILITY_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long UTILITY_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long UTILITY_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.UTILITY_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region OPERATION

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long OPERATIONLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region OPERATION_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long OPERATION_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long OPERATION_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.OPERATION_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region APPLICATION_SESSION

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long APPLICATION_SESSIONLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region APPLICATION_SESSION_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_SESSION_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_SESSION_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region SYSTEM_CONFIG

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIGLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region SYSTEM_CONFIG_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYSTEM_CONFIG_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYSTEM_CONFIG_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region FILE_DIR_IO

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long FILE_DIR_IOLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region FILE_DIR_IO_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long FILE_DIR_IO_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long FILE_DIR_IO_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.FILE_DIR_IO_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region DATABASE_IO

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long DATABASE_IOLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region DATABASE_IO_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long DATABASE_IO_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DATABASE_IO_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DATABASE_IO_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region SECURITY

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long SECURITYLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region SECURITY_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long SECURITY_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SECURITY_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SECURITY_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region CLEAR_INITIALIZE

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long CLEAR_INITIALIZELight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CLEAR_INITIALIZE,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CLEAR_INITIALIZE(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CLEAR_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CLEAR_INITIALIZE(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CLEAR_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CLEAR_INITIALIZE(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CLEAR_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CLEAR_INITIALIZE(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CLEAR_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CLEAR_INITIALIZE(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CLEAR_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CLEAR_INITIALIZE(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CLEAR_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CLEAR_INITIALIZE(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CLEAR_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CLEAR_INITIALIZE(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CLEAR_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region EVENT

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long EVENTLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region EVENT_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long EVENT_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region EVENT_HANDLER

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long EVENT_HANDLERLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region EVENT_HANDLER_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long EVENT_HANDLER_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVENT_HANDLER_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVENT_HANDLER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region APPLICATION_INITIALIZE

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZELight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZE(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZE(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZE(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZE(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZE(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZE(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZE(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZE(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region APPLICATION_INITIALIZE_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZE_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZE_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZE_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZE_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZE_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZE_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZE_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZE_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_INITIALIZE_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_INITIALIZE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region CORE

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long CORELight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CORE,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CORE(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CORE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CORE(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CORE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CORE(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CORE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CORE(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CORE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CORE(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CORE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CORE(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CORE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CORE(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CORE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CORE(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CORE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region MODULE

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long MODULELight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region MODULE_INITIALIZE

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long MODULE_INITIALIZELight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE_INITIALIZE,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE_INITIALIZE(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE_INITIALIZE(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE_INITIALIZE(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE_INITIALIZE(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE_INITIALIZE(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE_INITIALIZE(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE_INITIALIZE(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long MODULE_INITIALIZE(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.MODULE_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region DEVICE_INITIALIZE

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long DEVICE_INITIALIZELight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEVICE_INITIALIZE,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEVICE_INITIALIZE(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEVICE_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEVICE_INITIALIZE(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEVICE_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEVICE_INITIALIZE(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEVICE_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEVICE_INITIALIZE(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEVICE_INITIALIZE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEVICE_INITIALIZE(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEVICE_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEVICE_INITIALIZE(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEVICE_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEVICE_INITIALIZE(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEVICE_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEVICE_INITIALIZE(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEVICE_INITIALIZE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region DEVICE_INITIALIZE_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long DEVICE_INITIALIZE_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEVICE_INITIALIZE_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEVICE_INITIALIZE_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEVICE_INITIALIZE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEVICE_INITIALIZE_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEVICE_INITIALIZE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEVICE_INITIALIZE_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEVICE_INITIALIZE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEVICE_INITIALIZE_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEVICE_INITIALIZE_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEVICE_INITIALIZE_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEVICE_INITIALIZE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEVICE_INITIALIZE_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEVICE_INITIALIZE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEVICE_INITIALIZE_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEVICE_INITIALIZE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEVICE_INITIALIZE_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEVICE_INITIALIZE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region APPLICATION

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long APPLICATIONLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region APPLICATION_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long APPLICATION_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATION_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATION_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region APPLICATIONSERVICES

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICESLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICES(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICES(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICES(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICES(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICES(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICES(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICES(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICES(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region APPLICATIONSERVICES_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICES_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICES_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICES_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICES_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICES_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICES_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICES_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICES_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long APPLICATIONSERVICES_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.APPLICATIONSERVICES_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region DOMAIN

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long DOMAINLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAIN(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAIN(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAIN(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAIN(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAIN(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAIN(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAIN(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAIN(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region DOMAIN_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long DOMAIN_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAIN_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAIN_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAIN_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAIN_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAIN_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAIN_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAIN_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAIN_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAIN_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region DOMAINSERVICES

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long DOMAINSERVICESLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAINSERVICES(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAINSERVICES(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAINSERVICES(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAINSERVICES(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAINSERVICES(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAINSERVICES(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAINSERVICES(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAINSERVICES(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region DOMAINSERVICES_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long DOMAINSERVICES_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAINSERVICES_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAINSERVICES_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAINSERVICES_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAINSERVICES_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAINSERVICES_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAINSERVICES_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAINSERVICES_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DOMAINSERVICES_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DOMAINSERVICES_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region PERSISTENCE

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long PERSISTENCELight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PERSISTENCE(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PERSISTENCE(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PERSISTENCE(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PERSISTENCE(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PERSISTENCE(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PERSISTENCE(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PERSISTENCE(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PERSISTENCE(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region PERSISTENCE_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long PERSISTENCE_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PERSISTENCE_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PERSISTENCE_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PERSISTENCE_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PERSISTENCE_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PERSISTENCE_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PERSISTENCE_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PERSISTENCE_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PERSISTENCE_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PERSISTENCE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region INFRASTRUCTURE

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long INFRASTRUCTURELight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.INFRASTRUCTURE,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFRASTRUCTURE(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.INFRASTRUCTURE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFRASTRUCTURE(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.INFRASTRUCTURE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFRASTRUCTURE(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.INFRASTRUCTURE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFRASTRUCTURE(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.INFRASTRUCTURE,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFRASTRUCTURE(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.INFRASTRUCTURE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFRASTRUCTURE(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.INFRASTRUCTURE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFRASTRUCTURE(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.INFRASTRUCTURE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFRASTRUCTURE(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.INFRASTRUCTURE,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region INFRASTRUCTURE_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long INFRASTRUCTURE_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.INFRASTRUCTURE_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFRASTRUCTURE_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.INFRASTRUCTURE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFRASTRUCTURE_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.INFRASTRUCTURE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFRASTRUCTURE_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.INFRASTRUCTURE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFRASTRUCTURE_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.INFRASTRUCTURE_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFRASTRUCTURE_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.INFRASTRUCTURE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFRASTRUCTURE_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.INFRASTRUCTURE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFRASTRUCTURE_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.INFRASTRUCTURE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long INFRASTRUCTURE_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.INFRASTRUCTURE_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region PRESENTATION

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long PRESENTATIONLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PRESENTATION,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PRESENTATION(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PRESENTATION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PRESENTATION(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PRESENTATION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PRESENTATION(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PRESENTATION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PRESENTATION(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PRESENTATION,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PRESENTATION(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PRESENTATION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PRESENTATION(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PRESENTATION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PRESENTATION(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PRESENTATION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PRESENTATION(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PRESENTATION,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region VIEW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long VIEWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region VIEW_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long VIEW_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEW_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEW_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region VIEWMODEL

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long VIEWMODELLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region VIEWMODEL_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long VIEWMODEL_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long VIEWMODEL_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.VIEWMODEL_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region SYNTAX

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long SYNTAXLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYNTAX(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYNTAX(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYNTAX(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYNTAX(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYNTAX(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYNTAX(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYNTAX(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYNTAX(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region SYNTAX_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long SYNTAX_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYNTAX_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYNTAX_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYNTAX_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYNTAX_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYNTAX_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYNTAX_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYNTAX_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long SYNTAX_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.SYNTAX_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region LEXER

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long LEXERLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LEXER(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LEXER(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LEXER(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LEXER(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LEXER(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LEXER(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LEXER(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LEXER(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region LEXER_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long LEXER_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LEXER_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LEXER_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LEXER_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LEXER_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LEXER_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LEXER_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LEXER_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long LEXER_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.LEXER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region PARSER

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long PARSERLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PARSER(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PARSER(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PARSER(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PARSER(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PARSER(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PARSER(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PARSER(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PARSER(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region PARSER_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long PARSER_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PARSER_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PARSER_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PARSER_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PARSER_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PARSER_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PARSER_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PARSER_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long PARSER_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.PARSER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region BINDER

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long BINDERLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long BINDER(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long BINDER(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long BINDER(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long BINDER(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long BINDER(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long BINDER(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long BINDER(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long BINDER(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region BINDER_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long BINDER_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long BINDER_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long BINDER_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long BINDER_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long BINDER_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long BINDER_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long BINDER_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long BINDER_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long BINDER_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.BINDER_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region EVALUATOR

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long EVALUATORLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVALUATOR,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVALUATOR(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVALUATOR,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVALUATOR(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVALUATOR,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVALUATOR(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVALUATOR,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVALUATOR(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVALUATOR,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVALUATOR(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVALUATOR,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVALUATOR(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVALUATOR,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVALUATOR(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVALUATOR,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long EVALUATOR(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.EVALUATOR,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region TEXT

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TEXTLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEXT,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TEXT(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEXT,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TEXT(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEXT,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TEXT(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEXT,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TEXT(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEXT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TEXT(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEXT,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TEXT(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEXT,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TEXT(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEXT,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TEXT(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEXT,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region TEXT_LOW

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TEXT_LOWLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEXT_LOW,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TEXT_LOW(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEXT_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TEXT_LOW(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEXT_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TEXT_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEXT_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TEXT_LOW(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEXT_LOW,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TEXT_LOW(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEXT_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TEXT_LOW(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEXT_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TEXT_LOW(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEXT_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TEXT_LOW(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEXT_LOW,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region COMPILER

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long COMPILERLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.COMPILER,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long COMPILER(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.COMPILER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long COMPILER(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.COMPILER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long COMPILER(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.COMPILER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long COMPILER(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.COMPILER,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long COMPILER(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.COMPILER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long COMPILER(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.COMPILER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long COMPILER(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.COMPILER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long COMPILER(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.COMPILER,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region DIAGNOSTIC

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long DIAGNOSTICLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DIAGNOSTIC,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DIAGNOSTIC(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DIAGNOSTIC,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DIAGNOSTIC(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DIAGNOSTIC,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DIAGNOSTIC(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DIAGNOSTIC,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DIAGNOSTIC(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DIAGNOSTIC,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DIAGNOSTIC(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DIAGNOSTIC,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DIAGNOSTIC(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DIAGNOSTIC,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DIAGNOSTIC(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DIAGNOSTIC,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DIAGNOSTIC(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DIAGNOSTIC,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region TEST

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long TESTLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEST,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TEST(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEST,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TEST(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEST,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TEST(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEST,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TEST(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEST,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TEST(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEST,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TEST(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEST,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TEST(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEST,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long TEST(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.TEST,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

		#region DEFAULT

        // This is a light weight call
        // MethodInfo is not used, so we use "<unknown>" for class, method, and callingAssembly names.

        [DebuggerStepThrough]
        public static long DEFAULTLight(string message, string applicationCategory)
        {
            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEFAULT,
                          "<unknown>", "<unknown>", "<unknown>", false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEFAULT(string message, string applicationCategory)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEFAULT,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEFAULT(string message, string applicationCategory, 
                                             int EventId)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEFAULT,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false,
                          EventId);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEFAULT(string message, string applicationCategory, 
                                             Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEFAULT,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEFAULT(string message, string applicationCategory, 
                                             int EventId, Dictionary<string, string> props)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEFAULT,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                EventId, props);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEFAULT(string message, string applicationCategory, 
                                             long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEFAULT,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEFAULT(string message, string applicationCategory, 
                                             int EventId, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEFAULT,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEFAULT(string message, string applicationCategory, 
                                             Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEFAULT,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long DEFAULT(string message, string applicationCategory, int EventId, Dictionary<string, string> props, long startTicks)
        {
            MethodBase method = new StackFrame(1).GetMethod();

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.DEFAULT,
                          method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, 
                          EventId, props, startTicks);

            return Stopwatch.GetTimestamp();
        }

        #endregion

	        // NOTE(crhodes)
        //
        // Special handling for LOG.CONSTRUCTOR
        //
        // This is for the case where Release Builds and Dependency Injection use lambdas.
        // Lambda's have a null ReflectedType.  The ReflectedType gets the name of the Type containing the method
        // Go up one level on the stack to see if we find a proper methods.
        //
        // N.B. For now, only support these two.  Later may decide to just put this in the general routines.

        [DebuggerStepThrough]
        public static long CONSTRUCTOR(string message, string applicationCategory, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            if (method.ReflectedType is null)
            {
                method = new StackFrame(2).GetMethod();
                // Leave a mark we got fancy.
                message = $"{message}-lambda caller";
            }

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CONSTRUCTOR,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false);
            return Stopwatch.GetTimestamp();
        }

        [DebuggerStepThrough]
        public static long CONSTRUCTOR(string message, string applicationCategory, long startTicks, MethodBase method = null)
        {
            if (method == null) method = new StackFrame(1).GetMethod();

            if (method.ReflectedType is null)
            {
                method = new StackFrame(2).GetMethod();
                // Leave a mark we got fancy.
                message = $"{message}-lambda caller";
            }

            InternalWrite(message, TraceEventType.Verbose, applicationCategory, LoggingPriority.CONSTRUCTOR,
                method.ReflectedType.Name, method.Name, Assembly.GetCallingAssembly().GetName().Name, false, startTicks);
            return Stopwatch.GetTimestamp();
        }
	}
}