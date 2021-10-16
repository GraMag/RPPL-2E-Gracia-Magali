using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Enum;

namespace Biblioteca
{
    public class Administrador : Empleado
    {
        /// <summary>
        /// Instancia un empleado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="password"></param>
        public Administrador(string nombre, string apellido, string password)
            : base(nombre, apellido, password, ECargo.ADMIN)
        {

        }
    }
}
