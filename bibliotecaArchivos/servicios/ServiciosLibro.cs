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
        public const int NUM_BYTES = 173;
        /*
         * Casos de uso
         */
        //Leer registro del archivo             ---> casi Full (falta verificar si funciona si el nodo esta eliminado)
        //Grabar registro en el archivo         ---> Full
        //Actualizar registro en el archivo     --->
        //Eliminar registro del archivo         --->
        //Volcar datos al archivo               --->

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
        public static Libro leerLibro(String ruta, int pos)
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

            pos = pos - 1;

            if (pos * NUM_BYTES > binaryReader.BaseStream.Length)
            {
                binaryReader.Close();
                archivo.Close();
                throw new Exception("La posición indicada supera el máximo de libros existentes");
            }
            else
            {

                binaryReader.BaseStream.Position = pos * NUM_BYTES;
                char estado = 'P';
                while (estado != 'A')
                {
                    if (binaryReader.BaseStream.Position >= binaryReader.BaseStream.Length)
                    {
                        binaryReader.Close();
                        archivo.Close();
                       throw new Exception("La posición indicada supera el máximo de libros existentes");
                    }
                    estado = binaryReader.ReadChar();
                    pTitulo = binaryReader.ReadString();
                    pAutor = binaryReader.ReadString();
                    pIsbn = binaryReader.ReadInt64();
                    pNumPag = binaryReader.ReadInt32();
                    long binDate = binaryReader.ReadInt64();
                    pFecha = DateTime.FromBinary(binDate);
                   
                }
            }
            Libro nuevo = new Libro(pTitulo, pAutor, pIsbn, pNumPag, pFecha);
           
            binaryReader.Close();
            archivo.Close();
            return nuevo;
            }
        public static void eliminarLibroPosicion(String ruta, int pos)
        {
            FileStream archivo;
            BinaryReader binaryReader;
            BinaryWriter bW;

            archivo = new FileStream(ruta, FileMode.Open);
            binaryReader = new BinaryReader(archivo, Encoding.UTF8);
            bW = new BinaryWriter(archivo, Encoding.UTF8);

            string pTitulo = null;
            string pAutor = null;
            long pIsbn = 0;
            int pNumPag = 0;
            DateTime pFecha = default(DateTime);

            pos = pos - 1;

            if (pos * NUM_BYTES > binaryReader.BaseStream.Length)
            {
                binaryReader.Close();
                bW.Close();
                archivo.Close();
                throw new Exception("La posición indicada supera el máximo de libros existentes");
            }
            else
            {

                binaryReader.BaseStream.Position = pos * NUM_BYTES;
                char estado = 'P';
                while (estado != 'A')
                {
                    if (binaryReader.BaseStream.Position > binaryReader.BaseStream.Length)
                    {
                        binaryReader.Close();
                        bW.Close();
                        archivo.Close();
                        throw new Exception("La posición indicada supera el máximo de libros existentes");
                    }
                    estado = binaryReader.ReadChar();
                     if (estado == 'A')
                    {
                        bW.BaseStream.Position = binaryReader.BaseStream.Position - 1;
                        bW.Write('E');
                       
                    }
                    else
                    { 
                    pTitulo = binaryReader.ReadString();
                    pAutor = binaryReader.ReadString();
                    pIsbn = binaryReader.ReadInt64();
                    pNumPag = binaryReader.ReadInt32();
                    long binDate = binaryReader.ReadInt64();
                    pFecha = DateTime.FromBinary(binDate);
                    }
                    

                }

            }

            binaryReader.Close();
            bW.Close();
            archivo.Close();
            
        }

    }
}
