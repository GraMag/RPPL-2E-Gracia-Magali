using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
using Biblioteca.Enum;
using Biblioteca.Excepciones;

namespace Formularios
{
    public partial class FormLogin : Form
    {
        Petshop petshop;

        public FormLogin()
        {
            InitializeComponent();
            petshop = Petshop.Singleton;
            Controlador.CargarUsuarios(petshop.UsuariosRegistrados);
            Controlador.CargarProductos(petshop.Productos);
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
        /// <summary>
        /// Abre el formulario correspondiente al usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = Controlador.Login(Petshop.UsuariosRegistrados, txtBxUsuario.Text, txtBxPassword.Text);

                if (usuario is Administrador)
                {
                    FormAdmin formAdmin = new FormAdmin(Petshop, usuario);
                    this.Hide();
                    formAdmin.ShowDialog();
                    this.Show();
                }
                else if (usuario is Empleado)
                {
                    FormEmpleado formEmpleado = new FormEmpleado(Petshop, usuario);
                    this.Hide();
                    formEmpleado.ShowDialog();
                    this.Show();
                }
                else if (usuario is Cliente)
                    MessageBox.Show(EUsuario.Cliente.ToString());
                else
                {
                    throw new UsuarioInvalidoException();
                }
            }
            catch (UsuarioInvalidoException uie)
            {
                MessageBox.Show(uie.Message, "Usuario o contraseña invalidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Ingreso como admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            this.txtBxUsuario.Text = "bugs.bunny@thepetshop.com";
            this.txtBxPassword.Text = "V13j0";
        }

        /// <summary>
        /// Ingreso como empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmpLogin_Click(object sender, EventArgs e)
        {
            this.txtBxUsuario.Text = "ricky.fort@thepetshop.com";
            this.txtBxPassword.Text = "Maiameeee";
        }
    }
}
