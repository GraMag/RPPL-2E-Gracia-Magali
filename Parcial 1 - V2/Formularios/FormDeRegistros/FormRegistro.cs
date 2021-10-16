using Biblioteca;
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
    public partial class FormRegistro : Form
    {
        Petshop petshop;
        public FormRegistro()
        {
            InitializeComponent();
        }

        public FormRegistro(Petshop petshop)
            : this()
        {
            this.petshop = petshop;
        }

        public string TxtNombre
        {
            set
            {
                txtBoxNombre.Text = value;
            }
        }

        public string TxtApellido
        {
            set
            {
                txtBoxApellido.Text = value;
            }
        }

        public TextBox TxtMail
        {
            get
            {
                return txtBoxMail;
            }
            set
            {
                txtBoxMail = value;
            }
        }

        /// <summary>
        /// Aceptar usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {


            if ((string.IsNullOrWhiteSpace(txtBoxNombre.Text) && string.IsNullOrWhiteSpace(txtBoxNombre.Text)))
            {
                MessageBox.Show("Debe tener nombre y apellido.", "Esta persona es un NN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Confirmar datos", "Nuevo Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Cliente cliente = new Cliente(txtBoxNombre.Text, txtBoxApellido.Text, txtBoxMail.Text, txtBoxDNI.Text, dateTimePicker1.Value);
                    petshop.Clientes.Add(cliente);
                    FormVentas formVentas = new FormVentas(petshop, cliente);
                    this.Hide();
                    formVentas.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Cancelar operacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Los cambios no se guardaran. Esta seguro?", "Cancelar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
