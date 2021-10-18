using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Excepciones
{
    public class UsuarioInvalidoException : Exception
    {
        public UsuarioInvalidoException()
            : base()
        {
        }

        public override string Message
        {
            get
            {
                return "Blocky, nuestro perro guardian, no te reconoce.";
            }
        }
    }
}
