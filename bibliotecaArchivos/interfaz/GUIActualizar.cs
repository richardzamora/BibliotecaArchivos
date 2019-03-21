using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bibliotecaArchivos.estructural;
using bibliotecaArchivos.Excepciones;

namespace bibliotecaArchivos.interfaz
{
    public partial class GUIActualizar : Form
    {
        public GUIActualizar()
        {
            InitializeComponent();
        }

        //NO TOCAR
        private void GUIActualizar_Load(object sender, EventArgs e){}

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

        private void deshabilitar()
        {
            textTitulo.Enabled = false;
            textAutor.Enabled = false;
            textISBN.Enabled = false;
            textNumero.Enabled = false;
            DTFechaPublicacion.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rBIsbn.Checked)
                {
                    Boolean bIsbn;
                    long isbn;
                    bIsbn = long.TryParse(textCriterio.Text, out isbn);
                    String ruta = txtRutaArchivo.Text;

                    if (bIsbn && isbn > 0)
                    {
                        Libro leer = servicios.ServiciosLibro.buscarLibroISBN(ruta, isbn);
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
                if (rBPos.Checked)
                {
                    Boolean bPos;
                    int pos;
                    bPos = int.TryParse(textCriterio.Text, out pos);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean bIsbn;
                long isbn;
                bIsbn = long.TryParse(textCriterio.Text, out isbn);
                String ruta = txtRutaArchivo.Text;
                Libro actualizado = crearLibro();
                servicios.ServiciosLibro.actualizarLibro(isbn,ruta,actualizado);

                MessageBox.Show("Se ha actualizado el libro correctamente.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            deshabilitar();
        }

        private Libro crearLibro()
        {
            Boolean bNumPag;
            Boolean bIsbn;

            Libro nuevoLibro = null;
            String motivo = "actualizar";

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
    }
}
