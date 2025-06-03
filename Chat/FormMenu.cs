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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void tABLASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStoresTabla tiendas = new FormStoresTabla();
            tiendas.Show();
        }
    }
}
