using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaArchivos.estructural
{
    class Libro
    {
        private String titulo;
        private String autor;
        private int numPaginas;
        private long isbn;
        private DateTime fechaPublicacion;
        private char estado;
        
        public Libro (String pTitulo)
        {
            titulo = String.Format("{-100}", pTitulo);
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




    }
}
