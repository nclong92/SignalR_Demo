using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsServer
{
    public partial class FrmServer : Form
    {
        private IDisposable _signalR;
        private BindingList<ClientItem> _clients = new BindingList<ClientItem>();

        public FrmServer()
        {
            InitializeComponent();

            bindListsToControls();

            // Register to static hub events
            SimpleHub.ClientConnected += SimpleHub_ClientConnected;
            SimpleHub.ClientDisconnected += SimpleHub_ClientDisconnected;
            SimpleHub.ClientNameChanged += SimpleHub_ClientNameChanged;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void SimpleHub_ClientNameChanged(string clientId, string newName)
        {
            // update the client's name if it exists
            this.BeginInvoke(new Action(() =>
            {
                var client = _clients.FirstOrDefault(x => x.Id == clientId);

                if (client != null) client.Name = newName;
            }));

            writeToLog($"Client name changed. Id: {clientId}, Name: {newName}");
        }

        private void SimpleHub_ClientConnected(string clientId)
        {
            // Add client to our client list
            this.BeginInvoke(new Action(() => _clients.Add(new ClientItem() { Id = clientId, Name = clientId })));

            writeToLog($"Client connected: {clientId}");
        }

        private void SimpleHub_ClientDisconnected(string clientId)
        {
            // Remove client from the list
            this.BeginInvoke(new Action(() =>
            {
                var client = _clients.FirstOrDefault(x => x.Id == clientId);

                if (client != null) _clients.Remove(client);
            }));

            writeToLog($"Client disconnected: {clientId}");
        }

        private void bindListsToControls()
        {
            // Client list
            cmbClients.DisplayMember = "Name";
            cmbClients.ValueMember = "Id";
            cmbClients.DataSource = _clients;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _clients.Clear();

            SimpleHub.ClearState();
            if (_signalR != null)
            {
                _signalR.Dispose();
                _signalR = null;

                btnStop.Enabled = true;
                txtUrl.Enabled = true;
                grpBroastCast.Enabled = false;

                writeToLog("Server stopped");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtLog.Clear();

            try
            {
                // start server URL/signalr
                _signalR = WebApp.Start<Startup>(txtUrl.Text);

                btnStart.Enabled = false;
                txtUrl.Enabled = false;
                btnStop.Enabled = true;
                grpBroastCast.Enabled = true;

                writeToLog($"Server start at: {txtUrl.Text}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
