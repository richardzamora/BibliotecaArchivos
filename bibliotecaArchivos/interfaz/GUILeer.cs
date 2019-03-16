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
                Boolean bPos;
                int pos;
                bPos = int.TryParse(textPos.Text, out pos);
                String ruta = txtRutaArchivo.Text;
                if (bPos && pos>0)
                {
                    Libro leer = servicios.ServiciosLibro.leerLibro(ruta, pos);
                    textTitulo.Text = leer.getTitulo();
                    textAutor.Text = leer.getAutor();
                    textISBN.Text = ("" + leer.getIsbn());
                    textNumero.Text = ("" + leer.getNumPaginas());
                    DTFechaPublicacion.Value = leer.getFechaPublicacion();
                }
                else
                {
                    MessageBox.Show("La posición debe ser un número y mayor que 0");
                }

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
