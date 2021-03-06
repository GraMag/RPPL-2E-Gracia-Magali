using Biblioteca;
using Formularios.FormDeRegistros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormAdmin : FormEmpleado
    {

        public FormAdmin(Petshop petshop, Usuario user)
            : base(petshop, user)
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            DataGridViewProp.DataSource = null;
            DataGridViewProp.DataSource = Petshop.Empleados;
            SetearColumnas();
            DataGridViewProp.Enabled = true;
        }

        private void SetearColumnas()
        {
            DataGridViewProp.Columns["ID"].DisplayIndex = 0;
            DataGridViewProp.Columns["NOMBRE"].DisplayIndex = 1;
            DataGridViewProp.Columns["APELLIDO"].DisplayIndex = 2;
            DataGridViewProp.Columns["EMAIL"].DisplayIndex = 3;
            DataGridViewProp.Columns["CARGO"].DisplayIndex = 4;
            DataGridViewProp.Columns["Password"].Visible = false;
        }

        /// <summary>
        /// Al clickar una celda abre el formulario para modificar ese empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int.TryParse(DataGridViewProp.Rows[e.RowIndex].Cells[0].Value.ToString(), out int id);

            Empleado empleado = Petshop.Empleados.Find(emp => emp.Id == id);
            if (empleado != null)
            {
                FormRegEmp formRegEmp = new FormRegEmp(empleado);
                formRegEmp.ShowDialog();
            }
        }


        /// <summary>
        /// Abre el form para ingresar un nuevo cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {  
            DataGridViewProp.DataSource = null;
            FormRegCliente formRegistro = new FormRegCliente(Petshop);
            formRegistro.ShowDialog();
            DataGridViewProp.DataSource = Petshop.Clientes;
            this.DataGridViewProp.Columns["Password"].Visible = false;
            btnNuevoCliente.Hide();
        }
        protected override void btnClientes_Click(object sender, EventArgs e)
        {
            base.btnClientes_Click(sender, e);
            btnNuevoCliente.Show();
        }

        protected override void btnDarkmode_Click(object sender, EventArgs e)
        {
            base.btnDarkmode_Click(sender, e);
            if (Darkmode)
            {
                btnEmpleados.BackColor = Color.DarkSeaGreen;
                btnFacturacion.BackColor = Color.DarkSeaGreen;
                btnNuevoCliente.BackColor = Color.DarkSlateBlue;
            }
            else
            {
                btnEmpleados.BackColor = Color.GreenYellow;
                btnFacturacion.BackColor = Color.GreenYellow;
                btnNuevoCliente.BackColor = Color.GreenYellow;
            }
        }
        /// <summary>
        /// Abre el formulario de facturacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            FormFactura formFactura = new FormFactura();
            formFactura.Show();
        }
    }
}
