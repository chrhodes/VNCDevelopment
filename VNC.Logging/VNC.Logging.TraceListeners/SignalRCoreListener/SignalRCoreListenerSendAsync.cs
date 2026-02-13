using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging.Configuration;

namespace VNC.Logging.TraceListeners
{
    [ConfigurationElementType(typeof(CustomTraceListenerData))]
    public class SignalRCoreListenerSendAsync : Microsoft.Practices.EnterpriseLibrary.Logging.TraceListeners.CustomTraceListener
    {
        #region Constructors, Initialization, and Load

        public SignalRCoreListenerSendAsync()
        {
            ConnectAsync();
        }

        public SignalRCoreListenerSendAsync(string duration)
        {
            maxDuration = double.Parse(duration);

            ConnectAsync();
        }

        #endregion

        #region Enums (None)


        #endregion

        #region Structures (None)


        #endregion

        #region Fields and Properties

        private const string LOG_APPNAME = "VNCLoggingListener";

        private string sLoggingDbConString = string.Empty;
        private int iSQLCommandTimeoutInSecs = 300;
        private Int32 iPriority = 0;
        private string sEntryID = string.Empty;
        private string sMachineName = string.Empty;
        private string sUserName = string.Empty;
        private string sApplicationName = string.Empty;
        private string sCategoryName = string.Empty;
        private string sSeverity_TC = string.Empty;
        private string sMessage_Text = string.Empty;
        private string sSessionID = string.Empty;
        private string sThreadID = string.Empty;
        private string sExecutableName = string.Empty;
        private string sCallstack = string.Empty;
        private double dPerformance = 0.00;
        private int iEventID = 0;

        private double maxDuration = -1; // Log if greater than this time.

        string[] _supportedCustomAttributes = new string[] {
            "maxDuration", "MaxDuration", "maxduration",
            "suppressEnter", "SuppressEnter", "suppressenter" };

        public IDisposable SignalR { get; set; }

        protected override string[] GetSupportedAttributes()
        {
            return _supportedCustomAttributes;
        }

        public double MaxDuration
        {
            get
            {
                if (maxDuration < 0)
                {
                    // Initialize from the custom attributes

                    var key = Attributes.Keys.Cast<string>().
                    FirstOrDefault(s => string.Equals(s, "maxduration", StringComparison.InvariantCultureIgnoreCase));

                    if (!string.IsNullOrWhiteSpace(key))
                    {
                        double.TryParse(Attributes[key], out maxDuration);
                    }
                }

                return maxDuration;
            }
        }

        private bool? suppressEnter = null;

        public bool SuppressEnter
        {
            get
            {
                if (suppressEnter == null)
                {
                    // Initialize from the custom attributes

                    var key = Attributes.Keys.Cast<string>().
                    FirstOrDefault(s => string.Equals(s, "suppressenter", StringComparison.InvariantCultureIgnoreCase));

                    if (!string.IsNullOrWhiteSpace(key))
                    {
                        bool suppress = false;
                        bool.TryParse(Attributes[key], out suppress);
                        suppressEnter = suppress;
                    }
                }

                return (bool)suppressEnter;
            }
        }

        public String UserName { get; set; }

        // TODO(crhodes)
        // Consider passing the Server URI as a custom attribute.
        // This would allow the listener to be used with any SignalR server.

        const string ServerURI = "http://localhost:58195/signalr";

        public HubConnection Connection { get; set; }

        #endregion

        #region Event Handlers

        private Task Connection_Closed(Exception arg)
        {
            //throw new NotImplementedException();
            return null;
        }

        private Task Connection_Reconnecting(Exception arg)
        {
            //throw new NotImplementedException();
            return null;
        }

        private Task Connection_Reconnected(string arg)
        {
            //throw new NotImplementedException();
            return null;
        }

        #endregion

        #region Commands (None)

        #endregion

