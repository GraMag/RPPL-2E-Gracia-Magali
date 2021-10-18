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
    public partial class FormEmpleado : Form
    {
        Petshop petshop;
        Timer timer;
        Boolean darkmode;

        public FormEmpleado()
        {
            InitializeComponent();
            darkmode = false;
            timer = new Timer();
        }

        public FormEmpleado(Petshop petshop, Usuario user)
             : this()
         {
             this.petshop = petshop;
             Controlador.ListarUsuarios(this.petshop);
             lblBienvenido.Text = $"Hola, {user.Nombre}";
             lblDatos.Text = user.ToString();
         }

        public Petshop Petshop
        {
            get
            {
                return petshop;
            }
            set
            {
                petshop = value;
            }
        }

        public DataGridView DataGridViewProp
        {
            get
            {
                return this.dataGridView;
            }
            set
            {
                this.dataGridView = value;
            }
        }

        public bool Darkmode
        {
            get
            {
                return darkmode;
            }
        }
        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            timer.Tick += delegate {
                this.Close();
            };
            timer.Interval = (int)TimeSpan.FromMinutes(1).TotalMilliseconds;
            timer.Start();
        }
        
        /// <summary>
        /// Muestra clientras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void btnClientes_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = petshop.Clientes;
            this.dataGridView.Columns["Password"].Visible = false;
            txtBoxBuscarU.Visible = true;
            txtBoxBuscar.Visible = false;
            lblBuscar.Visible = true;
        }

        /// <summary>
        /// Muestra productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProductos_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = petshop.Productos;
            lblBuscar.Visible = true;
            txtBoxBuscarU.Visible = false;
            txtBoxBuscar.Visible = true;
        }

        /// <summary>
        /// Abre el form de ventas con los datos del cliente seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int.TryParse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(), out int id);

            Cliente cliente = Petshop.Clientes.Find(cliente => cliente.Id == id);
            if (cliente != null)
            {
                FormVentas frmVentas = new FormVentas(petshop, cliente);
                frmVentas.ShowDialog();
            }
        }


        /// <summary>
        /// Cierra sesion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Busca productos por nombre o ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxBuscarProd_TextChanged(object sender, EventArgs e)
        {
            Buscar(petshop.Productos);
        }

        /// <summary>
        /// Busca clientes por nombre o ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxBuscarU_TextChanged(object sender, EventArgs e)
        {
            Buscar(petshop.Clientes);
        }

        /// <summary>
        /// Cambia el color de la pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void btnDarkmode_Click(object sender, EventArgs e)
        {
            if(!darkmode)
            {
                BackColor = Color.Black;
                btnClientes.BackColor = Color.DarkSeaGreen;
                btnProductos.BackColor = Color.DarkSeaGreen;
                btnLogOut.BackColor = Color.DarkSeaGreen;
                btnDarkmode.BackColor = Color.DarkSeaGreen;
                lblBienvenido.ForeColor = Color.LightGoldenrodYellow;
                lblDatos.ForeColor = Color.LightGoldenrodYellow;
                lblBuscar.ForeColor = Color.LightGoldenrodYellow;
            }
            else
            {
                BackColor = Color.DarkOrange;
                this.btnLogOut.BackColor = Color.YellowGreen;
                this.btnDarkmode.BackColor = Color.YellowGreen;
                this.btnClientes.BackColor = Color.GreenYellow;
                this.btnProductos.BackColor = Color.GreenYellow;
                lblBienvenido.ForeColor = Color.White;
                lblBuscar.ForeColor = Color.White;
            }
            darkmode = !darkmode;
        }
        /// <summary>
        /// Busca en la lista un Cliente segun su ID, nombre o apellido
        /// </summary>
        /// <param name="lista">Lista de clientes</param>
        private void Buscar(List<Cliente> lista)
        {
            dataGridView.DataSource = lista.FindAll(item => item.Id.ToString().Contains(txtBoxBuscarU.Text) || item.Nombre.ToLower().Contains(txtBoxBuscarU.Text.ToLower()) || item.Apellido.ToLower().Contains(txtBoxBuscarU.Text.ToLower()));
        }

        /// <summary>
        /// Busca en la lista de Productos segun ID o nombre
        /// </summary>
        /// <param name="lista">Lista de productos</param>
        private void Buscar(List<Producto> lista)
        {
            dataGridView.DataSource = lista.FindAll(item => item.Id.ToString().Contains(txtBoxBuscar.Text) || item.Nombre.ToLower().Contains(txtBoxBuscar.Text.ToLower()));
        }
    }
}

