using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaArchivos.estructural
{
    class Libro
    {
        private char estado;

        private String titulo;
        private String autor;
        private int numPaginas;
        private long isbn;
        private DateTime fechaPublicacion;
        
        
        public Libro (String pTitulo, String pAutor,  long pIsbn, int pNumPag, DateTime pFecha)
        {
            //          titulo = String.Format("{-100}", pTitulo);
            //          autor = String.Format("{-50}", pAutor);
            titulo = pTitulo;
            autor = pAutor;
            numPaginas = pNumPag;
            isbn = pIsbn;
            fechaPublicacion = pFecha;
            estado = 'A';
        }

        public String getTitulo()
        {
            return titulo;
        }
        public void setTitulo(String titulo)
        {
            this.titulo = titulo;
        }
        public String getAutor()
        {
            return autor;
        }
        public void setAutor(String autor)
        {
            this.autor = autor;
        }
        public int getNumPaginas()
        {
            return numPaginas;
        }
        public void setNumPaginas(int numPaginas)
        {
            this.numPaginas = numPaginas;
        }
        public long getIsbn()
        {
            return isbn;
        }
        public void setIsbn(long isbn)
        {
            this.isbn = isbn;
        }
        public DateTime getFechaPublicacion()
        {
            return fechaPublicacion;
        }
        public void setFechaPublicacion(DateTime fechaPublicacion)
        {
            this.fechaPublicacion = fechaPublicacion;
        }
        public char getEstado()
        {
            return estado;
        }
        public void setEstado(char estado)
        {
            this.estado = estado;
        }


        /*
         * Casos de uso
         */ 
        //Leer registro del archivo
        //Grabar registro en el archivo
        //Actualizar registro en el archivo
        //Eliminar registro del archivo
        //Volcar datos al archivo


    }
}