        #region Public Methods

        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data)
        {
            if (data is LogEntry && this.Formatter != null)
            {
                try
                {
                    LogEntry e = (LogEntry)data;
                    this.iPriority = e.Priority;
                    this.sEntryID = System.Guid.NewGuid().ToString();
                    this.sMachineName = e.MachineName;
                    this.sApplicationName = e.CategoriesStrings[0];
                    this.iEventID = e.EventId;
                    this.sCategoryName = e.CategoriesStrings[0];
                    this.sSeverity_TC = e.Severity.ToString();
                    this.sMessage_Text = e.Message;
                    this.sThreadID = e.Win32ThreadId;

                    foreach (KeyValuePair<string, Object> kvp in e.ExtendedProperties)
                    {
                        switch (kvp.Key.ToString())
                        {
                            case "User Name":
                                {
                                    this.sUserName = kvp.Value.ToString();
                                    break;
                                }
                            case "Calling Assembly":
                                {

                                    this.sExecutableName = kvp.Value.ToString();
                                    break;
                                }
                            case "Stack":
                                {
                                    this.sCallstack = kvp.Value.ToString();
                                    break;
                                }
                            case "Duration":
                                {
                                    this.dPerformance = Convert.ToDouble(kvp.Value);
                                    break;
                                }
                            default:
                                {
                                    break;
                                }
                        }
                    }

                    string message = this.Formatter.Format(data as LogEntry);

                    this.WriteLine(message);

                    //if (dPerformance > MaxDuration)
                    //{
                    //    this.WriteLine(message);
                    //    dPerformance = 0;
                    //}
                    //else if (message.Contains("Enter"))
                    //{
                    //    if (!SuppressEnter)
                    //    {
                    //        this.WriteLine(message);
                    //    }
                    //}
                    //else
                    //{
                    //    this.WriteLine("Hum" + message);
                    //}

                    //this.WriteLine(this.Formatter.Format(data as LogEntry));
                    //Insert Log entry
                    //InsertLogEntryIntoDb();

                    //foreach (KeyValuePair<string, Object> kvp in dictionary)
                    //{
                    //    InsertExtraData(kvp.Key, kvp.Value.ToString());
                    //}
                }
                catch (Exception ex)
                {
                    //Log.Error(ex, LOG_APPNAME);
                    //throw new LoggingException(ex.Message);
                    var errorMessage = ex.ToString();
                    //EventLog.WriteEntry("CustomDatabaseTraceListener", ex.Message, EventLogEntryType.Information);

                }
                finally
                {
                    //dictionary.Clear();
                    //dictionary = null;
                }
            }
            else
            {
                this.Write("not LogEntry");
                this.WriteLine(data.ToString());
                //Not a LogEntry. Ignore
            }
        }

        public async override void Write(string message)
        {
            try
            {
                await Connection.SendAsync("SendPriorityMessage", message, iPriority);
                //Connection.InvokeAsync("SendPriorityMessage", message, iPriority);
            }
            //catch (InvalidOperationException)
            //{
            //    // Logging framework likely spins up worker threads that are killed
            //    // if not active.  When that happens we need to start again.

            //    ConnectAsync();

            //    // Send the message so it doesn't get lost

            //    Connection.SendAsync("SendPriorityMessage", message, iPriority);
            //}
            catch (Exception ex)
            {
                //Log.Error(ex, LOG_APPNAME);
                var errorMessage = ex.ToString();
                //client.DisplayLogEntry(string.Format("SRLWex: {0}", ex.ToString()));
            }
        }

        public async override void WriteLine(string message)
        {
            try
            {
                //Connection.SendAsync("SendMessage", "FOOBAR");
                //Connection.SendAsync("SendPriorityMessage", "FOOBAR", iPriority);
                await Connection.SendAsync("SendPriorityMessage", message, iPriority);
                //Connection.InvokeAsync("SendPriorityMessage", message, iPriority);
            }
            //catch (System.InvalidOperationException)
            //{
            //    // Logging framework likely spins up worker threads that are killed
            //    // if not active.  When that happens we need to start again.
            //    // This seems less likely.

            //    // Calling ConnectAsync gives us two clients.

            //    //ConnectAsync();

            //    // Send the message so it doesn't get lost

            //    switch (Connection.State)
            //    {
            //        case HubConnectionState.Connected:
            //            Connection.SendAsync("SendPriorityMessage", message, iPriority);
            //            break;

            //        case HubConnectionState.Connecting:

            //            break;

            //        case HubConnectionState.Reconnecting:

            //            break;

            //        case HubConnectionState.Disconnected:
            //            ConnectAsync();
            //            break;
            //    }
            //}
            catch (Exception ex)
            {
                var errorMessage = ex.ToString();
            }
        }

        #endregion

        #region Protected Methods (None)


        #endregion

        #region Private Methods

        private async void ConnectAsync()
        {
            Connection = new HubConnectionBuilder()
                .WithUrl(ServerURI)
                .AddMessagePackProtocol()
                .Build();

            Connection.Closed += Connection_Closed;
            Connection.Reconnected += Connection_Reconnected;
            Connection.Reconnecting += Connection_Reconnecting;

            Connection.On<string>("AddMessage", (message) => { } );

            Connection.On<string, string>("AddUserMessage", (name, message) => { } );

            Connection.On<string, Int32>("AddPriorityMessage", (message, priority) => { } );

            try
            {
                await Connection.StartAsync();
            }
            catch (HttpRequestException ex)
            {
                var errorMessage = ex.ToString();
                return;
            }
            catch (Exception ex)
            {
                var errorMessage = ex.ToString();
            }
        }

        #endregion
    }
}
