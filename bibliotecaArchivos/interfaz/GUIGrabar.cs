using bibliotecaArchivos.estructural;
using bibliotecaArchivos.Excepciones;
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
    public partial class GUIGrabar : Form
    {
        public GUIGrabar()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            String ruta = txtRutaArchivo.Text;
            try
            {
                Libro nuevo = this.crearLibro();
                servicios.ServiciosLibro.grabarLibro(nuevo, ruta);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private Libro crearLibro()
        {
            Boolean bNumPag;
            Boolean bIsbn;

            Libro nuevoLibro = null;
            String motivo = "adicionar";

            String titulo = textTitulo.Text;
            String autor = textAutor.Text;
            
            DateTime fechaPublicacion = DTFechaPublicacion.Value;
            int numeroPaginas;
            long isbn;

            bNumPag = int.TryParse(textNumero.Text, out numeroPaginas);
            bIsbn = long.TryParse(textISBN.Text, out isbn);
            if (titulo.Equals(""))
            {
                DateTime momento = DateTime.Now;
                String causa = "el título ingresado es incorrecto, por favor ingrese un valor valido";
                LibroException ex = new LibroException(motivo, momento, causa);
                throw ex;
            }
            else if (autor.Equals(""))
            {
                DateTime momento = DateTime.Now;
                String causa = "el autor ingresado es incorrecto, por favor ingrese un valor valido";
                LibroException ex = new LibroException(motivo, momento, causa);
                throw ex;
            }
            else if (!bIsbn && isbn >= 0)
            {
                DateTime momento = DateTime.Now;
                String causa = "el ISBN ingresado es incorrecto, por favor ingrese un valor valido";
                LibroException ex = new LibroException(motivo, momento, causa);
                throw ex;
            }
            else if (!bNumPag && numeroPaginas >= 0)
            {
                DateTime momento = DateTime.Now;
                String causa = "el numero de paginas ingresado es incorrecto, por favor ingrese un valor valido";
                LibroException ex = new LibroException(motivo, momento, causa);
                throw ex;
            }
            else if (DateTime.Compare(fechaPublicacion, DateTime.Now) > 0)
            {
                DateTime momento = DateTime.Now;
                String causa = "La fecha de publicacion no puede ser mayor a la actual, por favor ingrese un valor valido";
                LibroException ex = new LibroException(motivo, momento, causa);
                throw ex;
            }
            else
            {
                nuevoLibro = new Libro(titulo, autor, isbn, numeroPaginas, fechaPublicacion);

            }

            return nuevoLibro;
        }

        private void limpiarEspaciosDeTexto()
        {
            textTitulo.Text = "";
            textAutor.Text = "";
            textISBN.Text = "";
            textNumero.Text = "";
            textTitulo.Focus();
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
