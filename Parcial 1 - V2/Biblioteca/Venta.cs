using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Venta
    {
        private int id;
        private Cliente cliente;
        private List<Producto> compra;
        private DateTime date;
        private static int ultimoId;
        private string formaDePago;
        private int cuotas;

        static Venta()
        {
            ultimoId = 00000000;
        }
        public Venta(Cliente cliente, List<Producto> compra, string formaDePago)
        {
            id = UltimoId;
            this.cliente = cliente;
            this.compra = compra;
            this.date = DateTime.Today;
            this.formaDePago = formaDePago;
        }

        public Venta(Cliente cliente, List<Producto> compra, string formaDePago, int cuotas)
            : this(cliente, compra, formaDePago)
        {
            this.cuotas = cuotas;
        }

        private int UltimoId
        {
            get
            {
                return ultimoId;
            }
            set
            {
                ultimoId++;
            }
        }
        public Cliente Cliente
        {
            get
            {
                return cliente;
            }
        }

        public List<Producto> Compra
        {
            get
            {
                return compra;
            }
        }
    }
}