using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaArchivos.Excepciones
{
    public class LibroException : ApplicationException
    {
        private String motivo;
        private DateTime momento;
        private String causa;

        public LibroException(String motivo, DateTime momento, String causa)
        {
            this.motivo = motivo;
            this.momento = momento;
            this.causa = causa;
        }

        public String darMotivo()
        {
            return motivo;
        }
        public DateTime darFecha()
        {
            return momento;
        }
        public String darcausa()
        {
            return causa;
        }

        public override string Message
        {
            get
            {
                return String.Format("Excepcion al: " + motivo + " porque " + causa);
            }
        }
    }
}
