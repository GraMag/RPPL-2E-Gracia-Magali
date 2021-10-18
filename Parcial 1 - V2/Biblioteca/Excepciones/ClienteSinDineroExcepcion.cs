using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Excepciones
{
    public class ClienteSinDineroExcepcion : Exception
    {
        public ClienteSinDineroExcepcion()
            :base()
        {
        }
    }
}
