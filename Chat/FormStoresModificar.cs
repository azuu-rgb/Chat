using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Chat
{
    public partial class FormStoresModificar : Form
    {
        WebSocketClientManager client;
        bool bandera = false;
        int id = 0;
        public FormStoresModificar(WebSocketClientManager client)
        {
            InitializeComponent();
            this.client = client;
        }

        //private void ClientManager_OnMessageReceived(string message)
        //{
        //    if (InvokeRequired)
        //    {
        //        Invoke(new Action(() => ClientManager_OnMessageReceived(message)));
                
        //        return;
        //    }
        //    FormStoresTabla froma =new FormStoresTabla();
        //    froma.actualizar();
        //}
        public FormStoresModificar(WebSocketClientManager client, int id, string nombre, string direccion, string ciudad, string estado, string cp)//actualizar
        {
            InitializeComponent();
            this.client = client;
            this.id = id;
            textBoxID.Text = id.ToString();
            textBoxID.ReadOnly = true;
            textBoxNOMBRE.Text = nombre;
            textBoxDIRECCION.Text = direccion;
            textBoxCIUDAD.Text = ciudad;
            textBoxESTADO.Text = estado;
            textBoxCP.Text = cp;
            bandera = true;

            ;

        }
        private void FormStoresModificar_Load(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassDatos dt = new ClassDatos();
            if (bandera)
            {

               
                try
                {
                    string sql = "UPDATE Stores SET " +
                   "stor_name = '" + textBoxNOMBRE.Text + "', " +
                   "stor_address = '" + textBoxDIRECCION.Text + "', " +
                   "city = '" + textBoxCIUDAD.Text + "', " +
                   "state = '" + textBoxESTADO.Text + "', " +
                   "zip = '" + textBoxCP.Text + "' " +
                   "WHERE stor_id = " + id;
                    dt.ejecutarComando(sql);
                    MessageBox.Show("TIENDA ACTUALIZADA");

                    string mensaje = "SE HAN REALIZADO ACTUALIZACIONES A LA BASE DE DATOS".Trim();
                    if (!string.IsNullOrEmpty(mensaje))
                    {
                        client.SendMessage(mensaje);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("NO SE ACTUALIZO LA TIENDA"+ex.Message);
                }
            }
            else
            {
                try
                {
                    string sql = "INSERT INTO Stores (stor_id, stor_name, stor_address, city, state, zip) " +
              "VALUES (" + textBoxID.Text + ", '" + textBoxNOMBRE.Text + "', '" + textBoxDIRECCION.Text +
              "', '" + textBoxCIUDAD.Text + "', '" + textBoxESTADO.Text + "', '" + textBoxCP.Text + "')";

                    dt.ejecutarComando(sql);

                    MessageBox.Show("TIENDA AGREGADA");

                    string mensaje = "SE HAN REALIZADO ACTUALIZACIONES A LA BASE DE DATOS".Trim();
                    if (!string.IsNullOrEmpty(mensaje))
                    {
                        client.SendMessage(mensaje);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("NO SE PUDO INSERTAR EL NUEVO REGISTRO");
                }
            }
            this.Close();
         
        }

    }
}

        
    

