using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Chat
{
    public partial class FormStoresTabla : Form
    {
        ClassDatos dt;
        WebSocketClientManager client;
        public FormStoresTabla()
        {
            InitializeComponent();
            dt = new ClassDatos();
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

           
        }
        private void actualizar()
        {
            DataSet ds;
            ds = dt.consulta("SELECT stor_id AS [NO. TIENDA], " +
                  "stor_name AS [NOMBRE], " +
                  "stor_address AS [DIRECCION], " +
                  "city AS CIUDAD, " +
                  "state AS ESTADO, " +
                  "zip AS 'C.P.' " +
                 "FROM Stores");
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        private void FormStoresTabla_Load(object sender, EventArgs e)
        {
            actualizar();

        }

        private void textBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            DataSet ds;
            ds = dt.consulta("SELECT stor_id AS [NO. TIENDA], " +
                              "stor_name AS [NOMBRE], " +
                              "stor_address AS [DIRECCION], " +
                              "city AS CIUDAD, " +
                              "state AS ESTADO, " +
                              "zip AS [C.P.] " +
                              "FROM Stores" +
                              " WHERE stor_name like '" + textBoxBusqueda.Text + "%'");

            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            FormStoresModificar frmStoreUnico = new FormStoresModificar();
            frmStoreUnico.FormClosed += (s, args) =>
            {
                actualizar(); // Por si quieres mostrar el cambio inmediato también
                
            };
            frmStoreUnico.Show();
        }
    }
}
