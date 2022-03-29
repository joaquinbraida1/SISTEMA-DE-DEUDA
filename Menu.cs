using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_DE_DEUDA
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cargaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmcarga ofmcarga = new fmcarga();
            ofmcarga.MdiParent = this;
            ofmcarga.Show();
        }

        private void visualizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
