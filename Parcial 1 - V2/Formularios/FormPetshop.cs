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
    public partial class FormPetshop : Form
    {
        public FormPetshop()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Abre el form Login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            btnIngresar.Hide();
            formLogin.Show();
        }

    }
}
