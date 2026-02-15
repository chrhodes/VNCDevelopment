using System;
using System.Diagnostics;

using System.Threading.Tasks;
using System.Windows;

#if NET481
using Microsoft.AspNet.SignalR;
#else
using Microsoft.AspNetCore.SignalR;
using System.Reflection.PortableExecutable;
#endif

namespace VNCSignalRServerHub
{
    public class SignalRHub : Hub
    {
        public async Task IdentifyUser(string userName)
        {
            string message = $"connectionID:>{Context.ConnectionId}< userName:>{userName}<";

            // NOTE(crhodes)
            // Recommended practice is to use Groups for sending messages to specific users.
            // Clients.User() is not recommended.
            try
            {
#if NET481
                // TODO(crhodes)
                // Is this supported in .NET Framework?  If not, need to remove from UI.
#else
                await Groups.AddToGroupAsync(Context.ConnectionId, userName);
#endif
                await Clients.All.SendAsync("AddMessage", message);
            }
            catch (Exception ex)
            {
                Application.Current.Dispatcher.Invoke(() =>
                    ((MainWindow)Application.Current.MainWindow).WriteToConsole(ex.ToString()));
            }
        }

        public async Task JoinGroup(string groupName)
        {
            string message = $"connectionID:>{Context.ConnectionId}< groupName:>{groupName}<";

            try
            {
#if NET481
                // TODO(crhodes)
                // Is this supported in .NET Framework?  If not, need to remove from UI.
#else
                await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
#endif
                await Clients.All.SendAsync("AddMessage", message);
            }
            catch (Exception ex)
            {
                Application.Current.Dispatcher.Invoke(() =>
                    ((MainWindow)Application.Current.MainWindow).WriteToConsole(ex.ToString()));
            }
        }

#if NET481
        public void SendMessage(string message)
        {
            try
            {
                Clients.All.addMessage(message);
            }
            catch (Exception ex)
            {
                Application.Current.Dispatcher.Invoke(() =>
                    ((MainWindow) Application.Current.MainWindow).WriteToConsole(ex.ToString()));
            }
}
#else
        public async Task SendMessage(string message)
        {
            try
            {
                await Clients.All.SendAsync("AddMessage", message);
            }
            catch (Exception ex)
            {
                Application.Current.Dispatcher.Invoke(() =>
                    ((MainWindow)Application.Current.MainWindow).WriteToConsole(ex.ToString()));
            }            
        }
#endif

        // NOTE(crhodes)
        // Priority Messages are from Logging.  No need to send back to sender.

#if NET481
        public void SendPriorityMessage(string message, Int32 priority)
        {
            try
            {                
                //Clients.All.addPriorityMessage(message, priority);
                Clients.Others.addPriorityMessage(message, priority);
            }
            catch (Exception ex)
            {
                Application.Current.Dispatcher.Invoke(() =>
                    ((MainWindow)Application.Current.MainWindow).WriteToConsole(ex.ToString()));
            }
        }
#else

