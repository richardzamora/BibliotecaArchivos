using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bibliotecaArchivos.interfaz
{
    public partial class GUIListar : Form
    {
        public GUIListar()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void actualizar()
        {
            dtaDatos.Rows.Clear();
            char estado = ' ';
            int i = 1;

            FileStream archivo;
            BinaryReader binaryReader;
            archivo = new FileStream(txtRutaArchivo.Text, FileMode.Open);
            binaryReader = new BinaryReader(archivo, Encoding.UTF8);

            string pTitulo = null;
            string pAutor = null;
            long pIsbn = 0;
            int pNumPag = 0;
            DateTime pFecha = default(DateTime);

            while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
            {
 
                estado = binaryReader.ReadChar();
                pTitulo = binaryReader.ReadString();
                pAutor = binaryReader.ReadString();
                pIsbn = binaryReader.ReadInt64();
                pNumPag = binaryReader.ReadInt32();
                long binDate = binaryReader.ReadInt64();
                pFecha = DateTime.FromBinary(binDate);
                if (estado=='A')
                {
                    dtaDatos.Rows.Add(i, pTitulo, pAutor, pIsbn, pNumPag, pFecha);
                }
                i++;
            }
            binaryReader.Close();
            archivo.Close();
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
