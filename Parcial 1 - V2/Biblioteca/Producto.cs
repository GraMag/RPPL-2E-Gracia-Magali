using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Enum;

namespace Biblioteca
{
    public class Producto
    {
        ECategoria categoria;
        string nombre;
        double precio;
        string marca;
        int cantidad;
        int idProducto;
        string peso;

        public Producto()
        {

        }

        public Producto(int id, ECategoria categoria, string nombre, double precio, string marca, int cantidad)
            :this()
        {
            this.categoria = categoria;
            this.nombre = nombre;
            this.precio = precio;
            this.marca = marca;
            this.cantidad = cantidad;
            this.idProducto = id;
        }

        public Producto(int id, ECategoria categoria, string nombre, double precio, string marca, int cantidad, string peso)
            : this(id, categoria, nombre, precio, marca, cantidad)
        {
            this.peso = peso;
        }

        public int Id
        {
            get
            {
                return idProducto;
            }
            set
            {
                idProducto = value;
            }
        }

        public ECategoria ECategoriaProp
        {
            get
            {
                return this.categoria;
            }
        }

        public string Marca
        {
            get
            {
                return this.marca;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public double Precio
        {
            get
            {
                return this.precio;
            }
        }

        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                this.cantidad = value;
            }
        }

        public string Peso
        {
            get
            {
                return this.peso;
            }
        }

        /// <summary>
        /// Crea un nuevo producto a partir de los datos de otro producto, excepto la cantidad
        /// </summary>
        /// <param name="p1">Producto destino</param>
        /// <param name="p2">Producto origen</param>
        /// <returns></returns>
        public static Producto operator +(Producto p1, Producto p2)
        {
            return new Producto(p2.Id, p2.ECategoriaProp, p2.Nombre, p2.Precio, p2.Marca, 0);
        }
    }
}
