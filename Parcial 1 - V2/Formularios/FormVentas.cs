using Biblioteca;
using Biblioteca.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormVentas : Form
    {
        Petshop petshop;
        List<Producto> ventaEnCurso;
        Cliente cliente;
        public FormVentas()
        {
            InitializeComponent();
            cmbBoxFiltrar.DataSource = Enum.GetValues(typeof(ECategoria));
            ventaEnCurso = new List<Producto>();
            lblTotal.Text = $"Total: ${Controlador.CalcularSubtotal(ventaEnCurso).ToString("#.00")}";
            cmbCuotas.SelectedIndex = 0;

        }

        public FormVentas(Petshop petshop)
            : this()
        {
            this.petshop = petshop;
            this.dataGridViewProductos.DataSource = petshop.Productos;
        }

        public FormVentas(Petshop petshop, Cliente cliente)
            : this (petshop)
        {
            this.cliente = cliente;
            this.lblID.Text = $"ID: {cliente.Id}";
            this.lblCliente.Text = $"Nombre y apellido {cliente.Nombre} {cliente.Apellido}";
        }

        /// <summary>
        /// Agrega productos a la lista de ventas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dataGridViewVentaEnCurso.DataSource = null;

            if (int.TryParse(this.txtBoxIdProd.Text, out int id))
            {
                if (!ventaEnCurso.Any(producto => producto.Id == id))
                {
                    int.TryParse(txtBoxCantidad.Text, out int cantidadSolicitada);
                    Producto productoAux = petshop.Productos.Find(producto => producto.Id == id && producto.Cantidad >= cantidadSolicitada);
                    if (productoAux != null)
                    {
                        Producto producto = null;
                        producto += productoAux;
                        producto.Cantidad = cantidadSolicitada;
                        ventaEnCurso.Add(producto);
                        lblTotal.Text = $"Total: ${Controlador.CalcularSubtotal(ventaEnCurso).ToString("#.00")}";
                    }
                    else
                        MessageBox.Show("Producto sin stock", "Error!");
                }
                else
                    MessageBox.Show("No se puede reingresar el producto", "Error!");
            }
            else
            {
                MessageBox.Show("Producto inexistente", "Error!");
            }
            dataGridViewVentaEnCurso.DataSource = ventaEnCurso;
        }

        /// <summary>
        /// Filtra los productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            switch (cmbBoxFiltrar.SelectedItem)
            {
                case ECategoria.ALIMENTOS:
                    dataGridViewProductos.DataSource = petshop.Productos.FindAll(productos => productos.ECategoriaProp == ECategoria.ALIMENTOS);
                    break;
                case ECategoria.CAMAS:
                    dataGridViewProductos.DataSource = petshop.Productos.FindAll(productos => productos.ECategoriaProp == ECategoria.CAMAS);
                    break;
                case ECategoria.FARMACIA:
                    dataGridViewProductos.DataSource = petshop.Productos.FindAll(productos => productos.ECategoriaProp == ECategoria.FARMACIA);
                    break;
                case ECategoria.JUGUETES:
                    dataGridViewProductos.DataSource = petshop.Productos.FindAll(productos => productos.ECategoriaProp == ECategoria.JUGUETES);
                    break;
                case ECategoria.LIMPIEZA:
                    dataGridViewProductos.DataSource = petshop.Productos.FindAll(productos => productos.ECategoriaProp == ECategoria.LIMPIEZA);
                    break;
                default:
                    MessageBox.Show("Opcion invalida");
                    break;
            }
        }

        /// <summary>
        /// Cambia segun el medio de pago seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbBoxPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxPago.Text = string.Empty;

            if(cmbBoxPago.SelectedIndex == 0)
            { 
                lblCuotasOVuelto.Visible = true;
                cmbCuotas.Visible = true;
                cmbCuotas.SelectedIndex = 0;
                lblTotalCuotas.Visible = true;
                lblCuota.Visible = true;
            }
            else
            {
                lblTotalCuotas.Visible = false;
                lblCuota.Visible = false;
                lblCuotasOVuelto.Visible = false;
                cmbCuotas.Visible = false;
                lblTotal.Text = $"Total: ${Controlador.CalcularSubtotal(ventaEnCurso).ToString("#.00")}";
            }
        }

        /// <summary>
        /// Revisa que la compra sea valida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txtBoxPago.Text, out double pago))
            {
                string opcionseleccionada = cmbBoxPago.Text;
                double subtotal = Controlador.CalcularSubtotal(ventaEnCurso);
                int cuotas = int.Parse(cmbCuotas.Text);
                double total = Controlador.CalcularTotalConCuotas(subtotal, cuotas);

                if (opcionseleccionada == "Credito" && pago != Math.Round(total / cuotas, 2))
                {
                    MessageBox.Show("Monto incorrecto. \nEl pago debe ser igual a la cuota", "No se pudo completar la operacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (opcionseleccionada == "Efectivo" && Controlador.CalcularSubtotal(ventaEnCurso) > pago)
                {
                    MessageBox.Show("Monto insuficiente.", "No se pudo completar la operacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (opcionseleccionada == "Debito" && subtotal != pago)
                {
                    MessageBox.Show("Monto incorrecto.\nDebe ser igual al total.", "No se pudo completar la operacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (ConfirmarVenta(petshop, cliente, ventaEnCurso, opcionseleccionada, cuotas))
                    {
                        foreach (Producto prod in petshop.Productos)
                        {
                            Producto prodAux = ventaEnCurso.Find(producto => producto.Id == prod.Id);
                            if (prodAux != null)
                                prod.Cantidad -= prodAux.Cantidad;
                        }
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Monto invalido", "No se pudo completar la operacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Confirma la venta
        /// </summary>
        /// <param name="petshop"></param>
        /// <param name="cliente"></param>
        /// <param name="ventaEnCurso"></param>
        /// <param name="formaDePago"></param>
        /// <param name="cuotas"></param>
        /// <returns></returns>
        private static bool ConfirmarVenta(Petshop petshop, Cliente cliente, List<Producto> ventaEnCurso, string formaDePago, int cuotas)
        {
            DialogResult respuesta = MessageBox.Show("Confirmar venta?", "Esta seguro?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK)
            {
                if (cuotas > 1)
                    petshop.Ventas.Add(new Venta(cliente, ventaEnCurso, formaDePago, cuotas));
                else
                { 
                   petshop.Ventas.Add(new Venta(cliente, ventaEnCurso, formaDePago));
                }
                MessageBox.Show("Venta realizada", "Ka-ching", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Varia el calculo segun la cantidad de cuotas seleccionadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            double subtotal = Controlador.CalcularSubtotal(ventaEnCurso);
            int cuotas = int.Parse(cmbCuotas.SelectedItem.ToString());
            double total = Controlador.CalcularTotalConCuotas(subtotal, cuotas);
            lblTotal.Text = $"Subtotal: ${subtotal.ToString("#.00")}";
            lblTotalCuotas.Text = $"Total: ${total.ToString("#.00")}";
            lblCuota.Text = $"{cuotas} cuota(s) de ${Math.Round(total / cuotas, 2)}";
        }

        /// <summary>
        /// Muestra el vuelto si se paga en efectivo con un monto mayor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxPago_TextChanged(object sender, EventArgs e)
        {
            double subtotal = Controlador.CalcularSubtotal(ventaEnCurso);

            if (double.TryParse(txtBoxPago.Text, out double pago) && cmbBoxPago.Text == "Efectivo" && subtotal < pago)
            {
                lblCuotasOVuelto.Visible = true;
                lblCuotasOVuelto.Text = $"Vuelto: {(pago - subtotal).ToString("#.00")}";
            }
        }
    }
}
