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

        private WebSocketClientManager client;
        public FormStoresTabla()
        {
            InitializeComponent();
            dt = new ClassDatos();
            client = new WebSocketClientManager();
            int contador = 0;
            
            client.OnMessageReceived = ClientManager_OnMessageReceived;
            
            client.Connect("ws://10.19.95.206:8181");

        }
        
        private void ClientManager_OnMessageReceived(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => ClientManager_OnMessageReceived(message)));

                return;
            }
          
            actualizar();
            MessageBox.Show(message);    
            
        }
        public void actualizar()
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
            FormStoresModificar frmStoreUnico = new FormStoresModificar(client);
            frmStoreUnico.FormClosed += (s, args) =>
            {
                actualizar(); // Por si quieres mostrar el cambio inmediato también

            };
            frmStoreUnico.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            FormStoresModificar tienda = new FormStoresModificar(
                client,
                Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value),
                dataGridView1.Rows[i].Cells[1].Value.ToString(),
                dataGridView1.Rows[i].Cells[2].Value.ToString(),
                dataGridView1.Rows[i].Cells[3].Value.ToString(),
                dataGridView1.Rows[i].Cells[4].Value.ToString(),
                dataGridView1.Rows[i].Cells[5].Value.ToString()
                );
            tienda.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            DialogResult f = MessageBox.Show("¿ELIMINAR TIENDA?" + dataGridView1.Rows[i].Cells[0].Value, "ELIMINAR", MessageBoxButtons.YesNo);
            if (f == DialogResult.Yes)
            {
                if (dt.ejecutarComando("DELETE FROM Stores WHERE stor_id = " + dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    MessageBox.Show("Tienda Eliminada", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    actualizar();

                    string mensaje = "SE HAN REALIZADO ACTUALIZACIONES A LA BASE DE DATOS".Trim();
                    if (!string.IsNullOrEmpty(mensaje))
                    {
                        client.SendMessage(mensaje);
                    }
                }
                else
                {
                    MessageBox.Show("Error al eliminar tienda", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    actualizar();
                }



            }
            else
            {
                MessageBox.Show("NO SE ELIMINO NINGUNA TIENDA");
            }
        }

        private void FormStoresTabla_Activated(object sender, EventArgs e)
        {
            actualizar();
        }
    }
}
