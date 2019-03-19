using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bibliotecaArchivos.interfaz
{
    public partial class GUIActualizar : Form
    {
        public GUIActualizar()
        {
            InitializeComponent();
        }

        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = false;

            openFileDialog1.ShowDialog();

            txtRutaArchivo.Text = openFileDialog1.FileName;
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            textTitulo.Enabled = true;
            textAutor.Enabled = true;
            textISBN.Enabled = true;
            textNumero.Enabled = true;
            DTFechaPublicacion.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
