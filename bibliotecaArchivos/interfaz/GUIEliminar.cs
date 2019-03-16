using bibliotecaArchivos.estructural;
using bibliotecaArchivos.servicios;
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
    public partial class GUIEliminar : Form
    {
        public GUIEliminar()
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

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean bPos;
                int pos;
                bPos = int.TryParse(textPos.Text, out pos);
                String ruta = txtRutaArchivo.Text;
                if (bPos && pos > 0)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean bPos;
                int pos;
                bPos = int.TryParse(textPos.Text, out pos);
                String ruta = txtRutaArchivo.Text;


                if (bPos && pos > 0)
                {
                    var confirmResult = MessageBox.Show("Estás seguro de eliminar este libro??",
                                     "Confirmar Eliminación!!",
                                     MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        // If 'Yes', do something here.
                        ServiciosLibro.eliminarLibroPosicion(ruta, pos);
                    }
                    else
                    {
                        // If 'No', do something here.
                    }
                    
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
    }
}