        public async void SendPriorityMessage(string message, Int32 priority)
        {
            try
            {
                //await Clients.All.SendAsync("AddPriorityMessage", message, priority);
                await Clients.Others.SendAsync("AddPriorityMessage", message, priority);
            }
            catch (Exception ex)
            {
                Application.Current.Dispatcher.Invoke(() =>
                    ((MainWindow)Application.Current.MainWindow).WriteToConsole(ex.ToString()));
            }
        }
#endif

#if NET481
        public void SendTimedMessage(string message, SignalRTime signalRTime)
        {
            try
            {
                signalRTime.HubReceivedTime = DateTime.Now;
                signalRTime.HubReceivedTicks = Stopwatch.GetTimestamp();

                Clients.All.addTimedMessage(message, signalRTime);
            }
            catch (Exception ex)
            {
                Application.Current.Dispatcher.Invoke(() =>
                    ((MainWindow)Application.Current.MainWindow).WriteToConsole(ex.ToString()));
            }
        }
#else
        public async void SendTimedMessage(string message, SignalRTime signalRTime)
        {
            try
            {
                signalRTime.HubReceivedTime = DateTime.Now;
                signalRTime.HubReceivedTicks = Stopwatch.GetTimestamp();

                await Clients.All.SendAsync("AddTimedMessage", message, signalRTime);
            }
            catch (Exception ex)
            {
                Application.Current.Dispatcher.Invoke(() =>
                    ((MainWindow)Application.Current.MainWindow).WriteToConsole(ex.ToString()));
            }
        }
#endif

#if NET481
        public void SendUserMessage(string name, string message)
        {
            Clients.All.addUserMessage(name, message);
        }
#else
        public async Task SendUserMessage(string userName, string message)
        {       
            try
            {
                await Clients.All.SendAsync("AddUserMessage", userName, message);
            }
            catch (Exception ex)
            {
                Application.Current.Dispatcher.Invoke(() =>
                    ((MainWindow)Application.Current.MainWindow).WriteToConsole(ex.ToString()));
            }
        }
#endif

#if NET481
        public void SendPrivateMessage(string userName, string message)
        {
            Clients.All.addPrivateMessage(userName, message);
        }
#else
        public async Task SendPrivateMessage(string userName, string message)
        {
            try
            {
                //await Clients.User(userName).SendAsync("AddPrivateMessage", userName, message);
                // NOTE(crhodes)
                // Recommended practice is to use Groups for sending messages to specific users.
                // Clients.User() is not recommended.
                await Clients.Group(userName).SendAsync("AddPrivateMessage", userName, message);
            }
            catch (Exception ex)
            {
                Application.Current.Dispatcher.Invoke(() =>
                    ((MainWindow)Application.Current.MainWindow).WriteToConsole(ex.ToString()));
            }
        }
#endif

#if NET481
        public void SendGroupMessage(string groupName, string message)
        {
            Clients.Group(groupName).addGroupMessage(groupName, message);
        }
#else
        public async Task SendGroupMessage(string groupName, string message)
        {
            try
            {
                await Clients.Group(groupName).SendAsync("AddGroupMessage", groupName, message);
            }
            catch (Exception ex)
            {
                Application.Current.Dispatcher.Invoke(() =>
                    ((MainWindow)Application.Current.MainWindow).WriteToConsole(ex.ToString()));
            }
        }
#endif

#if NET481
        public override Task OnConnected()
        {
            //Use Application.Current.Dispatcher to access UI thread from outside the MainWindow class
            Application.Current.Dispatcher.InvokeAsync(() =>
                ((MainWindow)Application.Current.MainWindow).WriteToConsole("Client connected: " + Context.ConnectionId));

            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            //Use Application.Current.Dispatcher to access UI thread from outside the MainWindow class
            Application.Current.Dispatcher.InvokeAsync(() =>
                ((MainWindow)Application.Current.MainWindow).WriteToConsole("Client disconnected: " + Context.ConnectionId));

            return base.OnDisconnected(stopCalled);
        }
#else
        public override Task OnConnectedAsync()
        {
             //Use Application.Current.Dispatcher to access UI thread from outside the MainWindow class
            Application.Current.Dispatcher.Invoke(() =>
                ((MainWindow)Application.Current.MainWindow).WriteToConsole($"Client connected: {Context.ConnectionId}" +
                $" user:>{Context.User.Identity.Name}< userIdentifier:>{Context.UserIdentifier}<")
            );

            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            //Use Application.Current.Dispatcher to access UI thread from outside the MainWindow class
            Application.Current?.Dispatcher.Invoke(() =>
                ((MainWindow)Application.Current.MainWindow).WriteToConsole("Client disconnected: " + Context.ConnectionId)
            );

            return base.OnDisconnectedAsync(exception);
        }
#endif

    }
}
