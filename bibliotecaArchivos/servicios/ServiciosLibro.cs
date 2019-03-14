using bibliotecaArchivos.estructural;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaArchivos.servicios
{
    class  ServiciosLibro
    {
        public static void grabarLibro(Libro nuevoLibro, String ruta)
        {
            FileStream archivo;
            archivo = new FileStream(ruta, FileMode.Append);
            BinaryWriter br = new BinaryWriter(archivo, Encoding.UTF8);

            br.Write(nuevoLibro.getEstado());
            br.Write(nuevoLibro.getTitulo());
            br.Write(nuevoLibro.getAutor());
            br.Write(nuevoLibro.getIsbn());
            br.Write(nuevoLibro.getNumPaginas());
            br.Write(nuevoLibro.getFechaPublicacion().ToBinary());
            br.Close();
            archivo.Close();
        }
        public static Libro leerLibro(String ruta)
        {
            FileStream archivo;
            BinaryReader binaryReader;
            archivo = new FileStream(ruta, FileMode.Open);
            binaryReader = new BinaryReader(archivo, Encoding.UTF8);

            string pTitulo = null;
            string pAutor = null;
            long pIsbn = 0;
            int pNumPag = 0;
            DateTime pFecha = default(DateTime);

            while (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
            {

               

                char estado = binaryReader.ReadChar();
                pTitulo = binaryReader.ReadString();
                pAutor = binaryReader.ReadString();
                pIsbn = binaryReader.ReadInt64();
                pNumPag = binaryReader.ReadInt32();
                long binDate = binaryReader.ReadInt64();
                pFecha = DateTime.FromBinary(binDate);
                
               
            }
           
            Libro nuevo = new Libro(pTitulo, pAutor, pIsbn, pNumPag, pFecha);
           
            binaryReader.Close();
            archivo.Close();
            return nuevo;
        }



    }
}
