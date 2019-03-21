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

        private Libro sig;
        
        public Libro (String pTitulo, String pAutor,  long pIsbn, int pNumPag, DateTime pFecha)
        {
            estado = 'A';
            if (pTitulo.Length>100)
            {
                titulo = pTitulo.Substring(0, 100);
            }
            else
            {
                titulo = String.Format("{0,-100}", pTitulo);
            }
            if (pAutor.Length>50)
            {
                autor = pAutor.Substring(0, 50);
            }
            else
            {
                autor = String.Format("{0,-50}", pAutor);
            }
            //titulo = String.Format("{0,-100}", pTitulo);
            //autor = String.Format("{0,-50}", pAutor);
            //titulo = pTitulo;
            //autor = pAutor;

            isbn = pIsbn;
            numPaginas = pNumPag;
            fechaPublicacion = pFecha;

            this.sig = null;
            
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

        public void setSig(Libro nuevo)
        {
            this.sig = nuevo;
        }

        public Libro getSig()
        {
            return sig;
        }
    }
}
