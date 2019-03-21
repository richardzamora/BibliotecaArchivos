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
            int i = 0;

            FileStream archivo;
            BinaryReader binaryReader;
            archivo = new FileStream(txtRutaArchivo.Text, FileMode.Open);
            binaryReader = new BinaryReader(archivo, Encoding.UTF8);

            while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
            {
                dtaDatos.Rows.Add();
                dtaDatos.Rows[i].Cells[0].Value = i+1;
                estado = binaryReader.ReadChar();

                if(estado == 'A')
                {
                    
                    dtaDatos.Rows[i].Cells[1].Value = binaryReader.ReadString();
                    dtaDatos.Rows[i].Cells[2].Value = binaryReader.ReadString();
                    dtaDatos.Rows[i].Cells[3].Value = binaryReader.ReadInt64(); 
                    dtaDatos.Rows[i].Cells[4].Value = binaryReader.ReadInt32();
                    long binDate = binaryReader.ReadInt64();
                    DateTime fecha = DateTime.FromBinary(binDate);
                    String strFecha = fecha.ToString("dd/MM/yyyy");
                    dtaDatos.Rows[i].Cells[5].Value = strFecha;
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
