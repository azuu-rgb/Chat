namespace Chat
{
    using System;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        private static WebSocketServerManager server;
        private void Server_OnMessageReceived(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Server_OnMessageReceived(message)));
                return;
            }

            richTextBoxRespuesta.AppendText("Cliente: " + message + Environment.NewLine);
        }

        public Form1()
        {
            InitializeComponent();
            server = new WebSocketServerManager();
            server.OnMessageReceived = Server_OnMessageReceived;
            server.StartServer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensaje = textBoxMensaje.Text.Trim();
            if (!string.IsNullOrEmpty(mensaje))
            {
                server.SendMessageToAll("Servidor: " + mensaje);
                richTextBoxRespuesta.AppendText("Yo: " + mensaje + Environment.NewLine);
                textBoxMensaje.Clear();
            }
        }
    }
}
