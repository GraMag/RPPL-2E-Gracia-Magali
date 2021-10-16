using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente : Usuario
    {
        static int ultimoId;


        static Cliente()
        {
            ultimoId = 0;
        }

        public Cliente(string nombre, string apellido, string contraseña)
            :base(ultimoId++, nombre, apellido, contraseña)
        {

        }

        public Cliente(string nombre, string apellido, string email, string dni, DateTime fechaNac)
            : base(ultimoId++, nombre, apellido, email, dni, fechaNac)
        {
            
        }
      
    }
}
