using bibliotecaArchivos.estructural;
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
    public partial class GUILeer : Form
    {
        public GUILeer()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                int pos = 2;
                String ruta = txtRutaArchivo.Text;
                Libro leer =servicios.ServiciosLibro.leerLibro(ruta, pos);

                textTitulo.Text = leer.getTitulo();
                textAutor.Text = leer.getAutor();
                textISBN.Text = ("" + leer.getIsbn());
                textNumero.Text = ("" + leer.getNumPaginas());
                DTFechaPublicacion.Value = leer.getFechaPublicacion();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
               

           
        
        }

        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = false;

            openFileDialog1.ShowDialog();

            txtRutaArchivo.Text = openFileDialog1.FileName;
        }
    }
}
