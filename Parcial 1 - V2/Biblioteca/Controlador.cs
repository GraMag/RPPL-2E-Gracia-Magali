using Biblioteca.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Controlador
    {
        /// <summary>
        /// Hardcodea distintas clases de usuarios
        /// </summary>
        /// <returns>Devuelve una lista de usuarios</returns>
        public static List<Usuario> CargarUsuarios()
        {
            List<Usuario> usuariosRegistrados = new List<Usuario>();
            usuariosRegistrados.Add(new Administrador("Bugs", "Bunny", "V13j0"));
            usuariosRegistrados.Add(new Cliente("Peppa", "Pig", "D1n0s4ur10"));
            usuariosRegistrados.Add(new Empleado("Ranger", "Rosa", "AlphaAyAyAyAyAy", Enum.ECargo.RRHH));
            usuariosRegistrados.Add(new Cliente("Mirtha", "Legrand", "MCMXXVII A.C."));
            usuariosRegistrados.Add(new Empleado("Ricky", "Fort", "Maiameeee", Enum.ECargo.CONTABLE));

            return usuariosRegistrados;
        }

        /// <summary>
        /// Hardcodea una lista de productos
        /// </summary>
        /// <returns>Devuelve una lista de productos</returns>
        public static List<Producto> CargarProductos()
        {
            List<Producto> stockProductos = new List<Producto>();
            stockProductos.Add(new(7862, ECategoria.ALIMENTOS, "Alimento Adultos Pescado", 444.20, "Whiskas", 86, "1Kg"));
            stockProductos.Add(new(9511, ECategoria.ALIMENTOS, "Alimento En Sobre Carne", 84.60, "Pedigree", 45, "100 Gr"));
            stockProductos.Add(new(3628, ECategoria.LIMPIEZA, "Dentastix", 358.98, "Pedigree", 15));
            stockProductos.Add(new(7049, ECategoria.JUGUETES, "Pelota", 389, "Hairy Beast", 32));

            return stockProductos;
        }

        /// <summary>
        /// Carga una lista de Clientes y una de Empleados
        /// </summary>
        /// <param name="petshop"></param>
        public static void ListarUsuarios(Petshop petshop)
        {
            foreach (Usuario user in petshop.UsuariosRegistrados)
                if (user is Cliente)
                    petshop.Clientes.Add((Cliente)user);
                else if (user is Empleado)
                    petshop.Empleados.Add((Empleado)user);
        }

        /// <summary>
        /// Verifica que el usuario y la contraseña coincidan
        /// </summary>
        /// <param name="usuariosRegistrados"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>Devuelve el usuario valido. Sino devuelve null</returns>
        public static Usuario Login(List<Usuario> usuariosRegistrados, string email, string password)
        {
            foreach (Usuario user in usuariosRegistrados)
                if (user.Email == email.Trim().ToLower() && user.Password == password.Trim())
                    return user;
            
            return null;
        }

        /// <summary>
        /// Calcula el valor de la venta
        /// </summary>
        /// <param name="productos"></param>
        /// <returns>Monto de la venta</returns>
        public static double CalcularSubtotal(List<Producto> productos)
        {
            double total = 0;
            
            foreach(Producto producto in productos)
                total += producto.Precio * producto.Cantidad;
            
            return total;
        }

        /// <summary>
        /// Calcula el total con recargo en caso de pagar en cuotas
        /// </summary>
        /// <param name="subtotal">Valor de la compra</param>
        /// <param name="cuotas">Cantidad de cuotas</param>
        /// <returns>Total con recargo</returns>
        public static double CalcularTotalConCuotas(double subtotal, int cuotas)
        {
            switch (cuotas)
            {
                case 2:
                    return subtotal * 1.0389;
                case 3:
                    return subtotal * 1.045;
                case 6:
                    return subtotal * 1.060;
                case 9:
                    return subtotal * 1.10;
                default:
                    return subtotal;
                    
            }
        }

    }
}
