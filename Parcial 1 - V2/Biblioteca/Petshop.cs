using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Petshop
    {
        private static Petshop singleton;
        List<Usuario> usuariosRegistrados;
        List<Cliente> clientes;
        List<Empleado> empleados;
        List<Producto> productos;
        List<Venta> ventas;
        

        private Petshop()
        {
            this.usuariosRegistrados = new List<Usuario>();
            this.clientes = new List<Cliente>();
            this.empleados = new List<Empleado>();
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }


        public static Petshop Singleton
        {
            get 
            { 
                if(singleton == null)
                {
                    singleton = new Petshop();
                }
                return singleton; 
            }
        }


        public List<Usuario> UsuariosRegistrados
        {
            get 
            { 
                return usuariosRegistrados; 
            }    
            set
            {
                if(value != null)
                {
                    usuariosRegistrados = value;
                }
            }
        }

        public List<Cliente> Clientes
        {
            get
            {
                return this.clientes;
            }
            set
            {
                if (value != null)
                    clientes = value;
            }
        }

        public List<Empleado> Empleados
        {
            get
            {
                return this.empleados;
            }
            set
            {
                if (value != null)
                    this.empleados = value;
                
            }
        }

        public List<Producto> Productos
        {
            get
            {
                return this.productos;
            }
            set
            {
                if (value != null)
                    this.productos = value;
            }
        }

        public List<Venta> Ventas
        {
            get
            {
                return ventas;
            }
            set
            {
                if (value != null)
                {
                    ventas = value;
                }
            }
        }
    }
}
