using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class FrmClient : Form
    {
        // Connection to a SignalR server
        HubConnection _signalRConnection;

        // Proxy object for a hub hosted on the SignalR server
        IHubProxy _hubProxy;

        public FrmClient()
        {
            InitializeComponent();
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            await connectAsync();
        }

        private async Task connectAsync()
        {
            // create a connection for the SignalR server
            _signalRConnection = new HubConnection(txtUrl.Text);
            _signalRConnection.StateChanged += HubConnection_StateChanged;

            // Get a proxy object that will be used to interact with the specific hub on the server
            // There may be many hub hosted on the server, sos provide the type name for the hub
            _hubProxy = _signalRConnection.CreateHubProxy("SimpleHub");

            // Register to the AddMessage callback method of the hub
            // This method is invoked by the hub
            _hubProxy.On<string, string>("AddMessage", (name, message) => writeToLog($"{name}:{message}"));

            btnConnect.Enabled = false;

            try
            {
                // Connect to the server
                await _signalRConnection.Start();

                // send user name for this client, so we won't need to send it with every message
                await _hubProxy.Invoke("SetUserName", txtUsername.Text);

                txtUrl.Enabled = false;
                txtUsername.Enabled = false;
                btnDisconnect.Enabled = true;
                grpMessaging.Enabled = true;
                grpMembership.Enabled = true;

            }
            catch (Exception ex)
            {
                writeToLog($"Error: {ex.Message}");
                btnConnect.Enabled = true;
            }
        }

        private void HubConnection_StateChanged(StateChange obj)
        {
            if (obj.NewState == Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
            {
                writeToLog("Connected");
            }
            else if (obj.NewState == Microsoft.AspNet.SignalR.Client.ConnectionState.Disconnected)
            {
                writeToLog("Disconnected");
            }
        }

        private void writeToLog(string log)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() => txtLog.AppendText(log + Environment.NewLine)));
            }
            else
            {
                txtLog.AppendText(log + Environment.NewLine);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            // close the server connection iif exists
            if (_signalRConnection != null)
            {
                _signalRConnection.Stop();
                _signalRConnection.Dispose();
                _signalRConnection = null;

                btnConnect.Enabled = true;
                txtUrl.Enabled = true;
                txtUsername.Enabled = true;
                btnDisconnect.Enabled = false;
                grpMessaging.Enabled = false;
                grpMembership.Enabled = false;
            }
        }
    }
}
