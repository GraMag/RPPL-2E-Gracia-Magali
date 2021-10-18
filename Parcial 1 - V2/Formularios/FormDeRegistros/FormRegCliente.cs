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

namespace Formularios.FormDeRegistros
{
    public partial class FormRegCliente : FormRegistro
    {
        Petshop Petshop;
        public FormRegCliente()
        {
            InitializeComponent();
        }

        public FormRegCliente(Petshop petshop)
            : this()
        {
            Petshop = petshop;
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            base.btnAceptar_Click(sender, e);
        }
    }
}
