using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Enum;

namespace Biblioteca
{

    public class Empleado : Usuario
    {
        ECargo cargo;
        static int ultimoId;

        static Empleado()
        {
            ultimoId = 0;
        }

        public Empleado(string nombre, string apellido, string password)
            : base(ultimoId++, nombre, apellido, password)
        {
            base.Email = $"{Nombre}.{Apellido}@thepetshop.com".ToLower();
            cargo = ECargo.SISTEMAS;
        }

        public Empleado(string nombre, string apellido, string password, ECargo cargo)
            : this(nombre, apellido, password)
        {
            this.cargo = cargo;
        }

        public ECargo Cargo
        {
            get
            {
                return cargo;
            }
            set
            {
                this.cargo = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Cargo: {this.cargo}");
            return sb.ToString();
        }
    }
}
