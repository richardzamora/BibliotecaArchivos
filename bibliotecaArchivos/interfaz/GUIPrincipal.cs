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

        private void eliminarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIEliminar gui = new GUIEliminar();
            gui.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creado por:\nEzequiel Melo Bustos - 2220171073 \nRichard Javier Zamora Herrera - 2220171018", "Creditos");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void volcarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIVolcarDatos gui = new GUIVolcarDatos();
            gui.Show();
        }

        private void actualizarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIActualizar gui = new GUIActualizar();
            gui.Show();
        }

        private void listarLibosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIListar gui = new GUIListar();
            gui.Show();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
