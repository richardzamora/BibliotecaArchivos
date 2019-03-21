using bibliotecaArchivos.estructural;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaArchivos.servicios
{
    class ServiciosLibro
    {
        public const int NUM_BYTES = 173;
        public const int BYTES_LONG = 8;
        /*
         * Casos de uso
         */
        //Leer registro del archivo             ---> Full
        //Grabar registro en el archivo         ---> Full
        //Actualizar registro en el archivo     ---> Full
        //Eliminar registro del archivo         ---> Full
        //Volcar datos al archivo               ---> Funciona
        //Listar Registro                       --->

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

        public static void volcarArchivos(String pRutaOrigen, String pRutaDestino)
        {
            Libro libro;

            FileStream archivo;
            String cad;
            String[] subCadenas;

            archivo = new FileStream(pRutaOrigen, FileMode.Open);
            StreamReader sr;
            sr = new StreamReader(archivo, Encoding.UTF8);

            while (true)
            {
                cad = sr.ReadLine();
                if (cad == null || cad.Length == 0)
                {
                    break;
                }
                subCadenas = cad.Split(';');
                long isbn = long.Parse(subCadenas[2]);
                int numPaginas = int.Parse(subCadenas[3]);
                DateTime fecha = DateTime.Parse(subCadenas[4]);

                libro = new Libro(subCadenas[0], subCadenas[1], isbn, numPaginas, fecha);

                grabarLibro(libro, pRutaDestino);
            }

            sr.Close();
            archivo.Close();
        }

        public static Libro buscarLibroISBN(String ruta, long isbn)
        {
            FileStream archivo;
            BinaryReader binaryReader;

            archivo = new FileStream(ruta, FileMode.Open);
            binaryReader = new BinaryReader(archivo, Encoding.UTF8);

            char estado = ' ';
            string pTitulo = null;
            string pAutor = null;
            long pIsbn = 0;
            int pNumPag = 0;
            DateTime pFecha = default(DateTime);
            if (binaryReader.BaseStream.Length == 0)
            {
                binaryReader.Close();
                archivo.Close();
                throw new Exception("El documento está vacio");
            }
            estado = binaryReader.ReadChar();
            pTitulo = binaryReader.ReadString();
            pAutor = binaryReader.ReadString();
            pIsbn = binaryReader.ReadInt64();

            while (pIsbn != isbn)
                {
                    if ((binaryReader.BaseStream.Position + NUM_BYTES) > binaryReader.BaseStream.Length)
                    {
                        binaryReader.Close();
                        archivo.Close();
                        throw new Exception("El libro con el criterio a buscar no existe");
                    }
                    else
                    {
                        binaryReader.BaseStream.Position = binaryReader.BaseStream.Position + (NUM_BYTES-BYTES_LONG);
                        pIsbn = binaryReader.ReadInt64();
                    }
                }
            binaryReader.BaseStream.Position = binaryReader.BaseStream.Position - (161);

            estado = binaryReader.ReadChar();
            if (estado != 'A')
            {
                binaryReader.Close();
                archivo.Close();
                throw new Exception("El libro con el criterio a buscar fue eliminado");
            }
            pTitulo = binaryReader.ReadString();
            pAutor = binaryReader.ReadString();
            pIsbn = binaryReader.ReadInt64();
            pNumPag = binaryReader.ReadInt32();
            long binDate = binaryReader.ReadInt64();
            pFecha = DateTime.FromBinary(binDate);

            Libro buscado = new Libro(pTitulo, pAutor, pIsbn, pNumPag, pFecha);

            binaryReader.Close();
            archivo.Close();

            return buscado;
        }

        public static void actualizarLibro(long isbn, String ruta, Libro actualizado)
        {
            FileStream archivo;
            BinaryReader binaryReader;
            BinaryWriter bw;

            archivo = new FileStream(ruta, FileMode.Open);
            binaryReader = new BinaryReader(archivo, Encoding.UTF8);
            bw = new BinaryWriter(archivo, Encoding.UTF8);

            char estado = ' ';
            string pTitulo = null;
            string pAutor = null;
            long pIsbn = 0;
            if (binaryReader.BaseStream.Length == 0)
            {
                binaryReader.Close();
                archivo.Close();
                throw new Exception("El documento está vacio");
            }
            estado = binaryReader.ReadChar();
            pTitulo = binaryReader.ReadString();
            pAutor = binaryReader.ReadString();
            pIsbn = binaryReader.ReadInt64();

            while (pIsbn != isbn)
            {
                if ((binaryReader.BaseStream.Position + NUM_BYTES) > binaryReader.BaseStream.Length)
                {
                    binaryReader.Close();
                    archivo.Close();
                    throw new Exception("El libro con el criterio a buscar no existe");
                }
                else
                {
                    binaryReader.BaseStream.Position = binaryReader.BaseStream.Position + (NUM_BYTES - BYTES_LONG);
                    pIsbn = binaryReader.ReadInt64();
                }
            }
            binaryReader.BaseStream.Position = binaryReader.BaseStream.Position - (161);

            estado = binaryReader.ReadChar();
            if (estado != 'A')
            {
                binaryReader.Close();
                archivo.Close();
                throw new Exception("El libro con el criterio a buscar fue eliminado");
            }
            bw.Write(actualizado.getTitulo());
            bw.Write(actualizado.getAutor());
            bw.Write(actualizado.getIsbn());
            bw.Write(actualizado.getNumPaginas());
            bw.Write(actualizado.getFechaPublicacion().ToBinary());

            binaryReader.Close();
            archivo.Close();

        }
    }
}
