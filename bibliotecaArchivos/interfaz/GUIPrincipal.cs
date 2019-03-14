using bibliotecaArchivos.interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bibliotecaArchivos
{
    public partial class GUIPrincipal : Form
    {
        public GUIPrincipal()
        {
            InitializeComponent();
        }

        private void grabarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIGrabar gui = new GUIGrabar();
            gui.Show();
        }

        private void leerLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUILeer gui = new GUILeer();
            gui.Show();
        }
    }
}
