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

namespace Formularios.FormDeRegistros
{
    public partial class FormRegEmp : FormRegistro
    {
        Empleado empleado;
        public FormRegEmp()
        {
            InitializeComponent();
            comboCargo.DataSource = Enum.GetValues(typeof(ECargo));
            
        }

        public FormRegEmp(Empleado empleado)
            :this()
        {
            this.empleado = empleado;
            TxtNombre = empleado.Nombre;
            TxtApellido = empleado.Apellido;
            TxtMail.Text = empleado.Email;
            TxtMail.Enabled = false;
            comboCargo.Text = empleado.Cargo.ToString();
        }

  
    }
}
