using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsServer
{
    public delegate void ClientConnectionEventHandler(string clientId);
    public delegate void ClientNameChangedEventHandler(string clientId, string newName);
    public delegate void ClientGroupEventHandler(string clientId, string groupName);

    public delegate void MessageReceivedEventHandler(string sendeClientId, string message);

    public class SimpleHub : Hub
    {
        static ConcurrentDictionary<string, string> _users = new ConcurrentDictionary<string, string>();

        public static event ClientConnectionEventHandler ClientConnected;
        public static event ClientConnectionEventHandler ClientDisconnected;
        public static event ClientNameChangedEventHandler ClientNameChanged;

        public static event ClientGroupEventHandler ClientJoinedToGroup;
        public static event ClientGroupEventHandler ClientLeftGroup;

        public static event MessageReceivedEventHandler MessageReceived;


        public static void ClearState()
        {
            _users.Clear();
        }

        // called when client is connected
        public override Task OnConnected()
        {
            _users.TryAdd(Context.ConnectionId, Context.ConnectionId);
            ClientConnected?.Invoke(Context.ConnectionId);

            return base.OnConnected();
        }

        // called when a client is disconnected
        public override Task OnDisconnected(bool stopCalled)
        {
            string username;
            _users.TryRemove(Context.ConnectionId, out username);

            ClientDisconnected?.Invoke(Context.ConnectionId);

            return base.OnDisconnected(stopCalled);
        }

        #region Client Method
        public void SetUserName(string userName)
        {
            _users[Context.ConnectionId] = userName;
            ClientNameChanged?.Invoke(Context.ConnectionId, userName);
        }

        public void Send(string message)
        {
            Clients.All.addMessage(_users[Context.ConnectionId], message);
            MessageReceived?.Invoke(Context.ConnectionId, message);
        }
        #endregion
    }
}
