using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class FormCliente : Form
    {
        private static WebSocketClientManager client;
        public FormCliente()
        {
            InitializeComponent();
            client = new WebSocketClientManager();
            client.OnMessageReceived += ClientManager_OnMessageReceived;

            client.Connect("ws://127.0.0.1:8181");
        }
        private void ClientManager_OnMessageReceived(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => ClientManager_OnMessageReceived(message)));
                return;
            }

            listBoxMesaje.Items.Add("Servidor: " + message);
        }
        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            string mensaje = textBoxMensaje.Text.Trim();
            if (!string.IsNullOrEmpty(mensaje))
            {
                client.SendMessage(mensaje);
                listBoxMesaje.Items.Add("Yo: " + mensaje);
                textBoxMensaje.Clear();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            client.Close();
            base.OnFormClosing(e);
        }
    }
}
