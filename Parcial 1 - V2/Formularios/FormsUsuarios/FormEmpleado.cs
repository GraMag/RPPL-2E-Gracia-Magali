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
        public FormEmpleado()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Tick += delegate {
                this.Close();
            };
            timer.Interval = (int)TimeSpan.FromMinutes(1).TotalMilliseconds;
            timer.Start();
        }

        public FormEmpleado(Petshop petshop)
            : this()
        {
            this.petshop = petshop;
            Controlador.ListarUsuarios(this.petshop);
        }

        public FormEmpleado(Petshop petshop, Usuario user)
            : this(petshop)
        {
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

        /// <summary>
        /// Muestra clientras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void btnClientes_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = petshop.Clientes;
            this.dataGridView.Columns["Password"].Visible = false;
        }

        /// <summary>
        /// Muestra productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProductos_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = petshop.Productos;
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
            FormLogin formLogin = new FormLogin();
            this.Hide();
            formLogin.ShowDialog();
        }
    }
}

