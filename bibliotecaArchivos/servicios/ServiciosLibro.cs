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




    }
}
