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

namespace Formularios
{
    public partial class FormLogin : Form
    {
        Petshop petshop;

        public FormLogin()
        {
            InitializeComponent();
            petshop = Petshop.Singleton;
            petshop.UsuariosRegistrados = Controlador.CargarUsuarios();
            petshop.Productos = Controlador.CargarProductos();
        }

        /// <summary>
        /// Abre el formulario correspondiente al usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = Controlador.Login(petshop.UsuariosRegistrados, txtBxUsuario.Text, txtBxPassword.Text);

            if (usuario is Administrador)
            {
                FormAdmin formAdmin = new FormAdmin(petshop, usuario);
                this.Hide();
                formAdmin.ShowDialog();
            }
            else if (usuario is Empleado)
            {
                FormEmpleado formEmpleado = new FormEmpleado(petshop, usuario);
                this.Hide();
                formEmpleado.ShowDialog();
            }
            else if (usuario is Cliente)
                MessageBox.Show(EUsuario.Cliente.ToString());
            else
                MessageBox.Show("Blocky, nuestro perro guardian, no te reconoce.", "Usuario o contraseña invalidos", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
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
